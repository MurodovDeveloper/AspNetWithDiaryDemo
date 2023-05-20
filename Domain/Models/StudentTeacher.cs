using System.ComponentModel.DataAnnotations.Schema;
namespace Domain.Models;
[Table("student_teacher")]
public class StudentTeacher
{
    [ForeignKey("student_teacher_id")]
    public int Id { get; set; }
    public Student Student { get; set; }
    public Teacher Teacher { get; set; }
    public Subject Subject { get; set; }

}
