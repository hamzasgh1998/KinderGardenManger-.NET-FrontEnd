using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI4SAE.Models
{
    public class Menu
    {
        public long idMenu { get; set; }
        public Plat plat { get; set; }
        public Days day { get; set; }
        public float energetic_value { get; set; }
        public KinderGarten KinderGarten { get; set; }

        public long? idKinderGarten { get; set; }


    }
}