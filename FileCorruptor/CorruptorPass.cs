using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    class CorruptorPass
    {
        public string Identifier { get; set; }
        public int Interval { get; set; }
        public int ChunkSize { get; set; }
        public int StartAddress { get; set; }
        public int EndAddress { get; set; }
        public byte WriteValueMax { get; set; }
        public byte WriteValueMin { get; set; }
    }
}
