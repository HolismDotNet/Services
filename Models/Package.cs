namespace Holism.Services.Models;

public class Package : IEntity
{
    public Package()
    {
        RelatedItems = new ExpandoObject();
    }

    public long Id { get; set; }

    public string Title { get; set; }

    public string Subtitle { get; set; }

    public dynamic RelatedItems { get; set; }
}
