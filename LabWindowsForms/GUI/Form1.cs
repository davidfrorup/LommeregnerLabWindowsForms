using LabWindowsForms.Logic;
using System;
using System.Windows.Forms;

namespace LabWindowsForms
{
    public partial class Form1 : Form
    {

        private Calc _calculator;
        private double _firstValue;
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
            //if (_firstValue == 0)
            //{
            //    _firstValue = Convert.ToDouble(txtBox.Text);
            //    _calcOperatorMode = CalcType.Addition;
            //    ClearCalculationValiabel();
            //}
            //else
            //{
            //    var result = _calculator.PerformCalculation(_calcOperatorMode, _firstValue, Convert.ToInt32(txtBox.Text));
            //    txtBox.Text = result.ToString();
            //    _firstValue = result;
            //    txtBox.Focus();
            //}
            if (txtBox.Text != "")
            {
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Addition;
                ClearCalculationValiabel();
                txtBox.Focus();
            }
            else
            {
                ClearCalculationValiabel();
            }
        }


        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Subtraction;
                ClearCalculationValiabel();
            }
            else
            {
                ClearCalculationValiabel();
            }
        }
        private void btnMultiplication_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Multiplication;
                ClearCalculationValiabel();
            }
            else
            {
                ClearCalculationValiabel();
            }
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Division;
                ClearCalculationValiabel();
            }
            else
            {
                ClearCalculationValiabel();
            }
        }

        private void btnModulus_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Modulos;
                ClearCalculationValiabel();
            }
            else
            {
                ClearCalculationValiabel();
            }
        }

        private void ClearCalculationValiabel()
        {
            txtBox.Text = "0";
            txtBox.Focus();
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            if (txtBox.Text != "")
            {
                var result = _calculator.PerformCalculation(_calcOperatorMode, _firstValue, Convert.ToDouble(txtBox.Text));
                txtBox.Text = result.ToString();
                txtBox.Focus();
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

        private void btnErase_Click(object sender, EventArgs e)
        {
            if (txtBox.Text.Length > 0)
            {
                txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            }
            else
            {
                ClearCalculationValiabel();
            }
        }

        //private void txtBox_KeyPress(object sender, KeyEventArgs e)
        //{

            

            //if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            //{
            //    //txtBox.Text += "0";
            //}

            //else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            //{
            //    //txtBox.Text += "1";
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

            //else if (e.KeyCode == Keys.Add)
            //{
                
            //    ClearCalculationValiabel();
            //    //txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
            //    //_firstValue = Convert.ToDouble(txtBox.Text.Length - 1);
            //    _firstValue = Convert.ToDouble(txtBox.Text);
            //    _calcOperatorMode = CalcType.Addition;
            //    ClearCalculationValiabel();
            //    txtBox.Focus();
            //}

            //else if (e.KeyCode == Keys.Subtract)
            //{
            //    ClearCalculationValiabel();
            //    _firstValue = Convert.ToDouble(txtBox.Text);
            //    _calcOperatorMode = CalcType.Subtraction;
            //    ClearCalculationValiabel();
            //    txtBox.Focus();
            //}

            //else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Enter)
            //{
            //    btnEquals_Click(sender, e);
            //}

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
        //}

        private void txtBox_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            txtBox.Focus();

            if (e.KeyCode == Keys.D0 || e.KeyCode == Keys.NumPad0)
            {
                //txtBox.Text += "0";
            }

            else if (e.KeyCode == Keys.D1 || e.KeyCode == Keys.NumPad1)
            {
                //txtBox.Text += "1";
            }

            else if (e.KeyCode == Keys.D2 || e.KeyCode == Keys.NumPad2)
            {
                // txtBox.Text += "2";
            }

            else if (e.KeyCode == Keys.D3 || e.KeyCode == Keys.NumPad3)
            {
                // txtBox.Text += "3";
            }

            else if (e.KeyCode == Keys.D4 || e.KeyCode == Keys.NumPad4)
            {
                //  txtBox.Text += "4";
            }

            else if (e.KeyCode == Keys.D5 || e.KeyCode == Keys.NumPad5)
            {
                //  txtBox.Text += "5";
            }

            else if (e.KeyCode == Keys.D6 || e.KeyCode == Keys.NumPad6)
            {
                //  txtBox.Text += "6";
            }

            else if (e.KeyCode == Keys.D7 || e.KeyCode == Keys.NumPad7)
            {
                //  txtBox.Text += "7";
            }

            else if (e.KeyCode == Keys.D8 || e.KeyCode == Keys.NumPad8)
            {
                // txtBox.Text += "8";
            }

            else if (e.KeyCode == Keys.D9 || e.KeyCode == Keys.NumPad9)
            {
                // txtBox.Text += "9";
            }

            else if (e.KeyCode == Keys.Add)
            {
                //ClearCalculationValiabel();
                //btnPlus_Click(sender,e);
                //ClearCalculationValiabel();
                ////txtBox.Text = txtBox.Text.Substring(0, txtBox.Text.Length - 1);
                ////_firstValue = Convert.ToDouble(txtBox.Text.Length - 1);
                //_firstValue = Convert.ToDouble(txtBox.Text);
                //_calcOperatorMode = CalcType.Addition;
                //ClearCalculationValiabel();
                
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Addition;
                txtBox.Focus();
                txtBox.Text = "";
                txtBox.Focus();
                
            }

            else if (e.KeyCode == Keys.Subtract)
            {
                _firstValue = Convert.ToDouble(txtBox.Text);
                _calcOperatorMode = CalcType.Subtraction;
                txtBox.Focus();
                txtBox.Text = "";
                txtBox.Focus();
            }

            else if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Enter)
            {
                btnEquals_Click(sender, e);
            }
            
        }
    }
}
