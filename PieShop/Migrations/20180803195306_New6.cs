using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PieShop.Migrations
{
    public partial class New6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Pies",
               columns: table => new
               {
                   PieId = table.Column<int>(nullable: false)
                       .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                   Name = table.Column<string>(nullable: true),
                   ShortDescription = table.Column<string>(nullable: true),
                   LongDescription = table.Column<string>(nullable: true),
                   AllergyInformation = table.Column<string>(nullable: true),
                   Price = table.Column<decimal>(nullable: false),
                   ImageUrl = table.Column<string>(nullable: true),
                   ImageThumbnailUrl = table.Column<string>(nullable: true),
                   IsPieOfTheWeek = table.Column<bool>(nullable: false),
                   InStock = table.Column<bool>(nullable: false),
                   CategoryId = table.Column<int>(nullable: false)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Pies", x => x.PieId);
                   table.ForeignKey(
                       name: "FK_Pies_Categories_CategoryId",
                       column: x => x.CategoryId,
                       principalTable: "Categories",
                       principalColumn: "CategoryId",
                       onDelete: ReferentialAction.Cascade);
               });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
