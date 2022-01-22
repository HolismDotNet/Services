namespace Services;

public class PackageBusiness : Business<Package, Package>
{
    protected override ReadRepository<Package> ReadRepository => Repository.Package;

    protected override Repository<Package> WriteRepository => Repository.Package;
}