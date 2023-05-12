using System.ComponentModel.DataAnnotations.Schema;

namespace DataStorage.Entities;

[NotMapped]
public class GeometryEntity
{
    public int GeometryId { get; set; }
    public string Type { get; set; }
    public List<CoordinateEntity> Coordinates { get; set; }
    public List<FeatureEntity> Features { get; set; }
}
