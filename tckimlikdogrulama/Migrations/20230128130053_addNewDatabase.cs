using Microsoft.EntityFrameworkCore.Migrations;

namespace tckimlikdogrulama.Migrations
{
    public partial class addNewDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TCKimlikNo",
                table: "signupModels",
                type: "bigint",
                nullable: true,
                oldClrType: typeof(long),
                oldType: "bigint");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "TCKimlikNo",
                table: "signupModels",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldNullable: true);
        }
    }
}
