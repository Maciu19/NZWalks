using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalksAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedingDataForDifficultiesandRegions : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("6ac9da36-95e8-4bac-860a-87f1eaa6edb3"), "Medium" },
                    { new Guid("9e5f67ec-4619-4ba9-b445-d87fd17ed8d8"), "Hard" },
                    { new Guid("e2dcb513-7247-4d75-b7db-03aade5ff1ef"), "Easy" }
                });

            migrationBuilder.InsertData(
                table: "Regions",
                columns: new[] { "Id", "Code", "Name", "RegionImageUrl" },
                values: new object[,]
                {
                    { new Guid("0bb7df90-bf33-49ba-8c0f-64c382aaf43a"), "STL", "Southland", null },
                    { new Guid("27a6d24f-371e-4af4-a2f7-ab74d297b7f9"), "AKL", "Auckland", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.britannica.com%2Fplace%2FAuckland-New-Zealand&psig=AOvVaw2hpeRBm_qe0iCUd2BG8wRe&ust=1690877606356000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCJjly4rAuIADFQAAAAAdAAAAABAE" },
                    { new Guid("2c9c5ca2-9b91-4e9f-b41d-ddf7da3f20fc"), "BOP", "Bay Of Plenty", null },
                    { new Guid("349b6d85-64be-4a73-ba9f-55c91cb471cf"), "WGN", "Wellington", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.britannica.com%2Fplace%2FWellington-New-Zealand&psig=AOvVaw11t71unddmgm6Gb9G_g-A1&ust=1690877729327000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOjlnMXAuIADFQAAAAAdAAAAABAE" },
                    { new Guid("c6c60f8f-a36a-4cac-b974-5d5d3e0b996f"), "MSN", "Nelson", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikipedia.org%2Fwiki%2FNelson%2C_New_Zealand&psig=AOvVaw3pcHu97yy98Fr_k1DNtsmZ&ust=1690877770505000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCOC-4NjAuIADFQAAAAAdAAAAABAE" },
                    { new Guid("f700ede5-f310-4bdd-8be6-911b81231e87"), "NTL", "Northland", "https://www.google.com/url?sa=i&url=https%3A%2F%2Fwww.live-work.immigration.govt.nz%2Fchoose-new-zealand%2Fregions-cities%2Fnorthland&psig=AOvVaw2RORpAHaf0KRscqiTYkxKS&ust=1690877642707000&source=images&cd=vfe&opi=89978449&ved=0CBEQjRxqFwoTCLDY7ZvAuIADFQAAAAAdAAAAABAE" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("6ac9da36-95e8-4bac-860a-87f1eaa6edb3"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("9e5f67ec-4619-4ba9-b445-d87fd17ed8d8"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("e2dcb513-7247-4d75-b7db-03aade5ff1ef"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("0bb7df90-bf33-49ba-8c0f-64c382aaf43a"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("27a6d24f-371e-4af4-a2f7-ab74d297b7f9"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("2c9c5ca2-9b91-4e9f-b41d-ddf7da3f20fc"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("349b6d85-64be-4a73-ba9f-55c91cb471cf"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("c6c60f8f-a36a-4cac-b974-5d5d3e0b996f"));

            migrationBuilder.DeleteData(
                table: "Regions",
                keyColumn: "Id",
                keyValue: new Guid("f700ede5-f310-4bdd-8be6-911b81231e87"));
        }
    }
}
