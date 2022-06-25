namespace Services;

public class Repository
{
    public static Write<Services.Feature> Feature
    {
        get
        {
            return new Write<Services.Feature>(new ServicesContext());
        }
    }

    public static Write<Services.PackageFeature> PackageFeature
    {
        get
        {
            return new Write<Services.PackageFeature>(new ServicesContext());
        }
    }

    public static Write<Services.PackageFeatureView> PackageFeatureView
    {
        get
        {
            return new Write<Services.PackageFeatureView>(new ServicesContext());
        }
    }

    public static Write<Services.Package> Package
    {
        get
        {
            return new Write<Services.Package>(new ServicesContext());
        }
    }
}
