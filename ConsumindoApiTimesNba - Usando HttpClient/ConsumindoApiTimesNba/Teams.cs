using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumindoApiTimesNba
{
    public class Teams
    {
        public int Id { get; set; }
        public string Abbreviation { get; set; }
        public string City { get; set; }
        public string Conference { get; set; }
        public string Division { get; set; }
        public string FullName { get; set; }
        public string Name { get; set; }
    }
    public class RootObject : Teams
    {
        public List<Dictionary<string, object>> Data { get; set; }
    }
}
