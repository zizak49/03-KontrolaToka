﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vsite.CSharp
{
    public class Pretraga
    {
        public static bool Sadrži(IEnumerable<string> nizRiječi, string tražena)
        {
            return nizRiječi.Contains(tražena);
            throw new NotImplementedException();
        }

        public static int Zbroj(IEnumerable<int> brojevi)
        {
            return brojevi.Sum();
            throw new NotImplementedException();
        }

        public static IEnumerable<string> NađiSveIza(IEnumerable<string> riječi, string riječ)
        {
            return riječi.Where(r => r.CompareTo(riječ) > 0);
            throw new NotImplementedException();
        }
    }
}
