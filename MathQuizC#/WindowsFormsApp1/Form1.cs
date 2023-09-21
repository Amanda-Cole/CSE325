using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //create a Random object called randomizer
        //to generate random numbers.
        Random randomizer = new Random();

        //add two integer variables
        int addend1;
        int addend2;

        int minuend;
        int subtrahend;

        int multiplicand;
        int multiplier;

        int dividend;
        int divisor;

        int timeLeft;

        string formattedDate = DateTime.Now.ToString("dd MMMM yyyy");

        //create a mthod to StartTheQuiz
        public void StartTheQuiz()
        {
            //set variables to random number range 0-50
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            //convert random numbers to strings and set text property of form
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();

            //set 'sum' on form to 0
            sum.Value =  0;

            //subtraction problem range 0-100
            minuend = randomizer.Next(1,101);
            subtrahend = randomizer.Next(1,minuend);
            minusLeftLabel.Text = minuend.ToString();
            minusRightLabel.Text = subtrahend.ToString();
            difference.Value = 0;

            //multiplication problem range 1-10
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLeftLabel.Text = multiplicand.ToString();
            timesRightLabel.Text = multiplier.ToString();
            product.Value = 0;

            //division problem range 1-10, 
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLeftLabel.Text = dividend.ToString();    
            dividedRightLabel.Text = divisor.ToString();
            quotient.Value = 0;

            //start timer
            timeLeft = 30;
            timeLabel.Text = "30 seconds";
            timer1.Start();
            timeLabel.BackColor = Color.White;

            //********************************************where to place so shows up when program opens*********************
            //set date
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }


        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
                return true;
            else
                return false;
        }
        public Form1()
        {
            InitializeComponent();
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer())
            {
                //if CheckTheAnswer() Returns true then the user is correct and stop timer
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft >0)
            {
                timeLeft = timeLeft - 1;
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                // If the user ran out of time, stop the timer, show
                // a MessageBox, and fill in the answers.
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time.", "Sorry!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;
                startButton.Enabled = true;
            }
            if (timeLeft <=5)
            {
                timeLabel.BackColor = Color.Red;

            }

        }

        private void answer_Enter(object sender, EventArgs e)
        {
            // Select the whole answer in the NumericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }
        private void soundEffect(object sender, EventArgs e)
        {
            NumericUpDown control = sender as NumericUpDown;
            if (control.Name == "sum" && addend1 + addend2 == sum.Value)
            {
                SystemSounds.Beep.Play();
            }
            if (control.Name == "difference" && minuend - subtrahend == difference.Value)
            {
                SystemSounds.Beep.Play();
            }
            if (control.Name == "product" && multiplicand * multiplier == product.Value)
            {
                SystemSounds.Beep.Play();
            }
            if (control.Name == "quotient" && dividend / divisor == quotient.Value)
            {
                SystemSounds.Beep.Play();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateLabel.Text = formattedDate.ToString();
            dateLabel.ForeColor = Color.Black;

        }



    }
}
