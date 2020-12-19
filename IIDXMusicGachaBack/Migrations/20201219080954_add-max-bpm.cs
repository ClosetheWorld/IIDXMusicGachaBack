using Microsoft.EntityFrameworkCore.Migrations;

namespace IIDXMusicGachaBack.Migrations
{
    public partial class addmaxbpm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "MaxBpm",
                table: "Songs",
                type: "float",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MaxBpm",
                table: "Songs");
        }
    }
}
