namespace Calculator
{
    public partial class Form1 : Form
    {
        string results = "";
        bool operatorFound = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            results = results + button1.Text;
            result.Text = results;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            results = results + button2.Text;
            result.Text = results;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            results = results + button3.Text;
            result.Text = results;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            results = results + button4.Text;
            result.Text = results;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            results = results + button5.Text;
            result.Text = results;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            results = results + button6.Text;
            result.Text = results;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            results = results + button7.Text;
            result.Text = results;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            results = results + button8.Text;
            result.Text = results;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            results = results + button9.Text;
            result.Text = results;
        }

        private void Calculate(char operators)
        {
            string[] expression;

            if (results.Split('-')[0] == "")
            {
                if (results.Contains('+'))
                {
                    expression = results.Split('+');
                    try
                    {
                        results = (Convert.ToInt64(expression[0]) + Convert.ToInt64(expression[1])).ToString();
                    } catch
                    {
                        return;
                    }
                }
                else if (results.Contains('x'))
                {
                    expression = results.Split('x');
                    try
                    {
                        results = (Convert.ToInt64(expression[0]) * Convert.ToInt64(expression[1])).ToString();
                    }
                    catch
                    {
                        return;
                    }          
                }
                else if (results.Contains('-'))
                {
                    expression = results.Split('-');
                    if (expression[2] == "")
                    {
                        return;
                    }
                    try
                    {
                        results = (-1 * (Convert.ToInt64(expression[1])) - Convert.ToInt64(expression[2])).ToString();
                    }
                    catch
                    {
                        return;
                    }
                }
            }
            else
            {
                if (results.Contains('+'))
                {
                    expression = results.Split('+');
                    if (expression[1] == "")
                    {
                        return;
                    }
                    try
                    {
                        results = (Convert.ToInt64(expression[0]) + Convert.ToInt64(expression[1])).ToString();
                    }
                    catch
                    {
                        return;
                    }
                }
                else if (results.Contains('x'))
                {
                    expression = results.Split('x');
                    if (expression[1] == "")
                    {
                        return;
                    }
                    try
                    {
                        results = (Convert.ToInt64(expression[0]) * Convert.ToInt64(expression[1])).ToString();
                    }
                    catch
                    {
                        return;
                    }
                    
                }
                else if (results.Contains('-'))
                {
                    expression = results.Split('-');
                    if (expression[1] == "")
                    {
                        return;
                    }

                    try
                    {
                        results = (Convert.ToInt64(expression[0]) - Convert.ToInt64(expression[1])).ToString();
                    }
                    catch
                    {
                        return;
                    }
                }
            }

            if (operators != '=')
            {
                results = results + operators;
            }
        }

        private void buttonmulti_Click(object sender, EventArgs e)
        {
            if (operatorFound == false)
            {
                if (results == "")
                {
                    results = "0";
                }
                operatorFound = true;
                results = results + buttonmulti.Text;
            }
            else
            {
                Calculate(Convert.ToChar(buttonmulti.Text));
            }
            result.Text = results;
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            if (operatorFound == false)
            {
                if (results == "")
                {
                    results = "0";
                }
                operatorFound = true;
                results = results + buttonplus.Text;
            }
            else
            {
                Calculate(Convert.ToChar(buttonplus.Text));
            }
            result.Text = results;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            if (operatorFound == false)
            {
                if (results == "")
                {
                    results = "0";
                }
                operatorFound = true;
                results = results + buttonminus.Text;
            }
            else
            {
                Calculate(Convert.ToChar(buttonminus.Text));
            }
            result.Text = results;
        }

        private void buttonequal_Click(object sender, EventArgs e)
        {
            Calculate(Convert.ToChar(buttonequal.Text));
            operatorFound = false;
            result.Text = results;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            results = results + button0.Text;
            result.Text = results;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            results = "";
            result.Text = "0";
        }
    }
}