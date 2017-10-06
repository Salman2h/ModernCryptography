using System;
using System.Collections;

using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Rana_Aujeszky_Gregory_Decrypt.BusinessLogic;

namespace Rana_Aujeszky_Gregory_Decrypt
{
    public partial class UserInput : Form
    {
        private char delimiter=',';
        private List<string> plainTextList;
        private Hashtable keyTable;
        private Hashtable freqList;
        public UserInput()
        {
            InitializeComponent();
            plainTextList = Helper.LoadDictionary("..//..//Test 1 Candidate Plaintexts.txt");
            keyTable = Helper.InitKeys();
            freqList = Helper.InitFrequency();
        }
        
        private void decryptButton_Click(object sender, EventArgs e)
        {   
            string[] cipherText = cipherTextBox.Text.Split(delimiter);

            foreach (string plainText in plainTextList)
            {
                foreach (string key in keyTable.Keys)
                {
                    ((ArrayList)keyTable[key]).Clear();
                }

                bool isMatched = true;
                if (plainText.Length == cipherText.Length)
                {
                    for (int index = 0; index < cipherText.Length && isMatched; index++)
                    {
                        string aKey = plainText.Substring(index, 1);
                        ArrayList aList = ((ArrayList)keyTable[aKey]);
                        if (aList.Count >= (int)freqList[aKey])
                        {
                            isMatched = false;
                        }
                        else
                        {
                            aList.Add(cipherText[index]);
                        }
                    }
                    if (isMatched)
                    {
                        plainTextBox.Text += string.Format("{0}{1}", (plainTextBox.Text.Length > 0) ? "," : "", plainText);
                        break;
                    }
                }
            }
        }

        private void cbDelimiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbDelimiter.Text)
            {
                case "Tab":
                    delimiter = '\t';
                    break;
                case "Comma":
                    delimiter = ',';
                    break;
                case "Space":
                    delimiter = ' ';
                    break;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
