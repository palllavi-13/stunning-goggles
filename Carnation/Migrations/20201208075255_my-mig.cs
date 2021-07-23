using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Carnation.Migrations
{
    public partial class mymig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Product_Detail",
                columns: table => new
                {
                    PId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PName = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PCompany = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    PPrice = table.Column<double>(type: "float", nullable: false),
                    PDescription = table.Column<string>(type: "nvarchar(200)", nullable: false),
                    UName = table.Column<string>(type: "nvarchar(100)", nullable: false),
                    PQuality = table.Column<string>(type: "nvarchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product_Detail", x => x.PId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product_Detail");
        }
    }
}
