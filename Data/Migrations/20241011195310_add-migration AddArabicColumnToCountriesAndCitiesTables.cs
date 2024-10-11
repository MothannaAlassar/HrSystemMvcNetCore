using Microsoft.EntityFrameworkCore.Migrations;

namespace HrSystem.Data.Migrations
{
    public partial class addmigrationAddArabicColumnToCountriesAndCitiesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Countries_CountryId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_CountryId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CountryId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Nationality",
                table: "Countries",
                newName: "Nationality_En");

            migrationBuilder.RenameColumn(
                name: "CountryName",
                table: "Countries",
                newName: "Nationality_Ar");

            migrationBuilder.RenameColumn(
                name: "CityName",
                table: "Cities",
                newName: "CityName_En");

            migrationBuilder.AddColumn<string>(
                name: "CountryName_Ar",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CountryName_En",
                table: "Countries",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CityName_Ar",
                table: "Cities",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 1,
                column: "CityName_Ar",
                value: "دبي");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 2,
                column: "CityName_Ar",
                value: "ابو ظبي");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 3,
                column: "CityName_Ar",
                value: "الشارقة");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 4,
                column: "CityName_Ar",
                value: "عجمان");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "Id",
                keyValue: 5,
                column: "CityName_Ar",
                value: "راس الخيمة");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CountryName_Ar", "CountryName_En", "Nationality_Ar" },
                values: new object[] { "الامارات العربية المتحدة", "United Arab Emarites", "اماراتي" });

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CountryName_Ar", "CountryName_En", "Nationality_Ar" },
                values: new object[] { "المملكة العربية السعودية", "Sudia", "سعودي" });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_StayingCountryId",
                table: "Employees",
                column: "StayingCountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Countries_StayingCountryId",
                table: "Employees",
                column: "StayingCountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Countries_StayingCountryId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_StayingCountryId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "CountryName_Ar",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CountryName_En",
                table: "Countries");

            migrationBuilder.DropColumn(
                name: "CityName_Ar",
                table: "Cities");

            migrationBuilder.RenameColumn(
                name: "Nationality_En",
                table: "Countries",
                newName: "Nationality");

            migrationBuilder.RenameColumn(
                name: "Nationality_Ar",
                table: "Countries",
                newName: "CountryName");

            migrationBuilder.RenameColumn(
                name: "CityName_En",
                table: "Cities",
                newName: "CityName");

            migrationBuilder.AddColumn<int>(
                name: "CountryId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountryName",
                value: "United Arab Emarites");

            migrationBuilder.UpdateData(
                table: "Countries",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountryName",
                value: "Sudia");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Countries_CountryId",
                table: "Employees",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
