using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exchangeGiftsGUI
{
    public partial class ExchangeForm : Form
    {
        public ExchangeForm()
        {
            InitializeComponent();
        }

        private void ExchangeForm_Load(object sender, EventArgs e)
        {

        }

        private void BowlesButton_Click(object sender, EventArgs e)
        {
            EntryLabel.Visible = true;
            EntryTextBox.Visible = true;
            EnterButton.Visible = true;

            FamilyEnterLabel.Visible = false;
            FamilyEntryTextBox.Visible = false;
            FamilyEnterButton.Visible = false;
            FamilyExchangeTextBox.Visible = false;
            FamilyExchangeButton.Visible = false;
            Exchanges.Visible = false;
        }

        private void ThompsonButton_Click(object sender, EventArgs e)
        {
            EntryLabel.Visible = true;
            EntryTextBox.Visible = true;
            EnterButton.Visible = true;
            FamilyEnterLabel.Visible = true;
            FamilyEntryTextBox.Visible = true;
            FamilyEnterButton.Visible = true;
        }
    }
}
