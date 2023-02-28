namespace TemaLAb1MTP
{
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        bool isOperationPerformed=false;
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOperationPerformed)) 
                textBox1.Clear();
          //  isOperationPerformed = true;
            Button button = (Button)sender;
            textBox1.Text = textBox1.Text + button.Text;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operationPerformed = button.Text;
            resultValue = Double.Parse(textBox1.Text);
            isOperationPerformed= true;


        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ati iesit din calculator");
            Environment.Exit(0);
            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            resultValue = 0;
        }

        private void btnegal_Click(object sender, EventArgs e)
        {
            switch(operationPerformed)
            {
                case "+":
                    textBox1.Text = (resultValue + Double.Parse(textBox1.Text)).ToString();
                    break;
                case "-":
                    textBox1.Text = (resultValue - Double.Parse(textBox1.Text)).ToString();
                    break;
                case "*":
                    textBox1.Text = (resultValue * Double.Parse(textBox1.Text)).ToString();
                    break;
                case "/":
                    textBox1.Text = (resultValue / Double.Parse(textBox1.Text)).ToString();
                    break;
                case "sqrt":
                    double inputValue;
                    if (Double.TryParse(textBox1.Text, out inputValue) && inputValue >= 0)
                    {
                        textBox1.Text = Math.Sqrt(inputValue).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Valoarea introdusa nu poate fi calculata radicalul.");
                    }
                    break;
            }
        }
    }


}