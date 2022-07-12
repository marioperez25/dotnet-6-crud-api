namespace WebApi.Entities;

using System.Text.Json.Serialization;

public class Address
{
    public int Id { get; set; }
    public int Phone { get; set;}
    public string Street { get; set; }
    public string City { get; set; }
    public string Zip { get; set; }
    public string Country { get; set; }
    public Role Role { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; }
}