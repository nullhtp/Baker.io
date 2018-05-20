using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("Elements",Schema = "baker")]
    public class Element
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public Guid CategoryId { get; set; }

        public Guid UnitId { get; set; }

        public string ImagePath { get; set; }

        public string Params { get; set; }
    }
}