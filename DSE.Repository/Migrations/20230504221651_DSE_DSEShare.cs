using Microsoft.EntityFrameworkCore.Migrations;

namespace DSE.Repository.Migrations
{
    public partial class DSE_DSEShare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DSEShare",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DSEModelId = table.Column<int>(type: "int", nullable: true),
                    DseModel = table.Column<int>(type: "int", nullable: false),
                    DateTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Share = table.Column<double>(type: "float", nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    Month = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DSEShare", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DSEShare_DSEUrlList_DSEModelId",
                        column: x => x.DSEModelId,
                        principalTable: "DSEUrlList",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DSEShare_DSEModelId",
                table: "DSEShare",
                column: "DSEModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DSEShare");
        }
    }
}
