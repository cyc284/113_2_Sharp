namespace tutorial_4_4
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            Labe2l = new Label();
            label3 = new Label();
            kmTextBox = new TextBox();
            gasTextBox = new TextBox();
            計算Button = new Button();
            averageLabel = new Label();
            離開Button = new Button();
            loglistBox = new ListBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label1.Location = new Point(45, 78);
            label1.Name = "label1";
            label1.Size = new Size(143, 24);
            label1.TabIndex = 0;
            label1.Text = "輸入行駛里程數";
            // 
            // Labe2l
            // 
            Labe2l.AutoSize = true;
            Labe2l.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            Labe2l.Location = new Point(45, 147);
            Labe2l.Name = "Labe2l";
            Labe2l.Size = new Size(143, 24);
            Labe2l.TabIndex = 1;
            Labe2l.Text = "消耗油量公升數";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 136);
            label3.Location = new Point(64, 225);
            label3.Name = "label3";
            label3.Size = new Size(124, 24);
            label3.TabIndex = 2;
            label3.Text = "你的平均油耗";
            // 
            // kmTextBox
            // 
            kmTextBox.Location = new Point(256, 79);
            kmTextBox.Name = "kmTextBox";
            kmTextBox.Size = new Size(123, 23);
            kmTextBox.TabIndex = 3;
            // 
            // gasTextBox
            // 
            gasTextBox.Location = new Point(256, 147);
            gasTextBox.Name = "gasTextBox";
            gasTextBox.Size = new Size(123, 23);
            gasTextBox.TabIndex = 4;
            // 
            // 計算Button
            // 
            計算Button.Location = new Point(28, 331);
            計算Button.Name = "計算Button";
            計算Button.Size = new Size(160, 84);
            計算Button.TabIndex = 6;
            計算Button.Text = "計算";
            計算Button.UseVisualStyleBackColor = true;
            計算Button.Click += 計算Button_Click;
            // 
            // averageLabel
            // 
            averageLabel.BorderStyle = BorderStyle.Fixed3D;
            averageLabel.Location = new Point(256, 225);
            averageLabel.Name = "averageLabel";
            averageLabel.Size = new Size(123, 24);
            averageLabel.TabIndex = 7;
            // 
            // 離開Button
            // 
            離開Button.Location = new Point(236, 331);
            離開Button.Name = "離開Button";
            離開Button.Size = new Size(143, 84);
            離開Button.TabIndex = 8;
            離開Button.Text = " 離開";
            離開Button.UseVisualStyleBackColor = true;
            離開Button.Click += 離開Button_Click;
            // 
            // loglistBox
            // 
            loglistBox.FormattingEnabled = true;
            loglistBox.ItemHeight = 15;
            loglistBox.Location = new Point(403, 54);
            loglistBox.Name = "loglistBox";
            loglistBox.Size = new Size(222, 214);
            loglistBox.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(448, 317);
            button1.Name = "button1";
            button1.Size = new Size(143, 84);
            button1.TabIndex = 10;
            button1.Text = "總平均";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(637, 450);
            Controls.Add(button1);
            Controls.Add(loglistBox);
            Controls.Add(離開Button);
            Controls.Add(averageLabel);
            Controls.Add(計算Button);
            Controls.Add(gasTextBox);
            Controls.Add(kmTextBox);
            Controls.Add(label3);
            Controls.Add(Labe2l);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label Labe2l;
        private Label label3;
        private TextBox kmTextBox;
        private TextBox gasTextBox;
        private Button 計算Button;
        private Label averageLabel;
        private Button 離開Button;
        private ListBox loglistBox;
        private Button button1;
    }
}
