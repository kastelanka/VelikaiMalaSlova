using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VelikaiMalaSlova
{
    public class SaveFileEventArgs : EventArgs
    {
            public SaveFileEventArgs(string tekst)
            {
                Tekst = tekst;
            }

            public readonly string Tekst;
    }
}
