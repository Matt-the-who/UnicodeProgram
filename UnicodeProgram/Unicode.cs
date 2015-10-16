/*
Created by Matthew Ho
Created on 10-16-15
Created for ICS3U
Daily Task 3-11
This program converts characters to unicode and displays them in ASCII in a listbox.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeProgram
{
    public partial class frmUnicodeProgram : Form
    {
        public frmUnicodeProgram()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            for(int loopCounter = 65; loopCounter != 91; loopCounter++)
            {

                this.lstBox.Items.Add(Char.ConvertFromUtf32(loopCounter) + " --> " + loopCounter);
            }
        }
    }
}
