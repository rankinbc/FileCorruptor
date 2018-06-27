using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    public static class FileUtilities
    {
        public static LoadedFile LoadExternalFile(string identifier, string filePath)
        {
            LoadedFile file = new LoadedFile()
            {
                Id = Guid.NewGuid(),
                BinaryContent = File.ReadAllBytes(filePath),
                FilePath = filePath,
                ReadOnly = true
            };
            return file;
        }

        public static LoadedFile MakeDeepCopy(LoadedFile sourceFile)
        {
            LoadedFile file = new LoadedFile()
            {
                Id = Guid.NewGuid(),
                BinaryContent = (byte[])sourceFile.BinaryContent.Clone(),
                FilePath = null,
                ReadOnly = true
            };
            return file;
        }

        
    }
}
