using System.ComponentModel.DataAnnotations.Schema;

namespace DataStorage.Entities;

[NotMapped]
public class PropertiesEntity
{
    public int PropertiesId { get; set; }
    public string ParameterNumber { get; set; }
    public DateTime Created { get; set; }
    public DateTime Observed { get; set; }
    public string StationNumber { get; set; }
    public double Value { get; set; }


    public FeatureEntity Feature { get; set; }
}
