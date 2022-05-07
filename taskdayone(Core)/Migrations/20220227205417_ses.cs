using Microsoft.EntityFrameworkCore.Migrations;

namespace taskdayone_Core_.Migrations
{
    public partial class ses : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_DepartmentdeptId",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_DepartmentdeptId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "DepartmentdeptId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "deptId",
                table: "Employees",
                newName: "departmentid");

            migrationBuilder.RenameColumn(
                name: "deptId",
                table: "Departments",
                newName: "departmentid");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_departmentid",
                table: "Employees",
                column: "departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_departmentid",
                table: "Employees",
                column: "departmentid",
                principalTable: "Departments",
                principalColumn: "departmentid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Departments_departmentid",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_departmentid",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "departmentid",
                table: "Employees",
                newName: "deptId");

            migrationBuilder.RenameColumn(
                name: "departmentid",
                table: "Departments",
                newName: "deptId");

            migrationBuilder.AddColumn<int>(
                name: "DepartmentdeptId",
                table: "Employees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Employees_DepartmentdeptId",
                table: "Employees",
                column: "DepartmentdeptId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Departments_DepartmentdeptId",
                table: "Employees",
                column: "DepartmentdeptId",
                principalTable: "Departments",
                principalColumn: "deptId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
