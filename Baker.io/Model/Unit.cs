using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("Units",Schema = "baker")]
    public class Unit
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }
    }
}