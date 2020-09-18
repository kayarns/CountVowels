//Kayla Arns
//September 18,2020
//Counts the vowels in a line of text

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;

namespace CountVowels
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void txtText_TextChanged(object sender, EventArgs e)
        {
            txtVowels.Text = "";
        }

        private void btnCount_Click(object sender, EventArgs e)
        {
           int vowel = 0;

            string text = txtText.Text.ToLower();

            int len = text.Length;

            for(int i = 0; i< len; i++)
            {

                if (text[i] == 'a' || text[i] == 'e' || text[i] == 'i' || text[i] == 'o' || text[i] == 'u')
                {
                    vowel++;
                }
                
            }

            txtVowels.Text = Convert.ToString(vowel);

        }
    }
}
