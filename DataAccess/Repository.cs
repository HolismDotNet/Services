namespace Services;

public class Repository
{
    public static Repository<Services.Feature> Feature
    {
        get
        {
            return new Repository<Services.Feature>(new ServicesContext());
        }
    }

    public static Repository<Services.PackageFeature> PackageFeature
    {
        get
        {
            return new Repository<Services.PackageFeature>(new ServicesContext());
        }
    }

    public static Repository<Services.PackageFeatureView> PackageFeatureView
    {
        get
        {
            return new Repository<Services.PackageFeatureView>(new ServicesContext());
        }
    }

    public static Repository<Services.Package> Package
    {
        get
        {
            return new Repository<Services.Package>(new ServicesContext());
        }
    }
}
