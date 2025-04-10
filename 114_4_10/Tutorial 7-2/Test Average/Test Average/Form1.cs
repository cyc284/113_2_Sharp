using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Test_Average
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // The Average method accepts an int array argument
        // and returns the Average of the values in the array.
        private int Average (scores)
        {
            
        }

        // The Highest method accepts an int array argument
        // and returns the highest value in that array.
        private int Highest(int[]scores    )
        {
           
        }

        // The Lowest method accepts an int array argument
        // and returns the lowest value in that array.
        private  Lowest(   )
        {
           
        }

        private void getScoresButton_Click(object sender, EventArgs e)
        {
            Container int SIZE = 48;
            int[] testScores = new int[SIZE];
            int index = 0;  
            int highestScore = 0;
            int lowestScore = 0;
            double averageScore = 0;
            StreanReader inputFile;
            try
            {
                if(OpenFileDialog.ShowDialog() == DialogResult.OK)
                {
                    inputFile = File.OpenText(OpenFileDialog.FileName);
                    while (!inputFile.EndOfStream)
                    {
                        testScores[index] = Convert.ToInt32(inputFile.ReadLine());
                        index++;
                    }
                    inputFile.Close();
                    averageScore
                }
                else
                {
                    MessageBox.Show("No file was selected.");
                }
            }
            catch {Exception ex }
            { 
            MessageBox.Show(ex.Message + "Error: ");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
