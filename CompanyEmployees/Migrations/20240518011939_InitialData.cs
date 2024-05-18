using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CompanyEmployees.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"), "583 Wall Dr. Gwynn Oak, MD 21207", "USA", "IT_Solution Ltd" });

            migrationBuilder.InsertData(
                table: "Companies",
                columns: new[] { "CompanyId", "Address", "Country", "Name" },
                values: new object[] { new Guid("f8831fb0-fda0-4e35-8f64-5d19da2518b5"), "312 Forest Avenue, BF 923", "USA", "Admin_Solution Ltd" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("050d0ca3-8b80-4edd-bb58-2afb2f0fafbe"), 35, new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"), "Kane Miller", "Administrator" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"), 26, new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"), "Sam Raiden", "Software developer" });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Age", "CompanyId", "Name", "Position" },
                values: new object[] { new Guid("e04f4a64-0245-420f-9397-ee902dab7d5f"), 30, new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"), "Jana McLeaf", "Software developer" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("f8831fb0-fda0-4e35-8f64-5d19da2518b5"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("050d0ca3-8b80-4edd-bb58-2afb2f0fafbe"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"));

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: new Guid("e04f4a64-0245-420f-9397-ee902dab7d5f"));

            migrationBuilder.DeleteData(
                table: "Companies",
                keyColumn: "CompanyId",
                keyValue: new Guid("1058ea13-52e1-49e6-ac62-416b32a04258"));
        }
    }
}
