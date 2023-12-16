using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using Volo.Abp;
using Volo.Abp.EntityFrameworkCore.Modeling;
using VumbaSoft.AdventureWorksAbp.Demographics.Continents;
using VumbaSoft.AdventureWorksAbp.Demographics.Countries;
using VumbaSoft.AdventureWorksAbp.Demographics.DistrictCities;
using VumbaSoft.AdventureWorksAbp.Demographics.Localities;
using VumbaSoft.AdventureWorksAbp.Demographics.Regions;
using VumbaSoft.AdventureWorksAbp.Demographics.StateProvinces;
using VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents;

namespace VumbaSoft.AdventureWorksAbp.EntitiesConfigBuilderExtentions
{
    public static class DemographicsDbContextModelBuilderExtensions
    {
        public static void ConfigureDemographics([NotNull] this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            builder.Entity<Continent>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Continents", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("Continent  DataTable")
                );

                b.ConfigureByConvention();

                b.HasIndex(x => x.Name, "AK_Continent_Name").IsUnique();
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                //b.HasMany(x => x.Subcontinents).WithOne().HasForeignKey(x => x.ContinentId).IsRequired().OnDelete(DeleteBehavior.NoAction);
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });

            builder.Entity<Subcontinent>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Subcontinents", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("Subcontinents  DataTable")
                );

                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasIndex(x => new {x.ContinentId, x.Name }, "AK_Continent_SubcontinentName" ).IsUnique();
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.ContinentId);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                //b.HasMany(x => x.Countries).WithOne().HasForeignKey(x => x.SubcontinentId).IsRequired().OnDelete(DeleteBehavior.NoAction);
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });

            builder.Entity<Country>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Countries", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("Countries  DataTable")
                );

                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasIndex(x => new {x.ContinentID, x.SubcontinentId, x.Name }, "AK_Continent_Subcontinente_CountryName").IsUnique();
                b.Property(x => x.ContinentID);
                b.Property(x => x.SubcontinentId);
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.FormalName).HasMaxLength(AdventureWorksAbpConsts.StringDefaultMaxLength);
                b.Property(x => x.NativeName).HasMaxLength(AdventureWorksAbpConsts.StringDefaultMaxLength);
                b.Property(x => x.IsoTreeCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.IsoTwoCode).HasMaxLength(AdventureWorksAbpConsts.ISO2MaxLength);
                b.Property(x => x.CcnTreeCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.PhoneCode).HasMaxLength(AdventureWorksAbpConsts.PhoneMaxLength);
                b.Property(x => x.Capital).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.Currency).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                b.Property(x => x.Emoji).HasMaxLength(AdventureWorksAbpConsts.EmojiMaxLength);
                b.Property(x => x.EmojiU).HasMaxLength(AdventureWorksAbpConsts.EmojiMaxLength);
                //b.HasMany(x => x.Regions).WithOne().HasForeignKey(x => x.CountryId).IsRequired().OnDelete(DeleteBehavior.NoAction);
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });

            builder.Entity<Region>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Regions", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("Regions  DataTable")
                );

                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasIndex(x => new { x.Name, x.CountryId}, "AK_Region_Name").IsUnique();
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                b.Property(x => x.CountryId);
                b.Property(x => x.CountryCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.RegionCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                //b.HasMany(x => x.StateProvinces).WithOne().HasForeignKey(x => x.RegionId).IsRequired().OnDelete(DeleteBehavior.NoAction);
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });
            builder.Entity<StateProvince>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "StateProvinces", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("StateProvince  DataTable")
                );

                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasIndex(x => new {x.Name, x.CountryId, x.RegionId}, "AK_Stateprovince_Name").IsUnique();
                b.Property(x => x.CountryId);
                b.Property(x => x.RegionId);
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                b.Property(x => x.RegionCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.StateProvinceCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                //b.HasMany(x => x.DistrictCities).WithOne().HasForeignKey(x => x.StateProvinceId).IsRequired().OnDelete(DeleteBehavior.NoAction);
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });

            builder.Entity<DistrictCity>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "DistrictCities", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("DistrictCities  DataTable")
                );

                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasIndex(x => new { x.Name, x.CountryId, x.StateProvinceId }, "AK_Districtcity_Name").IsUnique();
                b.Property(x => x.CountryId);
                b.Property(x => x.StateProvinceId);
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                b.Property(x => x.StateProvinceCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.CountryCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.Latitude).HasColumnType("decimal (12, 9)").HasDefaultValue(((0.000000000)));
                b.Property(x => x.Longitude).HasColumnType("decimal(12, 9)").HasDefaultValue(((0.000000000))); ;
                //b.HasMany(x => x.Localities).WithOne().HasForeignKey(x => x.DistrictCityId).IsRequired().OnDelete(DeleteBehavior.NoAction);
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });

            builder.Entity<Locality>(b =>
            {
                b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Localities", 
                    AdventureWorksAbpConsts.DemographicsDbSchema, 
                    table => table.HasComment("Localities DataTable")
                );

                b.ConfigureByConvention(); //auto configure for the base class props

                b.HasIndex(x => new { x.Name, x.StateProvinceId, x.DistrictCityId}, "AK_Locality_Name").IsUnique();
                b.Property(x => x.ContinentID).IsRequired();
                b.Property(x => x.SubcontinentId).IsRequired();
                b.Property(x => x.CountryId).IsRequired();
                b.Property(x => x.RegionId).IsRequired();
                b.Property(x => x.StateProvinceId).IsRequired();
                b.Property(x => x.DistrictCityId).IsRequired();
                b.Property(x => x.Name).HasMaxLength(AdventureWorksAbpConsts.NameMaxLength);
                b.Property(x => x.Population).HasColumnType("bigint").HasDefaultValue(((0)));
                b.Property(x => x.DistrictCityCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.LocalityCode).HasMaxLength(AdventureWorksAbpConsts.ISO3MaxLength);
                b.Property(x => x.Latitude).HasColumnType("decimal(12, 9)").HasDefaultValue(((0.000000000))); ;
                b.Property(x => x.Longitude).HasColumnType("decimal(12, 9)").HasDefaultValue(((0.000000000))); ;
                b.Property(x => x.Remarks).HasMaxLength(AdventureWorksAbpConsts.NotesMaxLength);
            });
        }
    }
}
