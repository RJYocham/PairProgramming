using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming.Items
{
    public class Items : IItems
    {
        public string ItemName => "Key";

        public string ItemDescription => "This should open a door somewhere";
    }
}
