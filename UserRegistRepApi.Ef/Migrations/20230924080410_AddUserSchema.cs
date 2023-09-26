using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UserRegistRepApi.Ef.Migrations
{
    /// <inheritdoc />
    public partial class AddUserSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Users");

            migrationBuilder.CreateTable(
                name: "PositionsTBL",
                schema: "Users",
                columns: table => new
                {
                    PositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PositionName = table.Column<string>(type: "nvarchar(75)", maxLength: 75, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistUserID = table.Column<int>(type: "int", nullable: true),
                    RegistDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionsTBL", x => x.PositionID);
                });

            migrationBuilder.CreateTable(
                name: "UsersTBL",
                schema: "Users",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NationalNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    PhoneNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    MobileNo = table.Column<string>(type: "nvarchar(11)", maxLength: 11, nullable: false),
                    UserPic = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistUserID = table.Column<int>(type: "int", nullable: true),
                    RegistDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsersTBL", x => x.UserID);
                });

            migrationBuilder.CreateTable(
                name: "UserPositionTBL",
                schema: "Users",
                columns: table => new
                {
                    UserPositionID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    PositionID = table.Column<int>(type: "int", nullable: false),
                    usersUserID = table.Column<int>(type: "int", nullable: false),
                    posistionsPositionID = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    RegistUserID = table.Column<int>(type: "int", nullable: true),
                    RegistDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPositionTBL", x => x.UserPositionID);
                    table.ForeignKey(
                        name: "FK_UserPositionTBL_PositionsTBL_posistionsPositionID",
                        column: x => x.posistionsPositionID,
                        principalSchema: "Users",
                        principalTable: "PositionsTBL",
                        principalColumn: "PositionID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPositionTBL_UsersTBL_usersUserID",
                        column: x => x.usersUserID,
                        principalSchema: "Users",
                        principalTable: "UsersTBL",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserPositionTBL_posistionsPositionID",
                schema: "Users",
                table: "UserPositionTBL",
                column: "posistionsPositionID");

            migrationBuilder.CreateIndex(
                name: "IX_UserPositionTBL_usersUserID",
                schema: "Users",
                table: "UserPositionTBL",
                column: "usersUserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserPositionTBL",
                schema: "Users");

            migrationBuilder.DropTable(
                name: "PositionsTBL",
                schema: "Users");

            migrationBuilder.DropTable(
                name: "UsersTBL",
                schema: "Users");
        }
    }
}
