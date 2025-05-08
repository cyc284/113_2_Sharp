using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Telephone_Format
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // IsValidNumber 方法接受一個字串並返回 true 
        // 如果它包含 10 個數字，否則返回 false。
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // 有效的電話號碼長度
            if(str.Length != VALID_LENGTH)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // 如果當前字符不是數字，返回 false
                    if (!char.IsDigit(str[i]))
                    {
                        return false;
                    }
                }
                return true; 
            }
        }

        // TelephoneFormat 方法接受一個字串參數（以引用方式傳遞），
        // 並將其格式化為電話號碼。例如(12)3456-7890。
        //例如將1234567890改成(12)3456-7890
        private void TelephoneFormat(ref string str)
        {
            // 檢查字串長度是否為 10
            if (str.Length == 10)
            {
                // 使用 Substring 方法提取子字串，並插入括號和連字符
                // 將字串格式化為電話號碼格式
                str = $"({str.Substring(0, 2)}){str.Substring(2, 4)}-{str.Substring(6, 4)}";
            }
            else
            {
                // 如果字串長度不是 10，顯示錯誤訊息
                MessageBox.Show("請輸入有效的電話號碼。");
            }
        }
      //str = str.Insert(0, "(");

            // 在字串的第 3 個位置插入 ")"
            //str = str.Insert(3, ")");

            // 在字串的第 9 個位置插入 "-"
           // str = str.Insert(9, "-");
        }


        // formatButton 的點擊事件處理程式
        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // 獲取用戶輸入的電話號碼
            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input); // 格式化電話號碼
                outputTextBox.Text = input; // 將格式化後的電話號碼顯示在輸出框中
            }
            else
            {
                MessageBox.Show("請輸入有效的電話號碼。");
            }
        }

        // exitButton 的點擊事件處理程式
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單。
            this.Close();
        }
    }
}
