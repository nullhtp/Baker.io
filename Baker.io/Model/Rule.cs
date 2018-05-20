using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("Rules",Schema = "baker")]
    public class Rule
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}