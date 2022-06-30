using System;
using System.Data;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace numberconverterT_este__r_
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }
        DataTable Table = new DataTable();
        bool Exists = false;
        bool IsChecked = false;
        bool Calc = false;
        string Final = "";
        public string[] Opers = { "+", "*", "/", "-", "(", ")" };
        public char[] CharOper = { '+', '*', '/', '-', '(', ')' };

        int Base, FromBase;
        string Num;
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void inputbox_TextChanged(object sender, EventArgs e)
        {
            FromBase = Base;
            Num = inputbox.Text;
            for (int i = 0; i < Num.Length; i++)
            {
                Exists = OperExists(i);
                if (Exists)
                {
                    break;
                }
            }
            if (IsChecked && !inputbox.Text.Contains(" ") && inputbox.Text.Length != 0 && !Exists)
            {
                object result = null;
                ConvertRegular(result);
            }

            //else if (Exists)
            //{
            //   
            //   
            //}
            Exists = false;
        }
        bool OperExists(int index)
        {
            for (int i = 0; i < Opers.Length; i++)
            {
                if (CharOper[i] == Num[index])
                {
                    return true;
                }
            }
            return false;
        }
        private void HexButton_CheckedChanged(object sender, EventArgs e)
        {
            //hexbox.Text = "HEX";
            IsChecked = true;
            Base = 16; //Hex
        }

        private void OctalButton_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = true;
            Base = 8; // Octal
        }

        private void DecimalButton_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = true;
            Base = 10; // Decimal
        }

        private void Inputbox_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                Calc = true;
                string decnum = "";
                
                string[] numbers = null;
                string[] oper = Regex.Split(Num, @"\d+"); // Get Operator
                for (int i = 0; i < Opers.Length; i++)
                {
                    numbers = Num.Split(CharOper); // Get Numbers
                }

                for (int i = 0; i < numbers.Length; i++)
                {
                    decnum = Decimal.ConvertToDec(numbers[i], FromBase, 10, true);
                    Final += decnum + oper[i + 1];
                }
                
                object result = Table.Compute(Final, null);
                ConvertRegular(result);
            }

        }

        private void BinaryButton_CheckedChanged(object sender, EventArgs e)
        {
            IsChecked = true;
            Base = 2; // Binary
        }
        void ConvertRegular(object result)
        {
            if (Calc && result != null)
            {

                switch (Base)
                {
                    case 16:
                        ConvertAfCalc(result);
                        break;
                    case 8:
                        ConvertAfCalc(result);
                        break;
                    case 10:
                        ConvertAfCalc(result);
                        break;
                    case 2: ConvertAfCalc(result);
                        break;
                }
            }
            else
            {

            hexbox.Text = Hexadecimal.ConvertToHex(Num, FromBase, 16) + "HEX";
            octbox.Text = Octal.ConvertToOct(Num, FromBase, 8) + "o";
            binbox.Text = "0b" + Binary.ConvertToBin(Num, FromBase, 2);
            dezbox.Text = Decimal.ConvertToDec(Num, FromBase, 10, false);
            }
        }
        void ConvertAfCalc(object result)
        {

            hexbox.Text = Hexadecimal.ConvertToHex(result.ToString(), 10, 16) + "HEX";
            octbox.Text = Octal.ConvertToOct(result.ToString(), 10, 8) + "o";
            binbox.Text = "0b" + Binary.ConvertToBin(result.ToString(), 10, 2);
            dezbox.Text = Decimal.ConvertToDec(result.ToString(), 10, 10, false);
        }
    }

}
