using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class AddColumnsToEmployeesTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name_En",
                table: "Employees",
                newName: "Phone_Number");

            migrationBuilder.RenameColumn(
                name: "Name_Ar",
                table: "Employees",
                newName: "Last_Name_En");

            migrationBuilder.AddColumn<DateTime>(
                name: "AddedDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AddedUser",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "DeletedUser",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EditedDate",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "EditedUser",
                table: "Employees",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name_Ar",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "First_Name_En",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Hire_Date",
                table: "Employees",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Img_Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "Employees",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Last_Name_Ar",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AddedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "AddedUser",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DeletedUser",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EditedDate",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "EditedUser",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "First_Name_Ar",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "First_Name_En",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Hire_Date",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Img_Name",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "Last_Name_Ar",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Phone_Number",
                table: "Employees",
                newName: "Name_En");

            migrationBuilder.RenameColumn(
                name: "Last_Name_En",
                table: "Employees",
                newName: "Name_Ar");
        }
    }
}
