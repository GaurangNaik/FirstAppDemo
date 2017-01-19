using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysSandwitch.Core.Models
{
    public class SandwitchGroup
    {
        public int GroupId { get; set; }
        public string Title{ get; set; }
        public List<Sandwitch> Sandwitches { get; set; }
        public string ImagePath { get; set; }

    }
}
