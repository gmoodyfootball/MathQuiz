using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoodyGMathQuiz
{
    public partial class Form1 : Form
    {
        // Create a Random object called randomizer
        // to generate random numbers
        Random randomizer = new Random();

        // Variables for the addition problem
        int addend1;
        int addend2;
        // subtraction
        int minuend;
        int subtrahend;
        // Multiply
        int multiplicand;
        int multiplier;
        //Divide
        int dividend;
        int divisor;

        // Create a countdown timer
        int timeLeft;

        public void StartTheQuiz()
        {
            //create random numbers
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);
            //Display said numbers
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();
            //The starting value of the upDown counter
            sum.Value = 0;

            //Fill in the subtraction portion
            minuend = randomizer.Next(1, 101);
            subtrahend = randomizer.Next(1, minuend); //so we don't have a negative number
            minusLabelLeft.Text = minuend.ToString();
            minusLabelRight.Text = subtrahend.ToString();
            difference.Value = 0;

            //Fill in the multiplication problem
            multiplicand = randomizer.Next(2, 11);
            multiplier = randomizer.Next(2, 11);
            timesLabelLeft.Text = multiplicand.ToString();
            timesLabelRight.Text = multiplier.ToString();
            product.Value = 0;

            //Fill in the division problem
            divisor = randomizer.Next(2, 11);
            int temporaryQuotient = randomizer.Next(2, 11);
            dividend = divisor * temporaryQuotient;
            dividedLabelLeft.Text = dividend.ToString();
            dividedLabelRight.Text = divisor.ToString();
            quotient.Value = 0;

            //Start the timer
            timeLeft = 30; //30 seconds
            timeLabel.Text = "30 Seconds";
            timer1.Start();
        }

        private bool CheckTheAnswer()
        {
            if ((addend1 + addend2 == sum.Value)
                && (minuend - subtrahend == difference.Value)
                && (multiplicand * multiplier == product.Value)
                && (dividend / divisor == quotient.Value))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Set the time
            DateTime today = new DateTime();
            today = DateTime.Today;
            timeDateLabel.Text = today.ToString("dd MMMM yyyy"); // 30 January 2018 format
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (CheckTheAnswer()) //If the answers are all right
            {
                timer1.Stop();
                MessageBox.Show("You got all the answers right!", "Congratulations!");
                startButton.Enabled = true;
            }
            else if (timeLeft > 0)
            {
                if (timeLeft <= 5)
                {
                    timeLabel.BackColor = Color.Red;
                }
                //Display the new time left
                //by updating the Time Left label
                timeLeft -= 1; //Minus a second
                timeLabel.Text = timeLeft + " seconds";
            }
            else
            {
                //If time is up, stop the timer, show a MessageBox
                //and fill in the answers
                timer1.Stop();
                timeLabel.Text = "Time's up!";
                MessageBox.Show("You didn't finish in time", "Sorry, you stink!");
                sum.Value = addend1 + addend2;
                difference.Value = minuend - subtrahend;
                product.Value = multiplicand * multiplier;
                quotient.Value = dividend / divisor;

                timeLabel.BackColor = default(Color);

                startButton.Enabled = true;
            }
        }

        private void answer_Enter(object sender, EventArgs e)
        {
            //Select the whole answer in the NumbericUpDown control.
            NumericUpDown answerBox = sender as NumericUpDown;

            if (answerBox != null)
            {
                int lengthOfAnswer = answerBox.Value.ToString().Length;
                answerBox.Select(0, lengthOfAnswer);
            }
        }

        private void check_answer_add(object sender, EventArgs e)
        {
            //Called whenever they change the answer in the add answerbox
            if (addend1 + addend2 == sum.Value)
            {
                //play a sound or something
                sum.BackColor = Color.LightGreen;
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                sum.BackColor = default(Color);
                //They're not right. So, they're wrong. No sound for you!
            }
        }

        private void check_answer_minus(object sender, EventArgs e)
        {
            //Called whenever they change the answer in the minus answerbox
            if (minuend - subtrahend == difference.Value)
            {
                //play a sound or something
                difference.BackColor = Color.LightGreen;
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                difference.BackColor = default(Color);
                //They're not right. So, they're wrong. No sound for you!
            }
        }

        private void check_answer_multiply(object sender, EventArgs e)
        {
            //Called whenever they change the answer in the multiply answerbox
            if (multiplicand * multiplier == product.Value)
            {
                //play a sound or something
                product.BackColor = Color.LightGreen;
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                product.BackColor = default(Color);
                //They're not right. So, they're wrong. No sound for you!
            }
        }

        private void check_answer_divide(object sender, EventArgs e)
        {
            //Called whenever they change the answer in the multiply answerbox
            if (dividend / divisor == quotient.Value)
            {
                //play a sound or something
                quotient.BackColor = Color.LightGreen;
                System.Media.SystemSounds.Asterisk.Play();
            }
            else
            {
                quotient.BackColor = default(Color);
                //They're not right. So, they're wrong. No sound for you!
            }
        }

    }
}
