using System.ComponentModel.DataAnnotations.Schema;

namespace DataStorage.Entities;

[NotMapped]
public class LinkEntity
{
    public int LinkId { get; set; }
    public string Href { get; set; }
    public string Rel { get; set; }
    public string Type { get; set; }
    public string Title { get; set; }

    public int FK_RootId { get; set; }
    public RootEntity Root { get; set; }
}
