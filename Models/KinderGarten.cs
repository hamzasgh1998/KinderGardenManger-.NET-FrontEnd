using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PI4SAE.Models
{
    public class KinderGarten
    {

        public long idKinderGarten { get; set; }
        public String nameKinderGarten { get; set; }
        public String address { get; set; }
        public String descritpion { get; set; }
        public DateTime dateEvent2 { get { return new DateTime(creationDate); } }
        public long creationDate { get; set; }
        public String tel { get; set; }
        public int nbEmployees { get; set; }
        public float price { get; set; }
        public String email { get; set; }
        public int capacity { get; set; }
        public int reputationComments { get; set; }
        public int reputationReclamations { get; set; }
        public int reputationRates { get; set; }
        public Boolean canteenn { get; set; }
       




    }
}