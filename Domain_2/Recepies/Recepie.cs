using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Domain.ingredients;

namespace Domain.Recepies
{
    public class Recepie
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public RecepieStatus Status { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Ingredient> Ingredients { get; set; }
        public IList<string> Categories { get; set; }
        public string Category { set; get; }
        public int Difficulty { get; set; }
        public int Duration { get; set; }
        public virtual User CreatedBy { get; set; }
        public Boolean isActive { set; get; }

        public DateTime CreatedAt
        {
            get;
        } = DateTime.Now;

        public override string ToString()
        {
            return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}, {nameof(Status)}: {Status}, {nameof(Description)}: {Description}, {nameof(Ingredients)}: {Ingredients}, {nameof(Categories)}: {Categories}, {nameof(Difficulty)}: {Difficulty}, {nameof(Duration)}: {Duration}, {nameof(CreatedBy)}: {CreatedBy}, {nameof(CreatedAt)}: {CreatedAt}";
        }
    }
}