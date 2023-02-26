using System.Windows.Forms.Design;

namespace call
{
    public partial class Form1 : Form
    {
        double result = 0;
        string opPerforment = "";
        bool isOpPerforment = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (isOpPerforment))
            {
                textBox1.Clear();
            }

            isOpPerforment = false;
            Button btn = (Button)sender;
            if (btn.Text == ".")
            {
                if(!textBox1.Text.Contains(".")) 
                {
                    textBox1.Text = textBox1.Text + btn.Text;
                }

            }else
            textBox1.Text =  textBox1.Text + btn.Text;
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            if(result != 0) 
            {
                button18.PerformClick();
                opPerforment = btn.Text;
                CurrentOp.Text = result + " " + opPerforment;
                isOpPerforment = true;
            }
            else
            {
                opPerforment = btn.Text;
                result = double.Parse(textBox1.Text);
                CurrentOp.Text = result + " " + opPerforment;
                isOpPerforment = true;
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            result = 0;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            switch (opPerforment)
            {
                case "+":
                    textBox1.Text = (result + double.Parse(textBox1.Text)).ToString(); 
                    break;

                case "-":
                    textBox1.Text = (result - double.Parse(textBox1.Text)).ToString();
                    break;

                case "/":
                    textBox1.Text = (result / double.Parse(textBox1.Text)).ToString();
                    break;

                case "x":
                    textBox1.Text = (result * double.Parse(textBox1.Text)).ToString();
                    break;
                default:
                    break;
            }

            result = double.Parse(textBox1.Text);
            CurrentOp.Text = "";
        }
    }
}