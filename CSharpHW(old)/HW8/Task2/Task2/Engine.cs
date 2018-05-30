using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Engine
    {
        public string EngineField { get; set; }
        public Engine(string engine)
        {
            EngineField = engine;
        }
        public override string ToString()
        {
            return EngineField;
        }
    }
}
