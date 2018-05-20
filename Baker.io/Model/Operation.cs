using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("Operations",Schema = "baker")]
    public class Operation
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Params { get; set; }
    }
}