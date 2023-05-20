using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Domain.Models;
[Table("subject")]
public class Subject
{
    [Column("subject_id")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("subject_id")]
    public int subjcetId { get; set; }
    [Column("subject_name")]
    [JsonPropertyName("subject_name")]
    public string subjectName { get; set; }
}
