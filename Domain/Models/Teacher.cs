using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Domain.Models;
[Table("teacher")]
public class Teacher
{
    [Column("teacher_id")]
    [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("teacher_id")]
    public int TeacherId { get; set; }
    [Column("teacher_firstname")]
    [JsonPropertyName("teacher_firstname")]
    public required string TeacherFirstName { get; set; }
    [Column("tacher_lastname")]
    [JsonPropertyName("teacher_lastname")]
    public required string TeacherLastName { get; set; }
    [Column("teacher_birthdate")]
    [JsonPropertyName("teacher_birthdate")]
    public DateTime BirthDate { get; set; }
    [Column("teacher_gender")]
    [JsonPropertyName("teacher_gender")]
    public bool Gender { get; set; } = true;

}
