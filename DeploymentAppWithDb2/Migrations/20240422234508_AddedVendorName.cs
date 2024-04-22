using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DeploymentAppWithDb2.Migrations
{
    /// <inheritdoc />
    public partial class AddedVendorName : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "VendorName",
                table: "Expenses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "VendorName",
                table: "Expenses");
        }
    }
}
