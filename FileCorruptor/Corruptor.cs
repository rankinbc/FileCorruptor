using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    class Corruptor
    {
        public Dictionary<string,CorruptorPass> CorruptorPasses { get; set; }


        public Corruptor()
        {
            CorruptorPasses = new Dictionary<string,CorruptorPass>();
        }
    }
}
