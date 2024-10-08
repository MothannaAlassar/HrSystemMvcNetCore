using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class Add_ArabicColumnsForDeptAndEmplyoee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employees",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Departments",
                newName: "Name_En");

            migrationBuilder.AddColumn<string>(
                name: "Name_Ar",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name_Ar",
                table: "Departments",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name_Ar",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Name_Ar",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "Departments",
                newName: "Name");

           
        }
    }
}
