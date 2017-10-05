using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.IO;

namespace Rana_Aujeszky_Gregory_Decrypt.BusinessLogic
{
    public class ReadFile
    {
        private string filePath;

        public ReadFile()
        {
            filePath = "..//..//Test 1 Candidate Plaintexts.txt";
        }

        public List<string> LoadDictionary()
        {
            List<string> dictionaryItems = new List<string>();
            dictionaryItems = File.ReadAllLines(filePath).ToList();
            return dictionaryItems;
        }

}
}

