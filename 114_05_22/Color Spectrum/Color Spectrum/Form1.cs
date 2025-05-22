using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Color_Spectrum
{
    // 定義一個列舉型別 Spectrum，代表光譜中的七種顏色
    enum Spectrum
    {
        Red, Orange, Yellow, Green,
        Blue, Indigo, Violet
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

           

        /// <summary>
        /// 顯示所選顏色的名稱（以繁體中文顯示於 colorLabel 上）
        /// 根據傳入的 Spectrum 列舉值，將對應的中文顏色名稱顯示在 colorLabel 控制項上。
        /// </summary>
        /// <param name="color">使用者所選的光譜顏色（Spectrum 列舉值）</param>
        private void DisplayColor(Spectrum color)
        {
            // 將列舉值轉換為對應的繁體中文顏色名稱
            switch (color)
            {
                case Spectrum.Red:
                    colorLabel.Text = "紅色";
                    break;
                case Spectrum.Orange:
                    colorLabel.Text = "橙色";
                    break;
                case Spectrum.Yellow:
                    colorLabel.Text = "黃色";
                    break;
                case Spectrum.Green:
                    colorLabel.Text = "綠色";
                    break;
                case Spectrum.Blue:
                    colorLabel.Text = "藍色";
                    break;
                case Spectrum.Indigo:
                    colorLabel.Text = "靛色";
                    break;
                case Spectrum.Violet:
                    colorLabel.Text = "紫色";
                    break;
                default:
                    colorLabel.Text = "";
                    break;
            }
        }

        /// <summary>
        /// 當使用者點擊紅色標籤時，顯示「紅色」字樣於 colorLabel
        /// </summary>
        private void redLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Red);
        }

        /// <summary>
        /// 當使用者點擊橙色標籤時，顯示「橙色」字樣於 colorLabel
        /// </summary>
        private void orangeLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Orange);
        }

        /// <summary>
        /// 當使用者點擊黃色標籤時，顯示「黃色」字樣於 colorLabel
        /// </summary>
        private void yellowLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Yellow);
        }

        /// <summary>
        /// 當使用者點擊綠色標籤時，顯示「綠色」字樣於 colorLabel
        /// </summary>
        private void greenLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Green);
        }

        /// <summary>
        /// 當使用者點擊藍色標籤時，顯示「藍色」字樣於 colorLabel
        /// </summary>
        private void blueLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Blue);
        }

        /// <summary>
        /// 當使用者點擊靛色標籤時，顯示「靛色」字樣於 colorLabel
        /// </summary>
        private void indigoLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Indigo);
        }

        /// <summary>
        /// 當使用者點擊紫色標籤時，顯示「紫色」字樣於 colorLabel
        /// </summary>
        private void violetLabel_Click(object sender, EventArgs e)
        {
            DisplayColor(Spectrum.Violet);
        }
    }
}
