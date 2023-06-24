using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace truongblu001.Migrations
{
    /// <inheritdoc />
    public partial class Create_table_TXTCompany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TXTCompany",
                columns: table => new
                {
                    CompanyID = table.Column<string>(type: "TEXT", nullable: false),
                    CompanyName = table.Column<string>(type: "TEXT", nullable: true),
                    AddressID = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTCompany", x => x.CompanyID);
                });

            migrationBuilder.CreateTable(
                name: "TXTStudent",
                columns: table => new
                {
                    TXTID = table.Column<string>(type: "TEXT", nullable: false),
                    TXTSEX = table.Column<string>(type: "TEXT", nullable: true),
                    TXTNAME = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TXTStudent", x => x.TXTID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TXTCompany");

            migrationBuilder.DropTable(
                name: "TXTStudent");
        }
    }
}
