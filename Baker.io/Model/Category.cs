using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("Categories",Schema = "baker")]
    public class Category
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}