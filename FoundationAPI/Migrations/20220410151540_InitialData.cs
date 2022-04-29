using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FoundationAPI.Migrations
{
    public partial class InitialData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "CharacterId", "Name" },
                values: new object[,]
                {
                    { new Guid("09ae2f6c-7c43-4a91-b6ab-75dfb68d7ab0"), "Konom" },
                    { new Guid("2078939d-b339-482f-9b80-958466b4c94f"), "Daribow" },
                    { new Guid("45f87d18-afb5-47c5-a2a3-166cdff67c5d"), "Anacreon" },
                    { new Guid("88521e15-f778-4b17-b155-2386e30b1971"), "Trantor" },
                    { new Guid("9d56a7df-b544-4081-9139-94aa4816563b"), "Smyrno" },
                    { new Guid("9fea1bd8-f221-4856-8b0b-a8945afd352f"), "Synnax" },
                    { new Guid("a62e90a9-f3a9-4e5a-aceb-fa342aa18a3c"), "Askone" },
                    { new Guid("a8576e1b-d866-40a5-9820-45d31383748a"), "Terminus" },
                    { new Guid("cd56c939-c820-4140-903c-2e3ec1025e8f"), "Siwenna" },
                    { new Guid("fbd5937c-8641-440c-a3d1-d85230a4f1c8"), "Korell" }
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("09ae2f6c-7c43-4a91-b6ab-75dfb68d7ab0"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("2078939d-b339-482f-9b80-958466b4c94f"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("9d56a7df-b544-4081-9139-94aa4816563b"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("a62e90a9-f3a9-4e5a-aceb-fa342aa18a3c"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("a8576e1b-d866-40a5-9820-45d31383748a"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("cd56c939-c820-4140-903c-2e3ec1025e8f"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("fbd5937c-8641-440c-a3d1-d85230a4f1c8"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("45f87d18-afb5-47c5-a2a3-166cdff67c5d"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("88521e15-f778-4b17-b155-2386e30b1971"));

            migrationBuilder.DeleteData(
                table: "Planets",
                keyColumn: "CharacterId",
                keyValue: new Guid("9fea1bd8-f221-4856-8b0b-a8945afd352f"));
        }
    }
}
