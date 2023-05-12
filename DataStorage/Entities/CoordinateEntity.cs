using System.ComponentModel.DataAnnotations.Schema;

namespace DataStorage.Entities;

[NotMapped]
public class CoordinateEntity
{
    public int CoordinateId { get; set; }
    public double Value { get; set; }

    public int FK_GemoetryId { get; set; }
    public GeometryEntity Geometry { get; set; }    
}
