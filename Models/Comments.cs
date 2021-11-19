using Pi4Sae4.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pi4Sae4.Models
{
    public class Comments
    {

		public long idComment { get; set; }
		public String content { get; set; }
		//public long dateComment { get; set; }
		public ValideComment valideComment { get; set; }



		public Posts posts { get; set; }
		public long? idPost { get; set; }






	}
}