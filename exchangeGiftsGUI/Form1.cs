using System;
using System.Collections.Generic;
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
            FamilyParticipatingPeople.CheckBoxes = true;
        }

        private void BowlesButton_Click(object sender, EventArgs e)
        {
            IndividualExchanges.Text = "";
            exchange.Names.Clear();
            IndividualParticipatingPeople.Items.Clear();

            IndividualParticipatingPeople.Items.Add("Derek");
            IndividualParticipatingPeople.Items.Add("Aaron");
            IndividualParticipatingPeople.Items.Add("Brian");
            IndividualParticipatingPeople.Items.Add("Jason");
            IndividualParticipatingPeople.Items.Add("Philip");
            IndividualParticipatingPeople.Items.Add("Corey");
            IndividualParticipatingPeople.Items.Add("Sam");
            IndividualParticipatingPeople.Items.Add("Sarah");
            IndividualParticipatingPeople.Items.Add("Tim");
            IndividualParticipatingPeople.Items.Add("Abe");
            IndividualParticipatingPeople.Items.Add("Rosa");
            IndividualParticipatingPeople.Items.Add("Hannah");

            IndividualLabel.Visible = true;
            IndividualParticipatingPeople.Visible = true;
            IndividualExchangeButton.Visible = true;
            IndividualExchanges.Visible = false;
        }

        private void ThompsonButton_Click(object sender, EventArgs e)
        {
            IndividualExchanges.Visible = false;
            FamilyExchangeButton.Visible = false;
            IndividualExchanges.Text = "";
            FamilyParticipatingPeople.Items.Clear();
        }

        private void IndividualExchangeButton_Click(object sender, EventArgs e)
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
                    IndividualExchanges.Text += String.Format("{0} -> {1}\n", from, to);
                    exchange.Names.Remove(from);
                    toNames.Remove(to);
                }
                else
                    exchange.ShuffleNames();
            }

            IndividualExchanges.Visible = true;
        }

        private void FamilyExchangeButton_Click(object sender, EventArgs e)
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
                    FamilyExchanges.Text += String.Format("{0} -> {1}\n", from, to);
                    exchange.Names.Remove(from);
                    toNames.Remove(to);
                }
                else
                    exchange.ShuffleNames();
            }

            FamilyExchanges.Visible = true;
        }

        private void ParticipatingPeople_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                exchange.Names.Add(e.Item.Text);
        }

        private void IndividualParticipatingPeople_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            if (e.Item.Checked)
                exchange.Names.Add(e.Item.Text);
        }
    }
}
