namespace Test_Average
{
    partial class Form1
    {
        /// <summary>
        /// ���ݪ��]�p���ܶq�C
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// �M�z�Ҧ����b�ϥΪ��귽�C
        /// </summary>
        /// <param name="disposing">�p�G�����񦫺޸귽�A�� true�F�_�h�� false�C</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows ����]�p�ͦ����N�X

        /// <summary>
        /// �]�p������һݪ���k - �ФŨϥΥN�X�s�边�ק惡��k�����e�C
        /// </summary>
        private void InitializeComponent()
        {
            this.getScoresButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // getScoresButton
            // 
            this.getScoresButton.Location = new System.Drawing.Point(12, 12);
            this.getScoresButton.Name = "getScoresButton";
            this.getScoresButton.Size = new System.Drawing.Size(75, 23);
            this.getScoresButton.TabIndex = 0;
            this.getScoresButton.Text = "�������";
            this.getScoresButton.UseVisualStyleBackColor = true;
            this.getScoresButton.Click += new System.EventHandler(this.getScoresButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(93, 12);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "�h�X";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.getScoresButton);
            this.Name = "Form1";
            this.Text = "���ե�����";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button getScoresButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}
