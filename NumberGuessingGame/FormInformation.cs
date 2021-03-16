using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NumberGuessingGame
{
    public partial class FormInformation : Form
    {
        public FormInformation()
        {
            InitializeComponent();
       }

        private void buttonReturnHomePage_Click(object sender, EventArgs e)
        {
            //Ana forma dönmeyi sağlar.
            this.Close();
            NumberGuessingGame form1 = new NumberGuessingGame();
            form1.Show();
            
        }
    }
}
