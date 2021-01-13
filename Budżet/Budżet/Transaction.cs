using System;
using System.Collections.Generic;
using System.Text;

namespace Budżet
{
    public class Transaction
    {
        public string Name { get; set; }

        public decimal Value { get; set; }

        public int TypeId { get; set; }
    }
}
