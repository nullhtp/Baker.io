using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("RuleElements",Schema = "baker")]
    public class RuleElement
    {
        public Element Element { get; set; }

        public Rule Rule { get; set; }

        public int Proportion { get; set; }

        public bool Direction { get; set; }

        public string ParamsValue { get; set; }
    }
}