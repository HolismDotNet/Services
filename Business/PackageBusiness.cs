using Holism.Services.DataAccess;

namespace Holism.Services.Business;

public class PackageBusiness : Business<Package, Package>
{
    protected override ReadRepository<Package> ReadRepository => Repository.Package;

    protected override Repository<Package> WriteRepository => Repository.Package;
}