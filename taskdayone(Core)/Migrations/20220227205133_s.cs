using Microsoft.EntityFrameworkCore.Migrations;

namespace taskdayone_Core_.Migrations
{
    public partial class s : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_Departmentid",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "deptid",
                table: "Employees",
                newName: "deptId");

            migrationBuilder.RenameColumn(
                name: "Departmentid",
                table: "Employees",
                newName: "DepartmentdeptId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_Departmentid",
                table: "Employees",
                newName: "IX_Employees_DepartmentdeptId");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Departments",
                newName: "deptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentdeptId",
                table: "Employees",
                column: "DepartmentdeptId",
                principalTable: "Departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentdeptId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "deptId",
                table: "Employees",
                newName: "deptid");

            migrationBuilder.RenameColumn(
                name: "DepartmentdeptId",
                table: "Employees",
                newName: "Departmentid");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_DepartmentdeptId",
                table: "Employees",
                newName: "IX_Employees_Departmentid");

            migrationBuilder.RenameColumn(
                name: "deptId",
                table: "Departments",
                newName: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_Departmentid",
                table: "Employees",
                column: "Departmentid",
                principalTable: "Departments",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
