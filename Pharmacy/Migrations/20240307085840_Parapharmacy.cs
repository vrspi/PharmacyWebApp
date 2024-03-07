using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Pharmacy.Migrations
{
    /// <inheritdoc />
    public partial class Parapharmacy : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CityId",
                table: "pharmacies",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                table: "pharmacies",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "citys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_citys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "parapharmacy",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Serial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GpsCoord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parapharmacy", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "produits",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prix = table.Column<float>(type: "real", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produits", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "images",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MedicamentId = table.Column<int>(type: "int", nullable: false),
                    ProduitId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_images_medicaments_MedicamentId",
                        column: x => x.MedicamentId,
                        principalTable: "medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_images_produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "stock_produit",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParaPharmacyId = table.Column<int>(type: "int", nullable: false),
                    ProduitId = table.Column<int>(type: "int", nullable: false),
                    Qte = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_stock_produit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_stock_produit_parapharmacy_ParaPharmacyId",
                        column: x => x.ParaPharmacyId,
                        principalTable: "parapharmacy",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_stock_produit_produits_ProduitId",
                        column: x => x.ProduitId,
                        principalTable: "produits",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_pharmacies_CityId",
                table: "pharmacies",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_images_MedicamentId",
                table: "images",
                column: "MedicamentId");

            migrationBuilder.CreateIndex(
                name: "IX_images_ProduitId",
                table: "images",
                column: "ProduitId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_produit_ParaPharmacyId",
                table: "stock_produit",
                column: "ParaPharmacyId");

            migrationBuilder.CreateIndex(
                name: "IX_stock_produit_ProduitId",
                table: "stock_produit",
                column: "ProduitId");

            migrationBuilder.AddForeignKey(
                name: "FK_pharmacies_citys_CityId",
                table: "pharmacies",
                column: "CityId",
                principalTable: "citys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_pharmacies_citys_CityId",
                table: "pharmacies");

            migrationBuilder.DropTable(
                name: "citys");

            migrationBuilder.DropTable(
                name: "images");

            migrationBuilder.DropTable(
                name: "stock_produit");

            migrationBuilder.DropTable(
                name: "parapharmacy");

            migrationBuilder.DropTable(
                name: "produits");

            migrationBuilder.DropIndex(
                name: "IX_pharmacies_CityId",
                table: "pharmacies");

            migrationBuilder.DropColumn(
                name: "CityId",
                table: "pharmacies");

            migrationBuilder.DropColumn(
                name: "Image",
                table: "pharmacies");
        }
    }
}
