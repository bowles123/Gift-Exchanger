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
        private Exchange exchange;

        public ExchangeForm()
        {
            InitializeComponent();
        }

        private void ExchangeForm_Load(object sender, EventArgs e)
        {
            exchange = new Exchange();
        }

        private void BowlesButton_Click(object sender, EventArgs e)
        {
            EntryLabel.Visible = true;
            EntryTextBox.Visible = true;
            EnterButton.Visible = true;
            Exchanges.Text = "";
            FamilyExchangeTextBox.Text = "";

            ExchangeLabel.Visible = false;
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

            FamilyExchangeTextBox.Visible = false;
            FamilyExchangeButton.Visible = false;
            Exchanges.Visible = false;
            ExchangeLabel.Visible = false;
            Exchanges.Text = "";
            FamilyExchangeTextBox.Text = "";
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            ExchangeLabel.Visible = true;

            if (EntryTextBox.Text != "")
            {
                exchange.Names.Add(EntryTextBox.Text);
            }

            EntryTextBox.Text = "";
        }

        private void FamilyEnterButton_Click(object sender, EventArgs e)
        {
            FamilyExchangeButton.Visible = true;
        }

        private void ExchangeLabel_Click(object sender, EventArgs e)
        {
            List<string> toNames = new List<string>(exchange.Names);
            string from, to;

            exchange.ShuffleNames();
            while (exchange.Names.Count > 0)
            {
                from = exchange.Names[0];
                to = toNames[0];

                if (exchange.ExchangeGift(from, to))
                {
                    Exchanges.Text += String.Format("{0} -> {1}\n", from, to);
                    exchange.Names.Remove(from);
                    toNames.Remove(to);
                }
                else
                    exchange.ShuffleNames();
            }

            Exchanges.Visible = true;
        }

        private void FamilyExchangeButton_Click(object sender, EventArgs e)
        {
            FamilyExchangeTextBox.Visible = true;
        }

        private void EntryTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EnterButton_Click(this, new EventArgs());
        }
    }
}
