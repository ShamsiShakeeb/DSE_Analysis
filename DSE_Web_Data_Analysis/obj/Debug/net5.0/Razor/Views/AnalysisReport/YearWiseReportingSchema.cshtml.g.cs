#pragma checksum "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "549ccf13f6fde75e1774146d51b4b80ba1ab7435"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AnalysisReport_YearWiseReportingSchema), @"mvc.1.0.view", @"/Views/AnalysisReport/YearWiseReportingSchema.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\_ViewImports.cshtml"
using DSE_Web_Data_Analysis;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\_ViewImports.cshtml"
using DSE_Web_Data_Analysis.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\_ViewImports.cshtml"
using DSE.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"549ccf13f6fde75e1774146d51b4b80ba1ab7435", @"/Views/AnalysisReport/YearWiseReportingSchema.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"070484bbe212f74de9df1ad68fa4dbbcb7ba9b8c", @"/Views/_ViewImports.cshtml")]
    public class Views_AnalysisReport_YearWiseReportingSchema : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DSE.Model.ViewModel.MonthWisePickPointAnalysisBeforeDecember>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
  
    ViewData["Title"] = "YearWiseReportingSchema";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>YearWiseReportingSchema</h1>\r\n\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 13 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayNameFor(model => model.ThisMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 16 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayNameFor(model => model.ThisMonthShare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayNameFor(model => model.NextMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayNameFor(model => model.NextMonthShare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Profit\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n         \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 34 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 37 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayFor(modelItem => item.ThisMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 40 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayFor(modelItem => item.ThisMonthShare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 43 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayFor(modelItem => item.NextMonth));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 46 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayFor(modelItem => item.NextMonthShare));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 49 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(string.Format("{0}",(item.NextMonthShare- item.ThisMonthShare)));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 52 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
           Write(Html.DisplayFor(modelItem => item.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n");
#nullable restore
#line 56 "C:\Users\BS483\source\repos\DSE_Web_Data_Analysis\DSE_Web_Data_Analysis\Views\AnalysisReport\YearWiseReportingSchema.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DSE.Model.ViewModel.MonthWisePickPointAnalysisBeforeDecember>> Html { get; private set; }
    }
}
#pragma warning restore 1591
