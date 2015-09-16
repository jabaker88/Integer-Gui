using System;
using System.Windows.Forms;
using System.Speech.Synthesis;

/*
Write a GUI C# program that will prompt the user for an integer, read it in, and store it in a variable. 
The user should be prompted to enter a 2nd integer, store it in a variable then display the results of the 
following operations:

1st Integer + 2ndInteger
1st Integer - 2ndInteger
1st Integer * 2ndInteger
1st Integer / 2ndInteger
1st Integer % 2ndInteger
Include error checking to insure the value entered is an integer.
Next, generate 2 random #s and complete the same operations as above.

*/

namespace Int_Gui
{
    public partial class MathGUI : Form
    {
        //Class fields
        int number1;
        int number2;
        SpeechSynthesizer speaker = new SpeechSynthesizer(); //Speech Synthesizer

        /// <summary>
        /// Class Constructor
        /// </summary>
        public MathGUI()
        {
            InitializeComponent();

            //Random requirment
            Random myRandom = new Random();

            InputBox1.Text = myRandom.Next(1000).ToString();
            InputBox2.Text = myRandom.Next(1000).ToString();
        }


        /// <summary>
        /// Button for calc values
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CheckForInt_Click(object sender, EventArgs e)
        {
            try
            {
                number1 = Convert.ToInt32(InputBox1.Text);
                number2 = Convert.ToInt32(InputBox2.Text);

                string result = number1 + " + " + number2 + " = " + (number1 + number2).ToString() + "\n" +
                        number1 + " - " + number2 + " = " + (number1 - number2).ToString() + "\n" +
                        number1 + " * " + number2 + " = " + (number1 * number2).ToString() + "\n" +
                        number1 + " / " + number2 + " = " + (number1 / number2).ToString() + "\n" +
                        number1 + " % " + number2 + " = " + (number1 % number2).ToString() + "\n";

                //Use Speech synth to speak
                speaker.SpeakAsync(result);

                //Show results from MessageBox
                MessageBox.Show(result);
                
            }
            catch (Exception ex)
            {
                //Show error
                MessageBox.Show("Please enter a valid number!\nMessage: " + ex.Message);

                //Clear values from textboxes
                InputBox2.Clear();
                InputBox1.Clear();
            }
        }        
    }
}
