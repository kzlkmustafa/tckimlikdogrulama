using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace tckimlikdogrulama.Migrations
{
    public partial class startproject : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "signupModels",
                columns: table => new
                {
                    SignupId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TCKimlikNo = table.Column<long>(type: "bigint", nullable: false),
                    Ad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Soyad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DogumYili = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    metamaskaddress = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_signupModels", x => x.SignupId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "signupModels");
        }
    }
}
