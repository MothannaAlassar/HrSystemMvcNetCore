using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class AddAttachmentFileColumnToEmployeeTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AttachmentFile",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AttachmentFile",
                table: "Employees");
        }
    }
}
