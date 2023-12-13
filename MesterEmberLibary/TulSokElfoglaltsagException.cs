using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MesterEmberLibary
{
    public class TulSokElfoglaltsagException : Exception
    {
        public TulSokElfoglaltsagException() : base("A mester túl sok munkát vállalt!"){}
    }
}
