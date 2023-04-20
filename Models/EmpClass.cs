using System.Text.Json.Serialization;

namespace WebAPI.Models
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EmpClass
    {
        Day,
        Night
    }
}