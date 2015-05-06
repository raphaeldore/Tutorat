using System.ComponentModel.DataAnnotations;

namespace DataLayer.Model
{
    public abstract class Entity
    {
        [Key]
        public int Id { get; set; }
    }
}