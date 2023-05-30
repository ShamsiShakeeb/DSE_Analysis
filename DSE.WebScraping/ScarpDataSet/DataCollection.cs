using DSE.Model.Entity;
using DSE.Model.Response;
using DSE.Service.DSEShare;
using DSE.Service.DSEUrlList;
using DSE.WebScraping.Model;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace DSE.WebScraping.ScarpDataSet
{
    public class DataCollection : IDataCollection
    {
        private readonly IDSEUrlListService _iDSEUrlListService;
        private readonly IDSEShare _dSEShare;
        public DataCollection(IDSEUrlListService iDSEUrlListService, IDSEShare dSEShare)
        {
            _iDSEUrlListService = iDSEUrlListService;
            _dSEShare = dSEShare;
        }
        private async Task<ResponseModel<List<DSE.Model.Entity.DSEShare>>> FetchDataFromDSE(string url,int Fk)
        {
            char[] ints = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("headless");
            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl(url);
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            string body = (string)js.ExecuteScript("return document.documentElement.outerHTML");
            string[] splits = body.Split('\n');
            string split = body.Split('\n')[27].Contains("Date,Price")? body.Split('\n')[28]:body.Split('\n')[27];
            string data = "";
            char[] a = split.ToCharArray();
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == '-' || a[i] == ',' || a[i] == '.' || ints.Contains(a[i]) || a[i] == '\\')
                {
                    data += a[i];
                }
            }
            string dataSet = data;
            var dataList = dataSet.Split('\\').ToList();
            List<DSE.Model.Entity.DSEShare> dSEShares = new List<DSE.Model.Entity.DSEShare>();
            for(int i = 0; i < dataList.Count()-1; i++)
            {
                var model = new DSE.Model.Entity.DSEShare()
                {
                    DateTime = dataList[i].Split(',')[0],
                    Share = Convert.ToDouble(dataList[i].Split(',')[1]),
                    Year = Convert.ToInt32(dataList[i].Split(',')[0].Split('-')[0]),
                    Month = Convert.ToInt32(dataList[i].Split(',')[0].Split('-')[1]),
                    Date = Convert.ToInt32(dataList[i].Split(',')[0].Split('-')[2]),
                    DseModelId = Fk
                };
                dSEShares.Add(model);
            }
            driver.Close();
            var res = await _dSEShare.InsertRange(dSEShares);
            return res;

        }
        public async Task <ResponseModel<List<DSEModel>>> StoreUrl(int year)
        {
            int months = year * 12;
            List<DSE.Model.Entity.DSEModel> CompanyNames = new List<DSE.Model.Entity.DSEModel>();
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            ChromeOptions options = new ChromeOptions();
           // options.AddArgument("headless");
            ChromeDriver driver = new ChromeDriver(options);
            driver.Navigate().GoToUrl("https://dsebd.org/by_industrylisting.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            object sectorLength = js.ExecuteScript("return document.querySelectorAll('.table-responsive')[0].querySelectorAll('tbody')[0].querySelectorAll('tr').length");
            int length = Convert.ToInt32(sectorLength);
            for (int i = 1; i < length - 1; i++)
            {
                var sector = (string)js.ExecuteScript(string.Format("return document.querySelectorAll('.table')[0].querySelectorAll('tbody')[0].querySelectorAll('tr')[{0}].querySelectorAll('a')[0].innerHTML", i));

                js.ExecuteScript(string.Format("document.querySelectorAll('.table')[0].querySelectorAll('tbody')[0].querySelectorAll('tr')[{0}].querySelectorAll('a')[0].click()", i));

                object companyLength = js.ExecuteScript("return document.querySelectorAll('.table')[0].querySelectorAll('tbody')[0].querySelectorAll('tr').length");
                int companies = Convert.ToInt32(companyLength);
                object complexUi = js.ExecuteScript("return document.querySelectorAll('.table')[0].querySelectorAll('tbody')[0].querySelectorAll('tr')[0].querySelectorAll('th').length");
                bool uiChange = false;
                if (Convert.ToInt32(complexUi) != 11)
                {
                    uiChange = true;
                    companyLength = js.ExecuteScript("return document.querySelectorAll('.table-responsive')[0].querySelectorAll('tbody')[0].querySelectorAll('tr')[0].querySelectorAll('a').length");
                    companies = Convert.ToInt32(companyLength);
                }
                int start = !uiChange ? 1 : 0;
                for (int j = start; j < companies; j++)
                {
                    string companyName = "";
                    if (!uiChange)
                        companyName = (string)js.ExecuteScript(string.Format("return document.querySelectorAll('.table')[0].querySelectorAll('tbody')[0].querySelectorAll('tr')[{0}].querySelectorAll('td')[1].querySelectorAll('a')[0].innerText", j));
                    else
                        companyName = (string)js.ExecuteScript(string.Format("return document.querySelectorAll('.table-responsive')[0].querySelectorAll('tbody')[0].querySelectorAll('tr')[0].querySelectorAll('a')[{0}].innerHTML", j));
                    if (!string.IsNullOrEmpty(companyName))
                    {
                        DSE.Model.Entity.DSEModel dSEModel = new DSE.Model.Entity.DSEModel()
                        {
                            CompanyName = companyName,
                            Sector = sector,
                            Url = string.Format("https://dsebd.org/php_graph/monthly_graph.php?inst={0}&duration={1}&type=price", companyName, months)
                        };
                        CompanyNames.Add(dSEModel);
                    }
                }

                js.ExecuteScript("window.history.go(-1);");

            }
            var result = await _iDSEUrlListService.InsertRange(CompanyNames);
            return result;
        }
        public async Task<ResponseModel<string>> StoreShareMarketYearWiseClosingReport()
        {
            try
            {
                var data = _iDSEUrlListService.Get(x => true).ToList();

                for (int i = 0; i < data.Count(); i++)
                {
                    await FetchDataFromDSE(data[i].Url, data[i].Id);
                }
                return new ResponseModel<string>() {
                    success = true,
                    Message = "Data Inserted Successfully",
                    ErrorMessage = null,
                    Data = "No Data Visibility For This Method"
                };
            }
            catch(Exception ex)
            {
                return new ResponseModel<string>()
                {
                    success = true,
                    Message = "Data Inserted Successfully",
                    ErrorMessage = ex.Message,
                    Data = "No Data Visibility For This Method"
                };
            }
        }
    }
}
