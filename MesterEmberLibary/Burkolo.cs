using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesterEmberLibary
{
    public sealed class Burkolo : MesterEmber
    {
        public enum Tipus { belso, kulso};

        public Tipus Szakterulet { get; }
        public Burkolo(string nev, int napidij, Tipus szakterulet) : base(nev, napidij)
        {
            Szakterulet = szakterulet;
        }
        public override string ToString()
        {
            return base.ToString() + $" szakterület: {Szakterulet} burkoló";
        }
        public override bool MunkaVallal(int nap)
        {
            if (!this[nap])
            {
                return false;
            }
            if (SzabadNapoSzama < 10)
            {
                throw new TulSokElfoglaltsagException();
            }
            Lefoglal(nap);
            return true;
        }
    }
}
