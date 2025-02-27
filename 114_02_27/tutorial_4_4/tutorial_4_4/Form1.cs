namespace tutorial_4_4
{
    public partial class Form1 : Form
    {
        private double sum = 0; // Add this line to declare the 'sum' variable

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loglistBox.Items.Clear();
            loglistBox.Items.Add("平均油耗紀錄");
        }

        private void 計算Button_Click(object sender, EventArgs e)
        {
            double distance, gas, average;
            if (double.TryParse(kmTextBox.Text, out distance))
            {
                if (double.TryParse(gasTextBox.Text, out gas))
                {
                    average = distance / gas;
                    averageLabel.Text = "平均油耗" + average.ToString("f2") + "公升/公里";
                    loglistBox.Items.Add(average.ToString("f2") + "公升/公里");
                }
                else
                {
                    MessageBox.Show("請輸入數字");
                    gasTextBox.Focus();
                    gasTextBox.Text = "";
                }
            }
            else
            {
                MessageBox.Show("請輸入數字");
                kmTextBox.Focus();
                kmTextBox.Text = "";
            }
        }

        private void 離開Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (loglistBox.Items.Count > 1)
            {
                double sum = 0;
               
                
                for (int i = 1; i < loglistBox.Items.Count; i++)
                {
                    sum += double.Parse(loglistBox.Items[i].ToString().Replace("公升/公里", ""));
                }
                loglistBox.Items.Add("平均油耗" + (sum / (loglistBox.Items.Count - 1)).ToString("f2") + "公升/公里");
            }
            else
            {
                MessageBox.Show("沒有紀錄");
            }
        }
    }
}
