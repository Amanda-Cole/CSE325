using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class DisplayQuotes : Form
    {
        public DeskQuote deskQuote = null;



        public DisplayQuotes(DeskQuote deskQuote)
        {
            InitializeComponent();
            //set DisplayQuotesForm fields to deskQuote.variables

            this.deskQuote = deskQuote;
            this.DisplayOrderDate.Text = deskQuote.OrderDate;
            this.DisplayName.Text = deskQuote.Name;
            this.DisplayWidth.Text = deskQuote.Desk.Width.ToString();
            this.DisplayDepth.Text = deskQuote.Desk.Depth.ToString();
            this.DisplayRushOrder.Text = deskQuote.RushOrder.ToString();
            this.DisplaySurfMat.Text = deskQuote.SurfaceMaterial.ToString();
            this.DisplayDrawers.Text = deskQuote.Desk.NumberofDrawers.ToString();

            string deskQuoteReturn = deskQuote.GetPrice().ToString();
            this.DisplayQuoteTotal.Text = ($"$ {deskQuoteReturn}.00");

        }

        private void DisplayReturnMainButton_Click(object sender, EventArgs e)
        {

            AddNewQuote addNewQuote = (AddNewQuote)Tag;
            addNewQuote.Show();
            Close();
            MainMenuForm mainMenuForm = (MainMenuForm)addNewQuote.Tag;
            mainMenuForm.Show();
            addNewQuote.Close();

        }

    }
}
