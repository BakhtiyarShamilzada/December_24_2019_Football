using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace December_24_2019_Football.Migrations
{
    public partial class Football : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FootballerPositions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballerPositions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Positions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Positions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PositionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PositionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Stadiums",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stadiums", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    CountryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Teams_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GameTimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Team1Id = table.Column<int>(nullable: false),
                    Team2Id = table.Column<int>(nullable: false),
                    PositionType1Id = table.Column<int>(nullable: false),
                    PositionType2Id = table.Column<int>(nullable: false),
                    StadiumId = table.Column<int>(nullable: false),
                    Date = table.Column<DateTime>(nullable: false),
                    Color1 = table.Column<string>(nullable: true),
                    Color2 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GameTimes_Stadiums_StadiumId",
                        column: x => x.StadiumId,
                        principalTable: "Stadiums",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Firstname = table.Column<string>(maxLength: 50, nullable: false),
                    Lastname = table.Column<string>(maxLength: 50, nullable: true),
                    Age = table.Column<int>(nullable: false),
                    PositionId = table.Column<int>(nullable: false),
                    TeamId = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayers_Positions_PositionId",
                        column: x => x.PositionId,
                        principalTable: "Positions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballCarts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FootballPlayerId = table.Column<int>(nullable: false),
                    CartId = table.Column<int>(nullable: false),
                    GameTimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballCarts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballCarts_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCarts_FootballPlayers_FootballPlayerId",
                        column: x => x.FootballPlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballCarts_GameTimes_GameTimeId",
                        column: x => x.GameTimeId,
                        principalTable: "GameTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FootballPlayerGameTimes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FootballPlayerId = table.Column<int>(nullable: false),
                    FootballerPositionId = table.Column<int>(nullable: false),
                    GameTimeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FootballPlayerGameTimes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FootballPlayerGameTimes_FootballPlayers_FootballPlayerId",
                        column: x => x.FootballPlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayerGameTimes_FootballerPositions_FootballerPositionId",
                        column: x => x.FootballerPositionId,
                        principalTable: "FootballerPositions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FootballPlayerGameTimes_GameTimes_GameTimeId",
                        column: x => x.GameTimeId,
                        principalTable: "GameTimes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Transfers",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FootballPlayerId = table.Column<int>(nullable: false),
                    OldTeamId = table.Column<int>(nullable: false),
                    NewTeamId = table.Column<int>(nullable: false),
                    Price = table.Column<decimal>(nullable: false),
                    TeamId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transfers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Transfers_FootballPlayers_FootballPlayerId",
                        column: x => x.FootballPlayerId,
                        principalTable: "FootballPlayers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Transfers_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Carts",
                columns: new[] { "Id", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "Cart/red.png", "Red" },
                    { 2, "Cart/yellow.png", "Yellow" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Mexico" },
                    { 2, "Brazil" }
                });

            migrationBuilder.InsertData(
                table: "FootballerPositions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 10, "10" },
                    { 8, "8" },
                    { 7, "7" },
                    { 6, "6" },
                    { 9, "9" },
                    { 4, "4" },
                    { 3, "3" },
                    { 2, "2" },
                    { 1, "1" },
                    { 5, "5" }
                });

            migrationBuilder.InsertData(
                table: "PositionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 2, "4-2-4" },
                    { 1, "3-4-3" }
                });

            migrationBuilder.InsertData(
                table: "Positions",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 8, "Behind the Striker" },
                    { 7, "Striker" },
                    { 6, "Wide Midfield" },
                    { 4, "Sweeper" },
                    { 3, "Centre-Backs" },
                    { 2, "Full-backs" },
                    { 1, "Goalkeeper" },
                    { 5, "Central Midfield" }
                });

            migrationBuilder.InsertData(
                table: "Stadiums",
                columns: new[] { "Id", "Address", "Image", "Name" },
                values: new object[,]
                {
                    { 1, "‎1 Scarlet Knight Way", "Stadium/1.png", "Infinity Ring" },
                    { 2, "Jake Nevin Field House", "Stadium/2.jfif", "Paragon Field" }
                });

            migrationBuilder.InsertData(
                table: "GameTimes",
                columns: new[] { "Id", "Color1", "Color2", "Date", "PositionType1Id", "PositionType2Id", "StadiumId", "Team1Id", "Team2Id" },
                values: new object[] { 1, null, null, new DateTime(2019, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, 1, 1, 2 });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 2, 2, "SV werder bremen" });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CountryId", "Name" },
                values: new object[] { 1, 1, "Real madrid" });

            migrationBuilder.InsertData(
                table: "FootballPlayers",
                columns: new[] { "Id", "Age", "Firstname", "Image", "Lastname", "PositionId", "TeamId" },
                values: new object[,]
                {
                    { 1, 25, "Robben", "FootballPlayer/1.png", "Robben", 1, 1 },
                    { 18, 26, "Pepe", "FootballPlayer/18.jpg", "Pepe", 6, 2 },
                    { 17, 31, "Nacho", "FootballPlayer/17.jpg", "Nacho", 5, 2 },
                    { 16, 33, "Modric", "FootballPlayer/16.jpg", "Modric", 8, 2 },
                    { 15, 29, "Carvajal", "FootballPlayer/15.jpg", "Carvajal", 7, 2 },
                    { 14, 26, "Silva", "FootballPlayer/14.jpg", "Silva", 6, 2 },
                    { 13, 31, "Kroos", "FootballPlayer/13.jpg", "Kroos", 5, 2 },
                    { 12, 28, "Benzema", "FootballPlayer/12.jpg", "Benzema", 4, 2 },
                    { 11, 32, "Bale", "FootballPlayer/11.jpg", "Bale", 3, 2 },
                    { 10, 27, "Neuer", "FootballPlayer/10.jpg", "Neuer", 2, 1 },
                    { 9, 25, "Benatia", "FootballPlayer/9.jpg", "Benatia", 1, 1 },
                    { 8, 33, "Dante", "FootballPlayer/8.jpg", "Dante", 8, 1 },
                    { 7, 29, "Lahm", "FootballPlayer/7.jpg", "Lahm", 7, 1 },
                    { 6, 26, "Alaba", "FootballPlayer/6.jpg", "Alaba", 6, 1 },
                    { 5, 31, "Rilbery", "FootballPlayer/5.jpg", "Rilbery", 5, 1 },
                    { 4, 28, "Schweinsteiger", "FootballPlayer/4.jpg", "Schweinsteiger", 1, 1 },
                    { 3, 32, "Martinez", "FootballPlayer/3.jpg", "Martinez", 3, 1 },
                    { 2, 27, "Pizarro", "FootballPlayer/2.jpg", "Pizarro", 2, 1 },
                    { 19, 29, "Ramos", "FootballPlayer/19.jpg", "Ramos", 7, 2 },
                    { 20, 33, "Casillas", "FootballPlayer/20.jpg", "Casillas", 8, 2 }
                });

            migrationBuilder.InsertData(
                table: "FootballCarts",
                columns: new[] { "Id", "CartId", "FootballPlayerId", "GameTimeId" },
                values: new object[,]
                {
                    { 1, 1, 1, 1 },
                    { 2, 1, 3, 1 },
                    { 3, 1, 5, 1 },
                    { 4, 1, 7, 1 }
                });

            migrationBuilder.InsertData(
                table: "FootballPlayerGameTimes",
                columns: new[] { "Id", "FootballPlayerId", "FootballerPositionId", "GameTimeId" },
                values: new object[,]
                {
                    { 18, 18, 8, 1 },
                    { 17, 17, 7, 1 },
                    { 16, 16, 6, 1 },
                    { 15, 15, 5, 1 },
                    { 14, 14, 4, 1 },
                    { 13, 13, 3, 1 },
                    { 12, 12, 2, 1 },
                    { 11, 11, 1, 1 },
                    { 10, 10, 10, 1 },
                    { 8, 8, 8, 1 },
                    { 19, 19, 9, 1 },
                    { 7, 7, 7, 1 },
                    { 6, 6, 6, 1 },
                    { 5, 5, 5, 1 },
                    { 4, 4, 4, 1 },
                    { 3, 3, 3, 1 },
                    { 2, 2, 2, 1 },
                    { 1, 1, 1, 1 },
                    { 9, 9, 9, 1 },
                    { 20, 20, 10, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCarts_CartId",
                table: "FootballCarts",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCarts_FootballPlayerId",
                table: "FootballCarts",
                column: "FootballPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballCarts_GameTimeId",
                table: "FootballCarts",
                column: "GameTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerGameTimes_FootballPlayerId",
                table: "FootballPlayerGameTimes",
                column: "FootballPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerGameTimes_FootballerPositionId",
                table: "FootballPlayerGameTimes",
                column: "FootballerPositionId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayerGameTimes_GameTimeId",
                table: "FootballPlayerGameTimes",
                column: "GameTimeId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayers_PositionId",
                table: "FootballPlayers",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_FootballPlayers_TeamId",
                table: "FootballPlayers",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_GameTimes_StadiumId",
                table: "GameTimes",
                column: "StadiumId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_CountryId",
                table: "Teams",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_FootballPlayerId",
                table: "Transfers",
                column: "FootballPlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Transfers_TeamId",
                table: "Transfers",
                column: "TeamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "FootballCarts");

            migrationBuilder.DropTable(
                name: "FootballPlayerGameTimes");

            migrationBuilder.DropTable(
                name: "PositionTypes");

            migrationBuilder.DropTable(
                name: "Transfers");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "FootballerPositions");

            migrationBuilder.DropTable(
                name: "GameTimes");

            migrationBuilder.DropTable(
                name: "FootballPlayers");

            migrationBuilder.DropTable(
                name: "Stadiums");

            migrationBuilder.DropTable(
                name: "Positions");

            migrationBuilder.DropTable(
                name: "Teams");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
