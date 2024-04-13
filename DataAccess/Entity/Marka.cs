using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entity
{
    public class Marka:Base
    {
        public string MarkaName { get; set; }

        public virtual List<Model> Models { get; set; }
    }
}
