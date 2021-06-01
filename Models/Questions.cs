using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;
using KeyAttribute = Dapper.Contrib.Extensions.KeyAttribute;

namespace SlackOverload.Models
{
    [Table("questions")]
    public class Questions
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string title { get; set; }
        [Required]
        public string detail { get; set; }
        public DateTime posted { get; set; }
        public string category { get; set; }
        public int status { get; set; }
    }
}

