using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace app07.Migrations
{
    /// <inheritdoc />
    public partial class category_isActive : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "forosh",
                table: "Dastebandi",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "forosh",
                table: "Dastebandi");
        }
    }
}
