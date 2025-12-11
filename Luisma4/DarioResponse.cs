using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Luisma4
{
    public record class DarioResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public bool Married { get; set; }
        public string Hobbies { get; set; }
    }
}
