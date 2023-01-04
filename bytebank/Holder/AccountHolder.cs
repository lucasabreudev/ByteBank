using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank.Holder
{
    public class AccountHolder
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string TaxId { get; set; }
        public string Occupation { get; set; }

        public AccountHolder() { }
    }
}