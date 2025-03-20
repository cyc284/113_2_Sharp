﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Program6_10
{
    public partial class Form1 : Form
    {
        Random rand = new Random();
        string compChoice, winner;
         private int compScore;
        private int playerScore;
        private int tieScore;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            getCompChoice();
        }

        private void getCompChoice()
        {
            int n = rand.Next(1, 4);
            switch (n)
            {
                case 1:
                    compChoice = "石頭";
                    break;
                case 2:
                    compChoice = "布";
                    break;
                case 3:
                    compChoice = "剪刀";
                    break;
            }
        }

        private void showWinner(string myChoice)
        {
            string winner;
            winner =winnerDecide(myChoice);

            label1.Text = "電腦出: " + compChoice + "  玩家出: " + myChoice + "\n" + winner;
            if (winner == "電腦贏")
                compScore++;
            else if (winner == "玩家贏")
                playerScore++;
            else
                tieScore++;
        }
        private string winnerDecide(string myChoice)
        {
            string winnerWho;
            if (myChoice == compChoice)
                winnerWho = "平手!";
            else if (myChoice == "石頭" && compChoice == "剪刀")
                winnerWho = "玩家贏!";
            else if (myChoice == "布" && compChoice == "石頭")
                winnerWho = "玩家贏!";
            else if (myChoice == "剪刀" && compChoice == "布")
                winnerWho = "玩家贏!";
            else
                winnerWho = "電腦贏!";
            return winnerWho;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string myChoice = "石頭";
            showWinner(myChoice);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string myChoice = "布";
            showWinner(myChoice);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string myChoice = "剪刀";
            showWinner(myChoice);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this .Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            getCompChoice();
            label1.Text = "";
        }


    }
}
