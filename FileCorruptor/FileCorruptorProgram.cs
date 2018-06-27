using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    class FileCorruptorProgram
    {
        public FileManager FileManager { get; set; }
        public string CurrentSourceFileIdentifier { get; set; }
        //corruptor

        public FileCorruptorProgram()
        {
            FileManager = new FileManager();
        }

        public void LoadExternalFile(string filePath)
        {
            string identifier = FileManager.LoadExternalFile(filePath);

            if (CurrentSourceFileIdentifier == null)
            {
                CurrentSourceFileIdentifier = identifier;
            }
        }

        public LoadedFile MakeCopy(string newIdentifier, string sourceFileIdentifier)
        {
            return FileManager.Copy(newIdentifier, sourceFileIdentifier);
        }

        public LoadedFile GetCurrentSourceFile()
        {
            return FileManager.LoadedFiles[CurrentSourceFileIdentifier];
        }

        public void SetCurrentSourceFile(string identifier)
        {
            if (FileManager.LoadedFiles.ContainsKey(identifier))
            {
                CurrentSourceFileIdentifier = identifier;
            }
        }

        public LoadedFile SelectFile(string identifier)
        {
            if (FileManager.LoadedFiles.ContainsKey(identifier))
            {
                return FileManager.LoadedFiles[identifier];
            }
            else
            {
                return null;
            }
        }

    }
}
