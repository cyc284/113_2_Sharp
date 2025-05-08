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

        // IsValidNumber ��k�����@�Ӧr��ê�^ true 
        // �p�G���]�t 10 �ӼƦr�A�_�h��^ false�C
        private bool IsValidNumber(string str)
        {
            const int VALID_LENGTH = 10; // ���Ī��q�ܸ��X����
            if(str.Length != VALID_LENGTH)
            {
                for (int i = 0; i < str.Length; i++)
                {
                    // �p�G��e�r�Ť��O�Ʀr�A��^ false
                    if (!char.IsDigit(str[i]))
                    {
                        return false;
                    }
                }
                return true; 
            }
        }

        // TelephoneFormat ��k�����@�Ӧr��Ѽơ]�H�ޥΤ覡�ǻ��^�A
        // �ñN��榡�Ƭ��q�ܸ��X�C�Ҧp(12)3456-7890�C
        //�Ҧp�N1234567890�令(12)3456-7890
        private void TelephoneFormat(ref string str)
        {
            // �ˬd�r����׬O�_�� 10
            if (str.Length == 10)
            {
                // �ϥ� Substring ��k�����l�r��A�ô��J�A���M�s�r��
                // �N�r��榡�Ƭ��q�ܸ��X�榡
                str = $"({str.Substring(0, 2)}){str.Substring(2, 4)}-{str.Substring(6, 4)}";
            }
            else
            {
                // �p�G�r����פ��O 10�A��ܿ��~�T��
                MessageBox.Show("�п�J���Ī��q�ܸ��X�C");
            }
        }
      //str = str.Insert(0, "(");

            // �b�r�ꪺ�� 3 �Ӧ�m���J ")"
            //str = str.Insert(3, ")");

            // �b�r�ꪺ�� 9 �Ӧ�m���J "-"
           // str = str.Insert(9, "-");
        }


        // formatButton ���I���ƥ�B�z�{��
        private void formatButton_Click(object sender, EventArgs e)
        {
            string input = numberTextBox.Text; // ����Τ��J���q�ܸ��X
            if (IsValidNumber(input))
            {
                TelephoneFormat(ref input); // �榡�ƹq�ܸ��X
                outputTextBox.Text = input; // �N�榡�ƫ᪺�q�ܸ��X��ܦb��X�ؤ�
            }
            else
            {
                MessageBox.Show("�п�J���Ī��q�ܸ��X�C");
            }
        }

        // exitButton ���I���ƥ�B�z�{��
        private void exitButton_Click(object sender, EventArgs e)
        {
            // �������C
            this.Close();
        }
    }
}
