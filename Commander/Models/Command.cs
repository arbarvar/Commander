using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

//here is first place to start programing by creating Models
namespace Commander.Models
{
    public class Command
    {
        public int Id { get; set; }
        public string HowTo { get; set; }
        public string Line { get; set; }
        public string Platform { get; set; }

    }
}
