using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Augure.Shared.Model
{
    public class User : IdentityUser<int>
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public override int Id { get => base.Id; set => base.Id = value; }

        public Guid UniqueIdentifier { get; set; } = Guid.NewGuid();


    }
}
