using System.ComponentModel.DataAnnotations.Schema;

namespace DataStorage.Entities;
[NotMapped]
public class RootEntity
{
    public int RootId { get; set; }
    public string Type { get; set; }
    public List<FeatureEntity> Features { get; set; }
    public DateTime TimeStamp { get; set; }
    public int NumberReturned { get; set; }
    public List<LinkEntity> Links { get; set; }
}
