using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    public partial class CarBorrowings : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Borrowing_BorrowingID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_BorrowingID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "BorrowingID",
                table: "Car");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Borrowing",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Borrowing_CarID",
                table: "Borrowing",
                column: "CarID");

            migrationBuilder.AddForeignKey(
                name: "FK_Borrowing_Car_CarID",
                table: "Borrowing",
                column: "CarID",
                principalTable: "Car",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Borrowing_Car_CarID",
                table: "Borrowing");

            migrationBuilder.DropIndex(
                name: "IX_Borrowing_CarID",
                table: "Borrowing");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Borrowing");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Client",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BorrowingID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_BorrowingID",
                table: "Car",
                column: "BorrowingID",
                unique: true,
                filter: "[BorrowingID] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Borrowing_BorrowingID",
                table: "Car",
                column: "BorrowingID",
                principalTable: "Borrowing",
                principalColumn: "ID");
        }
    }
}
