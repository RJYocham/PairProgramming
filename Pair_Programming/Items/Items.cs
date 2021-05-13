using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pair_Programming.Items
{
    public class Key : IItems
    {
        public string ItemName => "Key";

        public string ItemDescription => "This should open a door somewhere";
    }

    public class Cup : IItems
    {
        public string ItemName => "Cup";

        public string ItemDescription => "Seems like an ordinary cup";
    }
}
