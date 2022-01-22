namespace Holism.Services.Models;

public class PackageFeatureView : IEntity
{
    public PackageFeatureView()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public long PackageId { get; set; }

    public long FeatureId { get; set; }

    public dynamic RelatedItems { get; set; }
}
