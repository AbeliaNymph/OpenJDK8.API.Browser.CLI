using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Core.ORM.Entity;

[Table("Classes")]
public class AClassEntity(string id, string name, string packageName)
{
    [Required]
    public string Id { get; set; } = id;

    [Required]
    public string Name { get; set; } = name;

    [Required]
    public string PackageName { get; set; } = packageName;
}
