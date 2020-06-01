using Microsoft.EntityFrameworkCore.Migrations;

namespace NotSimpleGame.DL.Implementation.Migrations
{
    public partial class PlayerForeignKeyNamesUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerEntity_SkinEntity_CurrentSkinId",
                table: "PlayerEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerEntity_WeaponEntity_CurrentWeaponId",
                table: "PlayerEntity");

            migrationBuilder.DropIndex(
                name: "IX_PlayerEntity_CurrentSkinId",
                table: "PlayerEntity");

            migrationBuilder.DropIndex(
                name: "IX_PlayerEntity_CurrentWeaponId",
                table: "PlayerEntity");

            migrationBuilder.DropColumn(
                name: "CurrentSkinId",
                table: "PlayerEntity");

            migrationBuilder.DropColumn(
                name: "CurrentWeaponId",
                table: "PlayerEntity");

            migrationBuilder.UpdateData(
                table: "PlayerEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "SkinId", "WeaponId" },
                values: new object[] { 2, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_SkinId",
                table: "PlayerEntity",
                column: "SkinId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_WeaponId",
                table: "PlayerEntity",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerEntity_SkinEntity_SkinId",
                table: "PlayerEntity",
                column: "SkinId",
                principalTable: "SkinEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerEntity_WeaponEntity_WeaponId",
                table: "PlayerEntity",
                column: "WeaponId",
                principalTable: "WeaponEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PlayerEntity_SkinEntity_SkinId",
                table: "PlayerEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_PlayerEntity_WeaponEntity_WeaponId",
                table: "PlayerEntity");

            migrationBuilder.DropIndex(
                name: "IX_PlayerEntity_SkinId",
                table: "PlayerEntity");

            migrationBuilder.DropIndex(
                name: "IX_PlayerEntity_WeaponId",
                table: "PlayerEntity");

            migrationBuilder.AddColumn<int>(
                name: "CurrentSkinId",
                table: "PlayerEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrentWeaponId",
                table: "PlayerEntity",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "PlayerEntity",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CurrentSkinId", "CurrentWeaponId", "SkinId", "WeaponId" },
                values: new object[] { 2, 2, 0, 0 });

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_CurrentSkinId",
                table: "PlayerEntity",
                column: "CurrentSkinId");

            migrationBuilder.CreateIndex(
                name: "IX_PlayerEntity_CurrentWeaponId",
                table: "PlayerEntity",
                column: "CurrentWeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerEntity_SkinEntity_CurrentSkinId",
                table: "PlayerEntity",
                column: "CurrentSkinId",
                principalTable: "SkinEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PlayerEntity_WeaponEntity_CurrentWeaponId",
                table: "PlayerEntity",
                column: "CurrentWeaponId",
                principalTable: "WeaponEntity",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
