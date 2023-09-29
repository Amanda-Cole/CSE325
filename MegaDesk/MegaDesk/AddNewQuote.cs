using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MegaDesk
{
    public partial class AddNewQuote : Form
    {
        public AddNewQuote()
        {
            InitializeComponent();
            this.DateBox.Text = DateTime.Now.ToString("MMMM', 'dd', 'yyyy");
        }


        //********************************************Validate width and depth********************************
        //need to code in a try catch


        private void ExitAddNew_Click(object sender, EventArgs e)
        {
            //close button return back to MainMenuForm
            MainMenuForm viewMainMenuForm = (MainMenuForm)Tag;
            viewMainMenuForm.Show();
            Close();
        }


        private void CalcQuoteButton_Click(object sender, EventArgs e)
        {
            //set desk Object with inputs, create new desk
            double width = int.Parse(this.InputWidth.Text);
            double depth = int.Parse(this.InputDepth.Text);
            double drawer = int.Parse(this.InputDrawers.Text);
            SurfaceMaterial material = (SurfaceMaterial)Enum.Parse(typeof(SurfaceMaterial), this.InputSurfMat.Text);//(this.SurfaceMatInput.Text);
            Desk desk = new Desk(width, depth, drawer, material);

            //create new DeskQuote with desk properties, and additional information
            DeskQuote deskQuote = new DeskQuote(desk);
            deskQuote.Name = this.InputName.Text;
            deskQuote.OrderDate = this.DateBox.Text;
            deskQuote.RushOrder = int.Parse(this.InputRushOrder.Text);

            //add new DeskQuote to List DeskQuotes
            MainMenuForm viewMainMenuForm = (MainMenuForm)Tag;
            viewMainMenuForm.DeskQuotes.Add(deskQuote);

            //Activate DisplayQuotesForm
            DisplayQuotes viewDisplayQuotes = new DisplayQuotes(deskQuote)
            {
                Tag = this
            };
            //viewDisplayQuotes.DeskQuote = deskQuote;
            viewDisplayQuotes.Show(this);
            this.Hide();

        }

        private void InputWidth_Leave(object sender, EventArgs e)
        {
            try
            {
                double width = double.Parse(this.InputWidth.Text);
                if (width < Desk.minwidth || width > Desk.maxwidth)
                {
                    this.InputWidthLabel.ForeColor = Color.Red;
                    MessageBox.Show($"Please enter a valid Number between {Desk.minwidth} & {Desk.maxwidth}");
                    this.InputWidth.Focus();
                }
                else
                {
                    this.InputWidthLabel.ForeColor = Color.Black;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Please enter a valid Number between {Desk.minwidth} & {Desk.maxwidth}");
                this.InputWidth.Focus();
            }
        }

        //validation of input within range when leaving InputDepth
        private void InputDepth_Leave(object sender, EventArgs e)
        {
            // Get the text from the TextBox
            string inputText = InputDepth.Text;

            // Check if all characters in the input text are digits
            bool allDigits = true;
            foreach (char c in inputText)
            {
                if (!char.IsDigit(c))
                {
                    allDigits = false;
                    MessageBox.Show("Enter a valid number");

                    break; // Exit the loop early if a non-digit character is encountered
                }
            }
            if (allDigits)
            {
                try
                {
                    double depth = double.Parse(this.InputDepth.Text);
                    if (depth < Desk.mindepth || depth > Desk.maxdepth)
                    {
                        this.InputDepthLabel.ForeColor = Color.Red;
                        MessageBox.Show($"Please enter a valid Number between {Desk.mindepth} & {Desk.maxdepth}");
                        this.InputDepth.Focus();
                    }
                    else
                    {
                        this.InputDepthLabel.ForeColor = Color.Black;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Please enter a valid Number between {Desk.mindepth} & {Desk.maxdepth}");
                    this.InputDepth.Focus();
                }
            }
            else
            {
                MessageBox.Show("Input contains non-digit characters.");
                this.InputDepth.Focus();
            }
        }

        //validation of keypress for numbers only
        private void InputDepth_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsControl(e.KeyChar))
            {
                return;
            }
            if (!Char.IsDigit(e.KeyChar))
            {
                // Cancel the key press event if it's not a digit
                e.Handled = true;
            }
        }

    }
}
