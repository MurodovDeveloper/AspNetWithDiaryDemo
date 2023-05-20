using Domain.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Domain.Models;
[Table("Grade")]
public class Grade
{
    [Column("grade_id")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("grade_id")]
    public int GradeID { get; set; }
    [Column("grade_enum")]
    [JsonPropertyName("grade_enum")]
    public GradeEnum GradeEnum { get; set; }
    [JsonIgnore]
    [NotMapped]
    public required StudentTeacher StudentTeacher { get; set; }
    [Column("Date")]
    [JsonPropertyName("Date")]
    public DateTime Date { get; set; }
}
