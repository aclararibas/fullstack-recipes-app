using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Domain.Recepies
{
    public class RecepieInfo
    {
        [Key]

        public int Id { get; set; }
        public string Comment { get; set; }
        public int Rating { get; set; }
        public virtual Recepie Recepie { get; set; }
        public virtual User CreatedBy { get; set; }
    }
}