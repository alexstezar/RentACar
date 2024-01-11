using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RentACar.Migrations
{
    public partial class CarsCollections : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CarCollection");

            migrationBuilder.AddColumn<int>(
                name: "CollectionID",
                table: "Car",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Car_CollectionID",
                table: "Car",
                column: "CollectionID");

            migrationBuilder.AddForeignKey(
                name: "FK_Car_Collection_CollectionID",
                table: "Car",
                column: "CollectionID",
                principalTable: "Collection",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Car_Collection_CollectionID",
                table: "Car");

            migrationBuilder.DropIndex(
                name: "IX_Car_CollectionID",
                table: "Car");

            migrationBuilder.DropColumn(
                name: "CollectionID",
                table: "Car");

            migrationBuilder.CreateTable(
                name: "CarCollection",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CarID = table.Column<int>(type: "int", nullable: false),
                    CollectionID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CarCollection", x => x.ID);
                    table.ForeignKey(
                        name: "FK_CarCollection_Car_CarID",
                        column: x => x.CarID,
                        principalTable: "Car",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CarCollection_Collection_CollectionID",
                        column: x => x.CollectionID,
                        principalTable: "Collection",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CarCollection_CarID",
                table: "CarCollection",
                column: "CarID");

            migrationBuilder.CreateIndex(
                name: "IX_CarCollection_CollectionID",
                table: "CarCollection",
                column: "CollectionID");
        }
    }
}
