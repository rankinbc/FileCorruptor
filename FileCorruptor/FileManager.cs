using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    public class FileManager
    {
        public Dictionary<string, LoadedFile> LoadedFiles { get; set; }
       

        public FileManager()
        {
            LoadedFiles = new Dictionary<string, LoadedFile>();
        }

        public string LoadExternalFile( string filePath)
        {
            string fileName = Path.GetFileName(filePath);
            string identifier = GenerateFileIdentifier(fileName);

            LoadedFile file = FileUtilities.LoadExternalFile(identifier, filePath);
            LoadedFiles.Add(identifier, file);
            return identifier;
        }


        public LoadedFile Copy(string newIdentifier, string sourceFileIdentifier)
        {
            if (LoadedFiles.ContainsKey(sourceFileIdentifier))
            {
                LoadedFile sourceFile = LoadedFiles[sourceFileIdentifier];
                LoadedFile copiedFile = FileUtilities.MakeDeepCopy(sourceFile);
                LoadedFiles.Add(newIdentifier, copiedFile);
                return copiedFile;
            }
            else
            {
                return null;
            }
        }

        public string GetFileIdentifier(LoadedFile value)
        {
            return LoadedFiles.FirstOrDefault(v => v.Equals(value)).Key;
        }

        public string GenerateFileIdentifier(string identifier)
        {
            if (!LoadedFiles.ContainsKey(identifier))
            {
                return identifier;
            }
            else
            {
                int iteration = 2;
                string attemptIdentifier = identifier + "_" + iteration;
                while (LoadedFiles.ContainsKey(attemptIdentifier))
                {
                    iteration++;
                    attemptIdentifier = identifier + "_" + iteration;
                }
                return attemptIdentifier;
            }
        }


    }

        

        /*
           FileStream fileStream = new FileStream(filePath, FileMode.Open);

            using (BinaryReader reader = new BinaryReader(fileStream))
            {
                reader.BaseStream.Seek(WORLD_SCREEN_DATA_START_INDEX, SeekOrigin.Begin);
                for (int worldScreenIndex = 0; worldScreenIndex < TOTAL_WORLDSCREEN_COUNT; worldScreenIndex++)
                {
                    byte[] block = new byte[16];
                    reader.Read(block, 0, 16);
                    OriginalWorldScreens[worldScreenIndex] = new WorldScreen(block);
                }



            }
         */
    }
