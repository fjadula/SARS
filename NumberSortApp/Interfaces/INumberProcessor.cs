using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SARS.Interfaces
{
    interface INumberProcessor
    {
        bool AcceptInput(string input);
        void ProcessAndPrint();

    }
}
