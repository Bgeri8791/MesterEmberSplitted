using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MesterEmberLibary
{
    public abstract class MesterEmber : IFoglalhato
    {
        readonly string nev;
        readonly int napidij;
        readonly bool[] szabadE;

        protected MesterEmber(string nev, int napidij)
        {
            this.nev = nev;
            this.napidij = napidij;
            this.szabadE = Enumerable.Range(0,31).Select(_ =>true).ToArray();
        }

        public int SzabadNapoSzama => 
            Enumerable
            .Range(1, szabadE.Length)
            .Count(x => szabadE[x - 1]);

        public virtual IEnumerable<int> FoglalhatoNapok() =>
            Enumerable
            .Range(1, szabadE.Length)
            .Where(x => szabadE[x - 1]);

        public override string ToString()
        {
            return $"{nev} - napidij:{napidij}, szabad napok:{String
                .Join(",",Enumerable
                .Range(1, szabadE.Length)
                .Where(x => szabadE[x - 1]))}";
        }

        public bool this[int index] { 
            get {
                if (index < 1 || index > szabadE.Length)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), $" 1 és {szabadE.Length} között kell lennie");
                }
                return szabadE[index-1];
            } 
        }

        public abstract bool MunkaVallal(int nap);

        protected void Lefoglal(int nap)
        {
            if (nap < 1 || nap > szabadE.Length)
            {
                throw new ArgumentOutOfRangeException(nameof(nap), $" 1 és {szabadE.Length} között kell lennie");
            }
            szabadE[nap - 1] = false;
        }
    }
}
