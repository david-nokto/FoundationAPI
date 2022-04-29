using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundationAPI.Migrations
{
    public partial class CorrectedColumnInPlanets : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("48d58768-4efc-4c95-ab9e-1de7e4e90480"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("b17564c6-82cb-4e0a-9f64-3519e3a5a982"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("e3dda918-634e-449f-a22f-fd910a6cff83"));

            migrationBuilder.RenameColumn(
                name: "CharacterId",
                table: "Planets",
                newName: "PlanetId");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "PlanetId" },
                values: new object[] { new Guid("4f0fc21b-b88b-4f7d-a49e-bf662ec99500"), "Gaal Dornick", new Guid("9fea1bd8-f221-4856-8b0b-a8945afd352f") });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "PlanetId" },
                values: new object[] { new Guid("62c94733-e9a6-4789-867f-1cb3f38ddeca"), "Anselm Haut Rodric", new Guid("45f87d18-afb5-47c5-a2a3-166cdff67c5d") });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "PlanetId" },
                values: new object[] { new Guid("dc315eaa-bfa2-4c07-a7e6-b3685b50fb3d"), "Hari Seldon", new Guid("88521e15-f778-4b17-b155-2386e30b1971") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("4f0fc21b-b88b-4f7d-a49e-bf662ec99500"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("62c94733-e9a6-4789-867f-1cb3f38ddeca"));

            migrationBuilder.DeleteData(
                table: "Characters",
                keyColumn: "CharacterId",
                keyValue: new Guid("dc315eaa-bfa2-4c07-a7e6-b3685b50fb3d"));

            migrationBuilder.RenameColumn(
                name: "PlanetId",
                table: "Planets",
                newName: "CharacterId");

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "PlanetId" },
                values: new object[] { new Guid("48d58768-4efc-4c95-ab9e-1de7e4e90480"), "Anselm Haut Rodric", new Guid("45f87d18-afb5-47c5-a2a3-166cdff67c5d") });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "PlanetId" },
                values: new object[] { new Guid("b17564c6-82cb-4e0a-9f64-3519e3a5a982"), "Hari Seldon", new Guid("88521e15-f778-4b17-b155-2386e30b1971") });

            migrationBuilder.InsertData(
                table: "Characters",
                columns: new[] { "CharacterId", "Name", "PlanetId" },
                values: new object[] { new Guid("e3dda918-634e-449f-a22f-fd910a6cff83"), "Gaal Dornick", new Guid("9fea1bd8-f221-4856-8b0b-a8945afd352f") });
        }
    }
}
