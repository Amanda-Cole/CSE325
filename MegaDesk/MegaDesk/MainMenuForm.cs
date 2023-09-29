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
    public partial class MainMenuForm : Form
    {
        private List<DeskQuote> deskQuotes;

        public List<DeskQuote> DeskQuotes { 
            get { return deskQuotes; } 
            set { deskQuotes = value; }
        }      

        public MainMenuForm()
        {
            InitializeComponent();
            deskQuotes = new List<DeskQuote>();
        }

        private void AddNewQuote_Click(object sender, EventArgs e)
        {
            #region - helpful to collapse
            AddNewQuote viewAddNewQuote = new AddNewQuote
            {
                Tag = this
            };
            viewAddNewQuote.Show(this);
            this.Hide();
            #endregion
        }

        private void ViewQuotes_Click(object sender, EventArgs e)
        {
            #region - helpful to collapse
            ViewQuotesForm viewViewQuotesForm = new ViewQuotesForm

            {
                Tag = this
            };
            viewViewQuotesForm.Show(this);
            this.Hide();
            #endregion
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void SearchQuotes_Click(object sender, EventArgs e)
        {
           SearchQuoteForm viewSearchQuoteForm = new SearchQuoteForm

            {
                Tag = this
            };
            viewSearchQuoteForm.Show(this);
            this.Hide();

        }
    }
}
