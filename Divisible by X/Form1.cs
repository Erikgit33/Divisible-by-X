namespace Divisible_by_X
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tmp = int.Parse(textBox1.Text);
            //A variable which stores the value of the numbers in the textbox in an int format.

            if (tmp % 15 == 0)
            {
                checkBox1.Checked = true;
                checkBox2.Checked = true;
                checkBox3.Checked = true;
            }
            else if (tmp % 5 == 0) 
            {
                checkBox2.Checked = true;
            }
            else if (tmp % 3 == 0)
            {
                checkBox3.Checked = true;
            }
            //If-statement that checks if the number you input is divisible by 15, that is, if it the result returns no decimals.
            //If the divisino does not return any decimals, all checkboxes will be checked, because if a number is divisible by 15,
            //it is also divisible by 5 and 3.
            //The rest of the if-statement checks the same thing with 5 as well as 3.
        }
    }
}
