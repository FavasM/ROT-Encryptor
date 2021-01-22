using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ROT_Encryptor
{
    public partial class mainUI : Form
    {
        public mainUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void decryptBtn_Click(object sender, EventArgs e)
        {
            string encryptedString = stringBox.Text;
            int shiftKey = Convert.ToInt32(keyBox.Text);

            string decryptedString = "";
            char whitespace = ' ';

            for (int i = 0; i < encryptedString.Length; i++)
            {
                if (encryptedString[i] == whitespace)
                {
                    decryptedString += whitespace;
                    continue;
                }

                int decryptedValue = (int)encryptedString[i] - shiftKey;
                char decryptedChar = (char)decryptedValue;

                decryptedString += decryptedChar;
            }

            if (shiftKey < 0 || shiftKey > 26)
                resultBox.Text = "Enter Key between 0 to 26";
            else
                resultBox.Text = decryptedString;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            _ = MessageBox.Show(@"Tool Name : ROT Encryptor

Author Name : Favas M

Date : 22/01/2021

Version : 1.0

  
         Thanks For Using");
        }

        private void encryptBtn_Click(object sender, EventArgs e)
        {
            string stringValue = stringBox.Text;
            int shiftKey = Convert.ToInt32(keyBox.Text);

            string encryptedString = "";
            char whiteSpace = ' ';

            for (int i = 0; i < stringValue.Length; i++)
            {
                if (stringValue[i] == whiteSpace)
                {
                    encryptedString += whiteSpace;
                    continue;
                }

                int encryptedValue = (int) stringValue[i] + shiftKey ;
                char encryptedChar = (char) encryptedValue;
                
                encryptedString += encryptedChar;
            }

            if (shiftKey < 0 || shiftKey > 26)
                resultBox.Text = "Enter Key between 0 to 26";
            else
                resultBox.Text = encryptedString;
        }
    }
}
