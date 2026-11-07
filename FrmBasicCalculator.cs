using CalculatorPrivateAssembly;

namespace BasicCalculator
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
        }

        private void btnCompute_Click(object sender, EventArgs e)
        {
            try
            {
                float num1 = float.Parse(txtNum1.Text);
                float num2 = float.Parse(txtNum2.Text);

                float result = 0;

                switch (cboOperator.Text)
                {
                    case "+":
                        result = BasicComputation.Addition(num1, num2);
                        break;

                    case "-":
                        result = BasicComputation.Subtraction(num1, num2);
                        break;

                    case "*":
                        result = BasicComputation.Multiplication(num1, num2);
                        break;

                    case "/":
                        result = BasicComputation.Division(num1, num2);
                        break;
                }

                lblTotal.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
