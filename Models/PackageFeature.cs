namespace Services;

public class PackageFeature : IEntity
{
    public PackageFeature()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long PackageId { get; set; }

    public long FeatureId { get; set; }

    public dynamic RelatedItems { get; set; }
}
