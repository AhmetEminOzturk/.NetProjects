using Microsoft.EntityFrameworkCore.Migrations;

namespace SpryStore.DataAccessLayer.Migrations
{
    public partial class mig2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "EmployeeID",
                table: "Customers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeSurname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeMail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmployeeImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeID);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EmployeeID",
                table: "Customers",
                column: "EmployeeID");

            migrationBuilder.AddForeignKey(
                name: "FK_Customers_Employees_EmployeeID",
                table: "Customers",
                column: "EmployeeID",
                principalTable: "Employees",
                principalColumn: "EmployeeID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Customers_Employees_EmployeeID",
                table: "Customers");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Customers_EmployeeID",
                table: "Customers");

            migrationBuilder.DropColumn(
                name: "EmployeeID",
                table: "Customers");
        }
    }
}
