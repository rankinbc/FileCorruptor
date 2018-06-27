using Be.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    class HexBoxManager
    {
        Dictionary<string, HexBox> HexBoxes;

        public bool StayAligned { get; set; } 

        public HexBoxManager()
        {
            HexBoxes = new Dictionary<string, HexBox>();
        }

        public void AddHexBox(string hexboxIdentifier, ref HexBox HexBoxFormObject)
        {
            HexBoxes.Add(hexboxIdentifier, HexBoxFormObject);
        }

       public void SetHexBoxFile(string hexboxIdentifier, ref LoadedFile file)
        {
            HexBox targetHexBox = HexBoxes[hexboxIdentifier];
            DynamicByteProvider dbp = new DynamicByteProvider(file.BinaryContent);
            targetHexBox.ByteProvider = dbp;
        }

        public byte[] GetHexBoxContent(string hexboxIdentifier)
        {
            HexBox targetHexBox = HexBoxes[hexboxIdentifier];
            return ((DynamicByteProvider)targetHexBox.ByteProvider).Bytes.ToArray() ;
        }

    }
}
