using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coin_Toss
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tossButton_Click(object sender, EventArgs e)
        {
            coin myCoin = new coin();
            // Clear the ListBox.
            outputListBox.Items.Clear();
            // Toss the coin five times.
            for (int i = 0; i < 5; i++)
            {
                myCoin.toss();
                // Add the result to the ListBox.
                outputListBox.Items.Add(myCoin.GetSideUp());
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
