using BigData.JsonToCsharp;
using DataStorage;
using DataStorage.Entities;
using System.Net.Http.Json;

string tenMinData = "https://dmigw.govcloud.dk/v2/metObs/collections/observation/items?period=latest-10-minutes&api-key=da77e62c-9536-4bb9-a04a-9f1ad7e109f3";
HttpClient client = new HttpClient();
string json = await client.GetStringAsync(tenMinData);
Root test = await client.GetFromJsonAsync<Root>(tenMinData);
RootEntity RE = new RootEntity()
{
    NumberReturned = test.numberReturned,
    TimeStamp = test.timeStamp,
    Type = test.type,
    Links = test.links.Select(l => new LinkEntity() 
    { 
        Href = l.href, 
        Rel = l.rel, 
        Title = l.title, 
        Type = l.type 
    }).ToList(),
    Features = test.features.Select(f => new FeatureEntity()
    {
        FeatureNumber = f.id,
        Type = f.type,
        Geometry = new GeometryEntity()
        {
            Type = f.geometry.type,
            Coordinates = f.geometry.coordinates.Select(c => new CoordinateEntity()
            {
                Value = c
            }).ToList()
        },
        Properties = new PropertiesEntity()
        {
            Created = f.properties.created,
            Observed = f.properties.observed,
            ParameterNumber = f.properties.parameterId,
            StationNumber = f.properties.stationId,
            Value = f.properties.value
        }
    }).ToList()
};
Context context = new Context();
context.Add(RE);
context.SaveChanges();
Console.WriteLine(json);