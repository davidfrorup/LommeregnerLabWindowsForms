using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LabWindowsForms.Logic;

namespace LabWindowsForms
{
    public partial class Form1 : Form
    {

        private Calc _calculator;
        private int _firstValue;
        private CalcType _calcOperatorMode;

        public Form1()
        {
            InitializeComponent();
            _calculator = new Calc();
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtBox.Text += button.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Addition;
            ClearCalculationValiabel();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            //var senderBox = (string)sender;
            //var txt = senderBox;
            
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Subtraction;
            ClearCalculationValiabel();
        }

        private void ClearCalculationValiabel()
        {
            txtBox.Text = String.Empty;
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if(txtBox.Text != "")
            {
                var result = _calculator.PerformCalculation(_calcOperatorMode, _firstValue, Convert.ToInt32(txtBox.Text));
                txtBox.Text = result.ToString();
            }
            else
            {
                ClearCalculationValiabel();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculationValiabel();
            _firstValue = 0;
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                btn0_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                btn1_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                btn2_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                btn3_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                btn4_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                btn5_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                btn6_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                btn7_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                btn8_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                btn9_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.Add)
            {
                btnPlus_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                btnMinus_Click(sender, (EventArgs)e);
            }

            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Enter)
            {
                btnEquals_Click(sender, (EventArgs)e);
            }

            else
            {
                ClearCalculationValiabel();
            }
           // var t = txtBox.Text;

            /*
             And Logic
             | 0  0 | 0 |
             | 0  1 | 0 |
             | 1  0 | 0 |
             | 1  1 | 1 |
            
             NOT And Logic
             | 0  0 | 1 |
             | 0  1 | 1 |
             | 1  0 | 1 |
             | 1  1 | 0 |

             OR Logic
             | 0  0 | 0 |
             | 0  1 | 1 |
             | 1  0 | 1 |
             | 1  1 | 1 |
            
             XOR - Logic
             | A | B | A XOR B |
             | 0 | 0 |    0    |
             | 0 | 1 |    0    |
             | 1 | 0 |    0    |
             | 1 | 1 |    0    |


             */

            //string name1 = Console.ReadLine();
            //string name2 = Console.ReadLine();

            //if(name1 != "David" || name2 != "Nanna")
            //{

            //}

            //else if (!string.IsNullOrEmpty(name1)) { }
        }
    }
}
