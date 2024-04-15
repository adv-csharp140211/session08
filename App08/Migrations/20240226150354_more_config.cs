using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app07.Migrations
{
    /// <inheritdoc />
    public partial class more_config : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Products",
                table: "Products");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.EnsureSchema(
                name: "forosh");

            migrationBuilder.RenameTable(
                name: "Products",
                newName: "Mahsol",
                newSchema: "forosh");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Dastebandi",
                newSchema: "forosh");

            migrationBuilder.RenameIndex(
                name: "IX_Products_CategoryId",
                schema: "forosh",
                table: "Mahsol",
                newName: "IX_Mahsol_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                schema: "forosh",
                table: "Mahsol",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "forosh",
                table: "Mahsol",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "forosh",
                table: "Dastebandi",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mahsol",
                schema: "forosh",
                table: "Mahsol",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Dastebandi",
                schema: "forosh",
                table: "Dastebandi",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Mahsol_Dastebandi_CategoryId",
                schema: "forosh",
                table: "Mahsol",
                column: "CategoryId",
                principalSchema: "forosh",
                principalTable: "Dastebandi",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Mahsol_Dastebandi_CategoryId",
                schema: "forosh",
                table: "Mahsol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Mahsol",
                schema: "forosh",
                table: "Mahsol");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Dastebandi",
                schema: "forosh",
                table: "Dastebandi");

            migrationBuilder.RenameTable(
                name: "Mahsol",
                schema: "forosh",
                newName: "Products");

            migrationBuilder.RenameTable(
                name: "Dastebandi",
                schema: "forosh",
                newName: "Categories");

            migrationBuilder.RenameIndex(
                name: "IX_Mahsol_CategoryId",
                table: "Products",
                newName: "IX_Products_CategoryId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Products",
                table: "Products",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_Categories_CategoryId",
                table: "Products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
