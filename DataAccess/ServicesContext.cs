namespace Services;

public class ServicesContext : DatabaseContext
{
    public override string ConnectionStringName => "Services";

    public DbSet<Services.Feature> Features { get; set; }

    public DbSet<Services.PackageFeature> PackageFeatures { get; set; }

    public DbSet<Services.PackageFeatureView> PackageFeatureViews { get; set; }

    public DbSet<Services.Package> Packages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
