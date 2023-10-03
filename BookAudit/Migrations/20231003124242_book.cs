using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BookAudit.Migrations
{
    public partial class book : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Isnb",
                table: "Book",
                newName: "Isbn");

            migrationBuilder.AddColumn<int>(
                name: "PublisherId",
                table: "Book",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Publisher",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PublisherName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Publisher", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Publisher");

            migrationBuilder.DropColumn(
                name: "PublisherId",
                table: "Book");

            migrationBuilder.RenameColumn(
                name: "Isbn",
                table: "Book",
                newName: "Isnb");
        }
    }
}
