namespace Services;

public class ServicesContext : DatabaseContext
{
    public override string ConnectionStringName => "Services";

    public DbSet<Feature> Features { get; set; }

    public DbSet<PackageFeature> PackageFeatures { get; set; }

    public DbSet<PackageFeatureView> PackageFeatureViews { get; set; }

    public DbSet<Package> Packages { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
    }
}
