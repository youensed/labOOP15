using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;




namespace Lab15s
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxX.Text = "0,0";
            textBoxY.Text = "0,0";
            textBoxResult.Text = "";

        }


        private void buttonSolve_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;

            if (Double.TryParse(textBoxX.Text, out double result))
            {
                x = Convert.ToDouble(textBoxX.Text);
            }
            else
            {
                textBoxResult.Text = "Введіть число х";
            }
            if (Double.TryParse(textBoxY.Text, out double result1))
            {
                y = Convert.ToDouble(textBoxY.Text);
            }
            else
            {
                textBoxResult.Text = "Введіть число Y";
            }
            if (Double.TryParse(textBoxX.Text, out double result2) && Double.TryParse(textBoxY.Text, out double result13))
            {
                textBoxResult.Text = Convert.ToString(Math.Exp(x) - ((y * y + 12 * x * y - 3 * x * x) / (18 * y - 1)));
            }
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            double x = 0, y = 0;

            if (Double.TryParse(textBoxX2.Text, out double result))
            {
                x = Convert.ToDouble(textBoxX2.Text);
            }
            else
            {
                textBoxSum.Text = "Введіть число х";
            }
            if (Double.TryParse(textBoxY2.Text, out double result1))
            {
                y = Convert.ToDouble(textBoxY2.Text);
            }
            else
            {
                textBoxSum.Text = "Введіть число Y";
            }
            if (Double.TryParse(textBoxX2.Text, out double result2) && Double.TryParse(textBoxY2.Text, out double result13))
            {
                textBoxSum.Text = Convert.ToString(x + y);
                textBoxSub.Text = Convert.ToString(x - y);
                textBoxMul.Text = Convert.ToString(x * y);
                textBoxDiv.Text = Convert.ToString(x / y);
            }
            else
            {
                textBoxSum.Text = "Введіть коректне числове значення";
            }

        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0, q = 0;

            if (Double.TryParse(textBoxGeom.Text, out double result) && textBoxGeom.Text.Length < 4)
            {
                a = Math.Floor(Convert.ToDouble(textBoxGeom.Text) / 100);
                b = Math.Floor(Convert.ToDouble(textBoxGeom.Text) / 10) % 10;
                c = Convert.ToDouble(textBoxGeom.Text) % 10;
                q = a / 1;
                if (b / 2 == q && c / 3 == q)
                {
                    textBoxResOfChecking.Text = "true; q = " + q + "; b1 = " + a + " , b2 = " + b + " , b3 = " + c + ".";
                }
                else
                {
                    textBoxResOfChecking.Text = "false";
                }

            }
            else
            {
                textBoxResOfChecking.Text = "Введіть тризначне число для перевірки!";
            }
        }

        private void buttonCalcTask4_Click(object sender, EventArgs e)
        {
            double a = 0, b = 0, c = 0;
            if (Double.TryParse(textBoxA.Text, out double result))
            {
                a = Convert.ToDouble(textBoxA.Text);
            }
            else
            {
                textBoxDoubleRes.Text = "Введіть число a";
            }
            if (Double.TryParse(textBoxС.Text, out double result1))
            {
                b = Convert.ToDouble(textBoxС.Text);
            }
            else
            {
                textBoxDoubleRes.Text = "Введіть число b";
            }
            if (Double.TryParse(textBoxС.Text, out double result4))
            {
                c = Convert.ToDouble(textBoxC.Text);
            }
            else
            {
                textBoxDoubleRes.Text = "Введіть число с";
            }

            if (Double.TryParse(textBoxA.Text, out double result2) && Double.TryParse(textBoxС.Text, out double result13) && Double.TryParse(textBoxC.Text, out double result5))
            {
                textBoxDoubleRes.Text = "a = " + Math.Abs(a * 2) + ", b = " + Math.Abs(b * 2) + " , c = " + Math.Abs(c * 2);
            }
            else
            {
                textBoxDoubleRes.Text = "Введіть коректні дані";
            }
        }


        private void buttonRemoveOnes_Click(object sender, EventArgs e)
        {
            string inputNum, res;
            if (Double.TryParse(textBoxNumber.Text, out double result1112))
            {
                inputNum = textBoxNumber.Text;
                res = "";
                foreach (char digit in inputNum)
                {
                    if (digit != '1')
                    {
                        res += digit;
                    }

                }
                textBoxResOfDel.Text = res;
            }
            else
            {
                textBoxResOfDel.Text = "Введіть коректне число";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int counter = 0;
            textBoxResOfSearch.Text = "";
            string[] sequance = textBoxSeq.Text.Split(",");
            if (StringIsDigits(sequance) && Double.TryParse(textBoxT.Text, out _))
            {
                List<string> resList = new List<string>();
                List<int> numbs = sequance.Select(int.Parse).ToList();

                for (int i = 0; i < numbs.Count; i++)
                {
                    if (numbs[i] == Math.Pow(Convert.ToInt32(textBoxT.Text), 2))
                    {
                        resList.Add("t^2: " + Convert.ToString(numbs[i]) + ", index: " + i);
                        counter++;
                    }

                }
                for (int i = 0; i < counter; i++)
                {
                    textBoxResOfSearch.Text += resList[i] + "; ";

                }
            }
            else
            {
                textBoxResOfSearch.Text = "Введіть коректну числову послідовність та/aбо число t!";
            }



        }

        private bool StringIsDigits(string[] s)
        {
            for (int i = 0; i < s.Count(); i++)
            {
                if (!(Double.TryParse(s[i], out double resss)))
                {
                    return false;
                }
            }
            return true;
        }

        private void buttonEditText_Click(object sender, EventArgs e)
        {
            if (textBoxUnedited.Text != "")
            {
                textBoxEdited.Text = textBoxUnedited.Text.Replace(" ", ", ");
            }
            else
            {
                textBoxEdited.Text = "Заповніть рядок!";
            }


        }


    }
}
