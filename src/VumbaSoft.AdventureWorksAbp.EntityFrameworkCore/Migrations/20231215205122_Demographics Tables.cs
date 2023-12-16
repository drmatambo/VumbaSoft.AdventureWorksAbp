using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace VumbaSoft.AdventureWorksAbp.Migrations
{
    /// <inheritdoc />
    public partial class DemographicsTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Demographics");

            migrationBuilder.CreateTable(
                name: "AppContinents",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppContinents", x => x.Id);
                },
                comment: "Continent  DataTable");

            migrationBuilder.CreateTable(
                name: "AppCountries",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContinentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcontinentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    FormalName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    NativeName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsoTreeCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    IsoTwoCode = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: false),
                    CcnTreeCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    PhoneCode = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Capital = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Currency = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Emoji = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    EmojiU = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppCountries", x => x.Id);
                },
                comment: "Countries  DataTable");

            migrationBuilder.CreateTable(
                name: "AppDistrictCities",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    StateProvinceCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal (12,9)", nullable: false, defaultValue: 0m),
                    Longitude = table.Column<decimal>(type: "decimal(12,9)", nullable: false, defaultValue: 0m),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppDistrictCities", x => x.Id);
                },
                comment: "DistrictCities  DataTable");

            migrationBuilder.CreateTable(
                name: "AppLocalities",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContinentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SubcontinentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StateProvinceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DistrictCityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    DistrictCityCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    LocalityCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(12,9)", nullable: false, defaultValue: 0m),
                    Longitude = table.Column<decimal>(type: "decimal(12,9)", nullable: false, defaultValue: 0m),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppLocalities", x => x.Id);
                },
                comment: "Localities DataTable");

            migrationBuilder.CreateTable(
                name: "AppRegions",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    RegionCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRegions", x => x.Id);
                },
                comment: "Regions  DataTable");

            migrationBuilder.CreateTable(
                name: "AppStateProvinces",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    RegionCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    StateProvinceCode = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppStateProvinces", x => x.Id);
                },
                comment: "StateProvince  DataTable");

            migrationBuilder.CreateTable(
                name: "AppSubcontinents",
                schema: "Demographics",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    ContinentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Population = table.Column<long>(type: "bigint", nullable: false, defaultValue: 0L),
                    Remarks = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    ExtraProperties = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(40)", maxLength: 40, nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatorId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifierId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DeleterId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeletionTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppSubcontinents", x => x.Id);
                },
                comment: "Subcontinents  DataTable");

            migrationBuilder.CreateIndex(
                name: "AK_Continent_Name",
                schema: "Demographics",
                table: "AppContinents",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Continent_Subcontinente_CountryName",
                schema: "Demographics",
                table: "AppCountries",
                columns: new[] { "ContinentID", "SubcontinentId", "Name" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Districtcity_Name",
                schema: "Demographics",
                table: "AppDistrictCities",
                columns: new[] { "Name", "CountryId", "StateProvinceId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Locality_Name",
                schema: "Demographics",
                table: "AppLocalities",
                columns: new[] { "Name", "StateProvinceId", "DistrictCityId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Region_Name",
                schema: "Demographics",
                table: "AppRegions",
                columns: new[] { "Name", "CountryId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Stateprovince_Name",
                schema: "Demographics",
                table: "AppStateProvinces",
                columns: new[] { "Name", "CountryId", "RegionId" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "AK_Continent_SubcontinentName",
                schema: "Demographics",
                table: "AppSubcontinents",
                columns: new[] { "ContinentId", "Name" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppContinents",
                schema: "Demographics");

            migrationBuilder.DropTable(
                name: "AppCountries",
                schema: "Demographics");

            migrationBuilder.DropTable(
                name: "AppDistrictCities",
                schema: "Demographics");

            migrationBuilder.DropTable(
                name: "AppLocalities",
                schema: "Demographics");

            migrationBuilder.DropTable(
                name: "AppRegions",
                schema: "Demographics");

            migrationBuilder.DropTable(
                name: "AppStateProvinces",
                schema: "Demographics");

            migrationBuilder.DropTable(
                name: "AppSubcontinents",
                schema: "Demographics");
        }
    }
}
