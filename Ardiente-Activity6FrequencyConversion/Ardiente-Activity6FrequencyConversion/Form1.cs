namespace Ardiente_Activity6FrequencyConversion
{
    public partial class Form1 : Form
    {
        bool isFreq = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            isFreq = !radioButtonF.Checked;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            isFreq = radioButtonS.Checked;
        }

        private void inputText_TextChanged(object sender, EventArgs e)
        {

        }

        private void outputText_Click(object sender, EventArgs e)
        {

        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            // Get the input value as a string from the inputText control
            string inputValue = inputText.Text;

            // Convert the input value to a double
            if (double.TryParse(inputValue, out double input))
            {
                // Perform the conversion based on the value of isFreq
                double convertedValue;
                string unit;

                if (isFreq)
                {
                    convertedValue = 1 / input;
                    unit = "hertz";
                }
                else
                {
                    convertedValue = 1 / input;
                    unit = "second" + (input != 1 ? "s" : ""); // Add 's' for plural if input is not 1
                }

                // Format the result and set it to the outputText control
                outputText.Text = $"{convertedValue} {unit}";
            }
            else
            {
                // Handle invalid input
                outputText.Text = "Invalid input";
            }
        }
    }
}
