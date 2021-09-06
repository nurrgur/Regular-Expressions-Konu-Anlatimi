using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpressions
{
    public class Kisi
    {
        public string TcKimlik { get; set; }
        public string Mail { get; set; }
        public string TelefonNo { get; set; }

        public override string ToString()
        {
            return TcKimlik + " " +Mail+ " "+TelefonNo + " ";
        }
    }
}
