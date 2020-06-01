using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSimpleGame.DL.Implementation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SkinEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<long>(nullable: false),
                    ModelPath = table.Column<string>(nullable: false),
                    Character = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "WeaponEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Distance = table.Column<float>(nullable: false),
                    Damage = table.Column<float>(nullable: false),
                    Price = table.Column<long>(nullable: false),
                    ModelPath = table.Column<string>(nullable: false),
                    Character = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PlayerEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Money = table.Column<long>(nullable: false),
                    CurrentSkinId = table.Column<int>(nullable: false),
                    CurrentWeaponId = table.Column<int>(nullable: false),
                    SkinId = table.Column<int>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    Character = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerEntity_SkinEntity_CurrentSkinId",
                        column: x => x.CurrentSkinId,
                        principalTable: "SkinEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntity_WeaponEntity_CurrentWeaponId",
                        column: x => x.CurrentWeaponId,
                        principalTable: "WeaponEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "SkinEntity",
                columns: new[] { "Id", "Character", "ModelPath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, "models/skins/skin1.3ds", "Стандартний вигляд", 0L },
                    { 2, 1, "models/skins/skin2.3ds", "Стандартний вигляд", 0L },
                    { 3, 4, "models/skins/skin3.3ds", "Стандартний вигляд", 0L },
                    { 4, 3, "models/skins/skin4.3ds", "Стандартний вигляд", 0L },
                    { 5, 3, "models/skins/skin5.3ds", "Маг з плащем", 100L },
                    { 6, 3, "models/skins/skin6.3ds", "Маг в костюмі", 300L }
                });

            migrationBuilder.InsertData(
                table: "WeaponEntity",
                columns: new[] { "Id", "Character", "Damage", "Distance", "ModelPath", "Name", "Price" },
                values: new object[,]
                {
                    { 1, 2, 90f, 200f, "models/weapons/skin1.3ds", "Стандартний молот", 0L },
                    { 2, 1, 70f, 300f, "models/weapons/skin2.3ds", "Стандартний лук", 0L },
                    { 3, 4, 120f, 100f, "models/weapons/skin3.3ds", "Стандартний меч", 0L },
                    { 4, 3, 180f, 50f, "models/weapons/skin4.3ds", "Стандартний посох", 0L },
                    { 5, 3, 220f, 50f, "models/weapons/skin5.3ds", "Золотий посох", 300L }
                });

            migrationBuilder.InsertData(
                table: "PlayerEntity",
                columns: new[] { "Id", "Character", "CurrentSkinId", "CurrentWeaponId", "Money", "SkinId", "WeaponId" },
                values: new object[] { 1, 1, 2, 2, 500L, 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_CurrentSkinId",
                table: "PlayerEntity",
                column: "CurrentSkinId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_CurrentWeaponId",
                table: "PlayerEntity",
                column: "CurrentWeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerEntity");

            migrationBuilder.DropTable(
                name: "SkinEntity");

            migrationBuilder.DropTable(
                name: "WeaponEntity");
        }
    }
}
