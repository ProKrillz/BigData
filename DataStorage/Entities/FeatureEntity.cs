using System.ComponentModel.DataAnnotations.Schema;

namespace DataStorage.Entities;

[NotMapped]
public class FeatureEntity
{
    public int FeatureId { get; set; }
    public string FeatureNumber { get; set; }
    public string Type { get; set; }

    public int FK_PropertiesId { get; set; }
    public PropertiesEntity Properties { get; set; }

    public int Fk_GeometryId { get; set; }
    public GeometryEntity Geometry { get; set; }

    public int FK_RootId { get; set; }
    public RootEntity Root { get; set; }
}
