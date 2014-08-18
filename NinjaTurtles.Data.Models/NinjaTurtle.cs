using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaTurtlesApp.Data.Models
{
    public class NinjaTurtle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string Description { get; set; }
        public string PictureLg { get; set; }
        public string PictureSm { get; set; }

        public string Personality { get; set; }
        public string Weapons { get; set; }
        public NinjaTurtle() { }
        public NinjaTurtle(string name, string color, string description, string pictureLg, string pictureSm, string personality, string weapons)
        {
            Name = name;
            Color = color;
            Description = description;
            PictureLg = pictureLg;
            PictureSm = pictureSm;
            Personality = personality;
            Weapons = weapons;
        }
    }
}
