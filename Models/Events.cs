using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI4SAE.Models
{
    public class Events
    {
		public long idEvent { get; set; }
		public String nameEvent { get; set; }
		public TypeEvent typeEvent { get; set; }

		public DateTime dateEvent2 { get { return new DateTime(dateEvent); } }
		public long dateEvent { get; set; }
		public int capacityEvent { get; set; }
		public float priceEvent { get; set; }
		public String image { get; set; }

		public KinderGarten KinderGarten { get; set; }

		public User user { get; set; }

		public long? idKinderGarten { get; set; }

		public long? idUser { get; set; }

		public string Nb;


	}
}