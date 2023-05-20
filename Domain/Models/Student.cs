using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Domain.Models;
[Table("Student")]
public class Student
{
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Column("student_id")]
    [JsonPropertyName("student_id")]
    public int StudentId { get; set; }
    [Column("first_name")]
    [JsonPropertyName("first_name")]
    [StringLength(50)]
    public required string FirstName { get; set; }
    [Column("last_name")]
    [JsonPropertyName("last_name")]
    [StringLength(50)]
    public required string LastName { get; set; }
    [Column("birth_date")]
    [JsonPropertyName("birth_date")]
    public DateTime BirthDate { get; set; }
    [Column("gender")]
    [JsonPropertyName("gender")]
    public bool Gender { get; set; } = true;
}
