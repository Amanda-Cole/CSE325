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
    public partial class SearchQuoteForm : Form
    {
        public SearchQuoteForm()
        {
            InitializeComponent();
        }

        private void SearchReturnButton_Click(object sender, EventArgs e)
        {
            MainMenuForm viewMainMenuForm = (MainMenuForm)Tag;
            viewMainMenuForm.Show();
            Close();

        }
    }
}
