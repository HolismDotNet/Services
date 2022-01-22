namespace Holism.Services.DataAccess;

public class Repository
{
    public static Repository<Feature> Feature
    {
        get
        {
            return new Repository<Feature>(new ServicesContext());
        }
    }

    public static Repository<PackageFeature> PackageFeature
    {
        get
        {
            return new Repository<PackageFeature>(new ServicesContext());
        }
    }

    public static Repository<PackageFeatureView> PackageFeatureView
    {
        get
        {
            return new Repository<PackageFeatureView>(new ServicesContext());
        }
    }    public static Repository<Package> Package
    {
        get
        {
            return new Repository<Package>(new ServicesContext());
        }
    }


}
