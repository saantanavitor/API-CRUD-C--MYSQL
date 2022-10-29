using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebAPIFC.Migrations
{
    public partial class inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            _=migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(15000)", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    nameUser = table.Column<string>(type: "varchar(70)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    loginUser = table.Column<string>(type: "varchar(15)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    passwordUser = table.Column<string>(type: "varchar(20)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    Email = table.Column<string>(type: "varchar(50)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    Phone = table.Column<string>(type: "varchar(15)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    CPF = table.Column<string>(type: "varchar(15)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    birthDate = table.Column<string>(type: "date", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    mothersName = table.Column<string>(type: "varchar(70)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    statusUser = table.Column<string>(type: "varchar(11)", maxLength: 200, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    created_at = table.Column<string>(type: "datetime", maxLength: 200, nullable: true )
                        .Annotation("MySql:CharSet", "utf8mb4"),

                    updated_at = table.Column<string>(type: "datetime", maxLength: 200, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);                 
                })
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "user");
        }
    }
}
