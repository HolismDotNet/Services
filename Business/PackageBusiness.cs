namespace Services;

public class PackageBusiness : Business<Package, Package>
{
    protected override Read<Package> Read => Repository.Package;

    protected override Write<Package> Write => Repository.Package;
}