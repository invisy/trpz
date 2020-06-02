using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSimpleGame.DL.Implementation.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CharacterEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    MoveSpeed = table.Column<int>(nullable: false),
                    JumpHeight = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SkinEntity",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: false),
                    Price = table.Column<long>(nullable: false),
                    ModelPath = table.Column<string>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false)
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
                    CharacterId = table.Column<int>(nullable: false)
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
                    Health = table.Column<int>(nullable: false),
                    Money = table.Column<long>(nullable: false),
                    CharacterId = table.Column<int>(nullable: false),
                    WeaponId = table.Column<int>(nullable: false),
                    SkinId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlayerEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PlayerEntity_CharacterEntity_CharacterId",
                        column: x => x.CharacterId,
                        principalTable: "CharacterEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntity_SkinEntity_SkinId",
                        column: x => x.SkinId,
                        principalTable: "SkinEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlayerEntity_WeaponEntity_WeaponId",
                        column: x => x.WeaponId,
                        principalTable: "WeaponEntity",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "CharacterEntity",
                columns: new[] { "Id", "JumpHeight", "MoveSpeed", "Name" },
                values: new object[,]
                {
                    { 1, 100, 100, "Ельф" },
                    { 2, 120, 80, "Гном" },
                    { 3, 80, 120, "Маг" },
                    { 4, 150, 60, "Воїн" }
                });

            migrationBuilder.InsertData(
                table: "SkinEntity",
                columns: new[] { "Id", "CharacterId", "ModelPath", "Name", "Price" },
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
                columns: new[] { "Id", "CharacterId", "Damage", "Distance", "ModelPath", "Name", "Price" },
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
                columns: new[] { "Id", "CharacterId", "Health", "Money", "SkinId", "WeaponId" },
                values: new object[] { 1, 2, 0, 500L, 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_CharacterId",
                table: "PlayerEntity",
                column: "CharacterId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_SkinId",
                table: "PlayerEntity",
                column: "SkinId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_WeaponId",
                table: "PlayerEntity",
                column: "WeaponId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlayerEntity");

            migrationBuilder.DropTable(
                name: "CharacterEntity");

            migrationBuilder.DropTable(
                name: "SkinEntity");

            migrationBuilder.DropTable(
                name: "WeaponEntity");
        }
    }
}
