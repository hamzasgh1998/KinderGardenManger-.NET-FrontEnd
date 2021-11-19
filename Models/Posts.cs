
using Pi4Sae4.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pi4Sae4.Models
{
    public class Posts
    {
		public long idPost { get; set; }

		public Subject subject { get; set; }

		public ValidePost validePost { get; set; }
		public String namePost { get; set; }
		public int nbrLike { get; set; }
		public int nbrDislike { get; set; }
		public String img { get; set; }
		public int nbrSignal { get; set; }
		public String description { get; set; }

		public IEnumerable<Comments> Comments { get; set; }






	}
}