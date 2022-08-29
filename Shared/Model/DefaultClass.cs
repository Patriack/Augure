using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Augure.Shared.Model
{
    public class DefaultClass
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public bool IsDeleted { get; set; }
        public Guid UniqueIdentifier { get; set; } = Guid.NewGuid();

        public User CreateUser { get; set; }

        public DateTime CreateDateTime { get; set; }

        public User ModifyUser { get;  set; }

        public DateTime ModifyDateTime { get; set; }

    }
}
