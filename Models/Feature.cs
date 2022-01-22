namespace Holism.Services.Models;

public class Feature : IEntity
{
    public Feature()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Title { get; set; }

    public dynamic RelatedItems { get; set; }
}
