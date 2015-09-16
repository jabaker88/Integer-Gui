using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Int_Gui
{
    public partial class MathGUI : Form
    {
        int number1;
        int number2;
        int Output1;
        int Output2;
        int Output3;
        int Output4;
        int Output5;
        Boolean Valid1;
        Boolean Valid2;
        public MathGUI()
        {
            InitializeComponent();
        }

        private void InputBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckForInt_Click(object sender, EventArgs e)
        {
            if (int.TryParse(InputBox1.Text, out number1))
            {
                MessageBox.Show(InputBox1.Text);//For Debugging
                Valid1 = true;

            }//end if
            else
            {
                InputBox1.Clear();
                MessageBox.Show("Not a valid integer");
                Valid1 = false;
            }
            // end else

            if (int.TryParse(InputBox2.Text, out number2))
            {
                MessageBox.Show(InputBox2.Text);//For Debugging
                Valid2 = true;
            }//end if
            else
            {
                InputBox1.Clear();
                MessageBox.Show("Not a valid integer");
                Valid2 = false;
            }
            // end else

            if (Valid1 == true & Valid2 == true);
            {
                Output1 = number1 + number2;
                Output2 = number1 - number2;
                Output3 = number1 * number2;
                Output4 = number1 / number2;
                Output5 = number1 % number2;
                MessageBox.Show("The sum is " + Convert.ToString(Output1));
                MessageBox.Show("The difference is " + Convert.ToString(Output2));
                MessageBox.Show("The product is " + Convert.ToString(Output3));
                MessageBox.Show("The quotient is " + Convert.ToString(Output4));
                MessageBox.Show("The modulus is " + Convert.ToString(Output5));
            }


        }

        private void InputBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        
    }
}
