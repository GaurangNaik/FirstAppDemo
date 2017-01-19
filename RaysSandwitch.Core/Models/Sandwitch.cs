using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaysSandwitch.Core.Models
{
    public class Sandwitch
    {
        public int Id { get; set; }
        public string SandwitchName { get; set; }
        public int NumberOfBreads { get; set; }
        public bool IsFavorite { get; set; }
        public double Price { get; set; }


        public Sandwitch()
        {

        }

    }
}
