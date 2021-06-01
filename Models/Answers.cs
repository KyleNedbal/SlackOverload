using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace SlackOverload.Models
{
    [Table("answers")]
    public class Answers
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string detail { get; set; }
        public int questionid { get; set; }
        public DateTime posted { get; set; }

    }
}
