using Microsoft.EntityFrameworkCore;
using Volo.Abp.AuditLogging.EntityFrameworkCore;
using Volo.Abp.BackgroundJobs.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.FeatureManagement.EntityFrameworkCore;
using Volo.Abp.Identity;
using Volo.Abp.Identity.EntityFrameworkCore;
using Volo.Abp.OpenIddict.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;
using Volo.Abp.SettingManagement.EntityFrameworkCore;
using Volo.Abp.TenantManagement;
using Volo.Abp.TenantManagement.EntityFrameworkCore;
using VumbaSoft.AdventureWorksAbp.Demographics.Continents;
using Volo.Abp.EntityFrameworkCore.Modeling;
using VumbaSoft.AdventureWorksAbp.Demographics.Subcontinents;
using VumbaSoft.AdventureWorksAbp.Demographics.Countries;
using VumbaSoft.AdventureWorksAbp.Demographics.Regions;
using VumbaSoft.AdventureWorksAbp.Demographics.StateProvinces;
using VumbaSoft.AdventureWorksAbp.Demographics.DistrictCities;
using VumbaSoft.AdventureWorksAbp.Demographics.Localities;
using VumbaSoft.AdventureWorksAbp.EntitiesConfigBuilderExtentions;

namespace VumbaSoft.AdventureWorksAbp.EntityFrameworkCore;

[ReplaceDbContext(typeof(IIdentityDbContext))]
[ReplaceDbContext(typeof(ITenantManagementDbContext))]
[ConnectionStringName("Default")]
public class AdventureWorksAbpDbContext :
    AbpDbContext<AdventureWorksAbpDbContext>,
    IIdentityDbContext,
    ITenantManagementDbContext
{
    /* Add DbSet properties for your Aggregate Roots / Entities here. */

    #region Entities from the modules

    /* Notice: We only implemented IIdentityDbContext and ITenantManagementDbContext
     * and replaced them for this DbContext. This allows you to perform JOIN
     * queries for the entities of these modules over the repositories easily. You
     * typically don't need that for other modules. But, if you need, you can
     * implement the DbContext interface of the needed module and use ReplaceDbContext
     * attribute just like IIdentityDbContext and ITenantManagementDbContext.
     *
     * More info: Replacing a DbContext of a module ensures that the related module
     * uses this DbContext on runtime. Otherwise, it will use its own DbContext class.
     */

    //Identity
    public DbSet<IdentityUser> Users { get; set; }
    public DbSet<IdentityRole> Roles { get; set; }
    public DbSet<IdentityClaimType> ClaimTypes { get; set; }
    public DbSet<OrganizationUnit> OrganizationUnits { get; set; }
    public DbSet<IdentitySecurityLog> SecurityLogs { get; set; }
    public DbSet<IdentityLinkUser> LinkUsers { get; set; }
    public DbSet<IdentityUserDelegation> UserDelegations { get; set; }

    // Tenant Management
    public DbSet<Tenant> Tenants { get; set; }
    public DbSet<TenantConnectionString> TenantConnectionStrings { get; set; }

    #endregion
    public DbSet<Continent> Continents { get; set; }
    public DbSet<Subcontinent> Subcontinents { get; set; }
    public DbSet<Country> Countries { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<StateProvince> StateProvinces { get; set; }
    public DbSet<DistrictCity> DistrictCities { get; set; }
    public DbSet<Locality> Localities { get; set; }

    public AdventureWorksAbpDbContext(DbContextOptions<AdventureWorksAbpDbContext> options)
        : base(options)
    {

    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        /* Include modules to your migration db context */

        builder.ConfigurePermissionManagement();
        builder.ConfigureSettingManagement();
        builder.ConfigureBackgroundJobs();
        builder.ConfigureAuditLogging();
        builder.ConfigureIdentity();
        builder.ConfigureOpenIddict();
        builder.ConfigureFeatureManagement();
        builder.ConfigureTenantManagement();

        builder.ConfigureDemographics();

        /* Configure your own tables/entities inside here */

        //builder.Entity<YourEntity>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "YourEntities", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); //auto configure for the base class props
        //    //...
        //});


        //builder.Entity<Continent>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Continents", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});


        //builder.Entity<Subcontinent>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Subcontinents", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});


        //builder.Entity<Country>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Countries", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});


        //builder.Entity<Region>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Regions", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});


        //builder.Entity<StateProvince>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "StateProvinces", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});


        //builder.Entity<DistrictCity>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "DistrictCities", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});


        //builder.Entity<Locality>(b =>
        //{
        //    b.ToTable(AdventureWorksAbpConsts.DbTablePrefix + "Localities", AdventureWorksAbpConsts.DbSchema);
        //    b.ConfigureByConvention(); 
            

        //    /* Configure more properties here */
        //});
    }
}
