using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SampleLibrary.Models
{
    public class Make
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
