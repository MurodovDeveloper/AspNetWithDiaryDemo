using Domain.Permissions;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
namespace Domain.Roles;
[Table("Role")]
public class Role
{
    [Column("role_id")]
    [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [JsonPropertyName("role_id")]
    public int Id { get; set; }
    [Column("role_name")]
    public string RoleName { get; set; }

    [JsonIgnore]
    public virtual ICollection<RolePermission>? RolePermissions { get; set; }
    [JsonPropertyName("permission_name")]
    [NotMapped]
    public int[] Permissionids { get; set; }
}
