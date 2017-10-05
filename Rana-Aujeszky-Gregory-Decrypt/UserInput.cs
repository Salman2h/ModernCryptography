using System;
using System.Collections.Generic;
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

        private List<string> fileItems;
        public UserInput()
        {
            InitializeComponent();

            ReadFile readFile = new ReadFile();
            
            fileItems = readFile.LoadDictionary();
        }

        private bool IsStringExistInDictionary(string searchString)
        {
            bool isStringExists = false;
            if (fileItems.Find(delegate (string matchingString) { return matchingString == searchString; }) != null)
            {
                isStringExists = true;
            }

            return isStringExists;
        }

        private void ReadDictionaryButton_Click(object sender, EventArgs e)
        {
            if (IsStringExistInDictionary(inputTextbox.Text))
            {
                outputTextBox.Text = "Found";
            }
            else
            {
                outputTextBox.Text = "Not Found";
            }
        }
        

        private void MaxLengthWordButton_Click(object sender, EventArgs e)
        {
            outputTextBox.Text = fileItems.OrderByDescending(s => s.Length).First();
        }

        private void minLengthWordButton_Click(object sender, EventArgs e)
        {

        }

        private void decryptButton_Click(object sender, EventArgs e)
        {

        }
    }
}
