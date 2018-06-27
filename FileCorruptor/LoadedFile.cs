using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FileCorruptor
{
    public class LoadedFile
    {
        public Guid Id { get; set; }
        public string FilePath { get; set; }
        public byte[] BinaryContent { get; set; }
        public bool ReadOnly { get; set; }

        private static SHA1CryptoServiceProvider SHA1Provider = new SHA1CryptoServiceProvider();

        public string GetSHA1()
        {
            using (SHA1CryptoServiceProvider SHA1Provider = new SHA1CryptoServiceProvider())
            {
                return Convert.ToBase64String(SHA1Provider.ComputeHash(BinaryContent));
            }
        }
    }
}
