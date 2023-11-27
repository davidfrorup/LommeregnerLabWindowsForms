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

        private void btnSender(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (txtBox.Text == "0") txtBox.Text = "";
            txtBox.Text += button.Text;
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Addition;
            
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Subtraction;
            ClearCalculationValiabel();
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Multiplication;
            ClearCalculationValiabel();
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Division;
            ClearCalculationValiabel();
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            _firstValue = Convert.ToInt32(txtBox.Text);
            _calcOperatorMode = CalcType.Modulos;

            ClearCalculationValiabel();
        }

        private void ClearCalculationValiabel()
        {
            txtBox.Text = "0";
            txtBox.Focus();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
                var result = _calculator.PerformCalculation(_calcOperatorMode, _firstValue, Convert.ToInt32(txtBox.Text));
                txtBox.Text = result.ToString();
                txtBox.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearCalculationValiabel();
            _firstValue = 0;
        }

        private void txtBox_KeyUp(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            //{
            //    // txtBox.Text += "0";
            //}

            //else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            //{
            //    // txtBox.Text += "1";
            //}

            //else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            //{
            //    // txtBox.Text += "2";
            //}

            //else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            //{
            //    // txtBox.Text += "3";
            //}

            //else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            //{
            //    //  txtBox.Text += "4";
            //}

            //else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            //{
            //    //  txtBox.Text += "5";
            //}

            //else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            //{
            //    //  txtBox.Text += "6";
            //}

            //else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            //{
            //    //  txtBox.Text += "7";
            //}

            //else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            //{
            //    // txtBox.Text += "8";
            //}

            //else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            //{
            //    // txtBox.Text += "9";
            //}

            if (e.KeyCode == Keys.Add)
            {
                ClearCalculationValiabel();
                _firstValue = Convert.ToInt32(txtBox.Text);
                _calcOperatorMode = CalcType.Addition;
                ClearCalculationValiabel();
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                ClearCalculationValiabel();
                _firstValue = Convert.ToInt32(txtBox.Text);
                _calcOperatorMode = CalcType.Subtraction;
                ClearCalculationValiabel();
            }

            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Enter)
            {
                btnEquals_Click(sender, e);
            }

            //else
            //{
            //    ClearCalculationValiabel();
            //}


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
