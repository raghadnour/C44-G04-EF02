using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Demo.Migrations
{
    /// <inheritdoc />
    public partial class TryFluentAPIs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Employee");

            migrationBuilder.RenameColumn(
                name: "Salary",
                table: "Employee",
                newName: "EmpSalary");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employee",
                newName: "EmpName");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Employee",
                newName: "EmpAge");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employee",
                newName: "EmpId");

            migrationBuilder.AlterColumn<string>(
                name: "EmpName",
                table: "Employee",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employee",
                table: "Employee",
                column: "EmpId");

            migrationBuilder.AddCheckConstraint(
                name: "Range_Age",
                table: "Employee",
                sql: "[EmpAge] between 20 and 35");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Employee",
                table: "Employee");

            migrationBuilder.DropCheckConstraint(
                name: "Range_Age",
                table: "Employee");

            migrationBuilder.RenameTable(
                name: "Employee",
                newName: "Employees");

            migrationBuilder.RenameColumn(
                name: "EmpSalary",
                table: "Employees",
                newName: "Salary");

            migrationBuilder.RenameColumn(
                name: "EmpName",
                table: "Employees",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmpAge",
                table: "Employees",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "EmpId",
                table: "Employees",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Employees",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");
        }
    }
}
