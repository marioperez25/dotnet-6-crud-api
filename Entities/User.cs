namespace WebApi.Entities;
using System.ComponentModel.DataAnnotations.Schema;

using System.Text.Json.Serialization;

public class User
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    [ForeignKey("Address")]
    public int AddressId { get; set; }
    public Role Role { get; set; }

    [JsonIgnore]
    public string PasswordHash { get; set; }
}