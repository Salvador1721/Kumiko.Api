
namespace Kumiko.Domain.Entities.Base;

public class ModelBase //
{
    public DateTime CreatedTime { get; set; }
    public DateTime? UpdatedTime { get; set; } //? propiedad al tipo de dato de ser nullable
    public int CreatedBy { get; set; }
    public int UptadedBy { get; set; }
    public bool Active { get; set; } = true;


}
    