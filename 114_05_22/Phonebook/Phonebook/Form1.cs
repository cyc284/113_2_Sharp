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
using System.Xml.Linq;

namespace Phonebook
{
    // Fix for IDE0051: Remove unused private member 'PhoneBookEntry.txtPhone'  
    // The 'txtPhone' field in the 'PhoneBookEntry' struct is not used anywhere in the code.  
    // It can be safely removed.  

    // Updated PhoneBookEntry struct  
    struct PhoneBookEntry
    {
        public string name;   // 聯絡人姓名  
        public string phone;  // 聯絡人電話  
    }


    public partial class Form1 : Form
    {
        // Fix for IDE0044: Make fields readonly  
        // The 'phoneList' field is only assigned in the constructor and is not modified elsewhere.  
        private readonly List<PhoneBookEntry> phoneList = new List<PhoneBookEntry>();
        private TextBox txtPhone;
        private Label lblName;
        private TextBox txtName;
        private object lblPhone;

        public Form1()
        {
            InitializeComponent();
        }

        // ReadFile 方法會讀取 PhoneList.txt 檔案的內容，
        // 並將每一筆資料轉換成 PhoneBookEntry 結構，
        // 最後存入 phoneList 清單中。
        private void ReadFile()
        {
            StreamReader inputFile;  // 宣告檔案的 StreamReader 物件
            if (openFile.ShowDialog() == DialogResult.OK) // 開啟檔案
            {
                try // 嘗試讀取檔案
                {
                    inputFile = File.OpenText(openFile.FileName); // 開啟檔案
                    string line;
                    while (!inputFile.EndOfStream) // 當未讀至檔案結尾
                    {
                        // 讀取一行資料，並去除前後空白
                        line = inputFile.ReadLine().Trim();
                        // 將資料以逗號分隔，並去除每個欄位的前後空白
                        string[] parts = line.Split(',');
                        if (parts.Length == 2) // 判斷格式是否正確

                        {
                            PhoneBookEntry entry; // 宣告一個 PhoneBookEntry 結構
                            entry.name = parts[0].Trim(); // 姓名
                            entry.phone = parts[1].Trim(); // 電話
                            phoneList.Add(entry); // 將資料加入 List
                        }
                        else // 格式不正確時
                        {
                            MessageBox.Show("檔案格式錯誤");
                        }
                    }
                    inputFile.Close(); // 關閉檔案
                }
                catch (Exception ex) // 若讀取檔案時發生錯誤
                {
                    MessageBox.Show("讀取檔案時發生錯誤：" + ex.Message);
                }
            }
        }


        // DisplayNames 方法會將 phoneList 清單中的所有聯絡人姓名
        // 顯示在 nameListBox 控制項上，方便使用者瀏覽。
        private void DisplayNames()
        {
            foreach (PhoneBookEntry entry in phoneList)
            {
                nameListBox.Items.Add(entry.name); // 將姓名加入 ListBox
            }
        }

        // Form1_Load 事件在表單載入時觸發，
        // 可用來初始化資料或設定表單元件。
        private void Form1_Load(object sender, EventArgs e)
        {
            ReadFile(); // 讀取聯絡人資料
            DisplayNames(); // 顯示聯絡人姓名
        }

        // nameListBox_SelectedIndexChanged 事件在使用者選取不同姓名時觸發，.
        // 可用來顯示該聯絡人的詳細資訊（如電話號碼）。
        private void nameListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = nameListBox.SelectedIndex; // 取得選取的索引
            if (index != -1) // 若有選取項目
            {
                phoneLabel.Text = phoneList[index].phone; // 顯示電話號碼
            }
            else // 若沒有選取項目
            { phoneLabel.Text = "無資料"; } // 清空電話號碼顯示
        }



        // 按下離開按鈕時，關閉整個表單。
        private void exitButton_Click(object sender, EventArgs e)
        {
            // 關閉表單
            this.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string phone = txtPhone.Text.Trim();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(phone))
            {
                MessageBox.Show("請輸入姓名和電話！");
                return;
            }

            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{3}-\d{4}$"))
            {
                MessageBox.Show("電話格式錯誤，請使用 XXX-XXXX 格式，例如 222-6571");
                return;
            }

            PhoneBookEntry entry = new PhoneBookEntry { name = name, phone = phone };
            phoneList.Add(entry);

            // 加入 ListBox
            nameListBox.Items.Add($"{entry.name} - {entry.phone}");

            // 清空輸入欄位，回到姓名欄位
            txtName.Clear();
            txtPhone.Clear();
            txtName.Focus();

            MessageBox.Show("已成功加入通訊錄！");
        }
    }
}