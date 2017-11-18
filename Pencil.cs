using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pencil
{
    class Pencil
    {
        public int PencilId { get; set; }

        public string Brand { get; set; }

        public decimal Price { get; set; }

        public override string ToString()
        {
            return "PencilId : " + PencilId + "\nBrand : " + Brand + "\nPrice : " + Price + " USD\n";
        }
    }
}
