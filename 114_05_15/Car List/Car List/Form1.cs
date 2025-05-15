using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Car_List
{
    // 定義一個汽車結構，包含廠牌、年份與里程數三個欄位
    struct Automobile
    {
        public string make;    // 汽車廠牌
        public int year;       // 汽車年份
        public double mileage; // 汽車里程數
    }

    public partial class Form1 : Form
    {
        // 宣告一個汽車清單，用來儲存所有新增的汽車資料
        private List<Automobile> carList = new List<Automobile>();

        public Form1()
        {
            InitializeComponent();

            // 設定表單及所有控制項的顯示文字為繁體中文
            this.Text = "汽車清單";
            addButton.Text = "新增";
            displayButton.Text = "顯示";
            makeLabel.Text = "廠牌：";
            yearLabel.Text = "年份：";
            mileageLabel.Text = "里程數：";
            carListBox.Text = "汽車列表";
        }

        /// <summary>
        /// 取得使用者於三個文字方塊輸入的汽車資料，
        /// 並將資料指派給傳入的汽車結構參數。
        /// 若輸入格式錯誤，則顯示錯誤訊息。
        /// </summary>
        /// <param name="auto">傳入的汽車結構參數，會被指派新值</param>
        private void GetData(ref Automobile auto)
        {
            try
            {
                // 從廠牌、年份、里程數的文字方塊取得使用者輸入的資料
                auto.make = makeTextBox.Text;
                auto.year = int.Parse(yearTextBox.Text);
                auto.mileage = double.Parse(mileageTextBox.Text);
            }
            catch (Exception ex)
            {
                // 若發生例外（如格式錯誤），顯示錯誤訊息視窗，標題為「錯誤」
                MessageBox.Show("輸入資料格式錯誤，請確認所有欄位皆正確填寫。\n\n詳細資訊：" + ex.Message, "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// 當使用者按下「新增」按鈕時，
        /// 會將目前輸入的汽車資料新增至汽車清單，
        /// 並清空所有輸入欄位，將游標移回廠牌輸入框。
        /// </summary>
        private void addButton_Click(object sender, EventArgs e)
        {
            // 建立一個新的汽車結構實例
            Automobile car = new Automobile();

            // 取得使用者輸入的汽車資料
            GetData(ref car);

            // 將新汽車資料加入汽車清單
            carList.Add(car);

            // 清空所有輸入欄位
            makeTextBox.Clear();
            yearTextBox.Clear();
            mileageTextBox.Clear();

            // 將游標移回廠牌輸入框，方便繼續輸入
            makeTextBox.Focus();
        }

        /// <summary>
        /// 當使用者按下「顯示」按鈕時，
        /// 會將所有已新增的汽車資料以繁體中文格式顯示於清單方塊中。
        /// </summary>
        private void displayButton_Click(object sender, EventArgs e)
        {
            // 宣告一個字串變數，用來儲存每一筆汽車資料的顯示內容
            string output;

            // 清除清單方塊中原有的所有項目
            carListBox.Items.Clear();

            // 逐一將汽車清單中的每一筆資料，格式化後加入清單方塊
            foreach (Automobile aCar in carList)
            {
                // 以「年份 年 廠牌，里程數 xxx 英里。」格式組合顯示內容
                output = aCar.year + " 年 " + aCar.make +
                    "，里程數 " + aCar.mileage + " 英里。";

                // 將組合好的內容加入清單方塊
                carListBox.Items.Add(output);
            }
        }
    }
}
