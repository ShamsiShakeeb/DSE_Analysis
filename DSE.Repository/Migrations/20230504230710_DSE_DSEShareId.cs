using Microsoft.EntityFrameworkCore.Migrations;

namespace DSE.Repository.Migrations
{
    public partial class DSE_DSEShareId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DSEShare_DSEUrlList_DSEModelId",
                table: "DSEShare");

            migrationBuilder.DropColumn(
                name: "DseModel",
                table: "DSEShare");

            migrationBuilder.RenameColumn(
                name: "DSEModelId",
                table: "DSEShare",
                newName: "DseModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DSEShare_DSEModelId",
                table: "DSEShare",
                newName: "IX_DSEShare_DseModelId");

            migrationBuilder.AlterColumn<int>(
                name: "DseModelId",
                table: "DSEShare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_DSEShare_DSEUrlList_DseModelId",
                table: "DSEShare",
                column: "DseModelId",
                principalTable: "DSEUrlList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DSEShare_DSEUrlList_DseModelId",
                table: "DSEShare");

            migrationBuilder.RenameColumn(
                name: "DseModelId",
                table: "DSEShare",
                newName: "DSEModelId");

            migrationBuilder.RenameIndex(
                name: "IX_DSEShare_DseModelId",
                table: "DSEShare",
                newName: "IX_DSEShare_DSEModelId");

            migrationBuilder.AlterColumn<int>(
                name: "DSEModelId",
                table: "DSEShare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "DseModel",
                table: "DSEShare",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_DSEShare_DSEUrlList_DSEModelId",
                table: "DSEShare",
                column: "DSEModelId",
                principalTable: "DSEUrlList",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
