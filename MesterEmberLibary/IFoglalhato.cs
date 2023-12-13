using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesterEmberLibary
{
    internal interface IFoglalhato
    {
        IEnumerable<int> FoglalhatoNapok();
        int SzabadNapoSzama { get; }
    }
}
