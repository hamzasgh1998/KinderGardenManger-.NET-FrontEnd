using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PI4SAE.Models
{
    public class Activities
    {
        public long idActivity { get; set; }
        public String nameActivity { get; set; }
        public TypeActivity typeActivity { get; set; }
        public Days weekDay { get; set; }
 

      //  public DateTime hourActivity2 { get { return new DateTime(hourActivity); } }
        public DateTime hourActivity { get; set; }
        public String teacher { get; set; }



       // HasRequired(p => p.Categorie).WithMany(c => c.Products).HasForeignKey(p => p.CategorieId).WillCascadeOnDelete(false);
       //public long idKinderGarten;
        public  KinderGarten KinderGarten { get; set; }

        public long? idKinderGarten { get; set; }

    }
}