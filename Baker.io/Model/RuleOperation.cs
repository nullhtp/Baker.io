using System.ComponentModel.DataAnnotations.Schema;

namespace Baker.io
{
    [Table("RuleOperations",Schema = "baker")]
    public class RuleOperation
    {
        public Operation Operation { get; set; }

        public Rule Rule { get; set; }

        public string ParamsValue { get; set; }

        public int Priority { get; set; }
    }
}