using System;
using System.Windows.Forms;

namespace CurrencyCounter
{
    public partial class Form1 : Form
    {
        public BL Logic { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BL bl = new BL();
            Logic = bl;
            foreach (var value in BL.exchange)
            {
                cbFirst.Items.Add(value.Value);
                cbSecond.Items.Add(value.Value);
            }

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            Validate();

            Bill first = new Bill(int.Parse(tbFirstMain.Text),int.Parse(tbFirstCoins.Text));
            Bill second = new Bill(int.Parse(tbSecondMain.Text), int.Parse(tbSecondCoins.Text));

            first = Logic.ToDollar(first, cbFirst.Text);
            second = Logic.ToDollar(second, cbSecond.Text);
            Bill result = null;

            if (cbOperation.SelectedItem == "+")
            {
                result = first + second;
            }
            else
            {
                result = first - second;
            }

            result = Logic.FromDollar(result, cbResultCurrency.Text);
            lblResult.Text = result.ToString() + $" {cbResultCurrency.Text}";
        }

        private void Validate()
        {
            if (cbResultCurrency.SelectedItem == null)
            {
                MessageBox.Show("You should select the type of result currency.", "Error!");
            }

            if (cbOperation.SelectedItem == null)
            {
                MessageBox.Show("You should select the operation.", "Error!");
            }

            if (tbFirstMain.Text == "")
            {
                tbFirstMain.Text = "0";
            }

            if (tbFirstCoins.Text == "")
            {
                tbFirstCoins.Text = "0";
            }

            if (tbSecondMain.Text == "")
            {
                tbSecondMain.Text = "0";
            }

            if (tbSecondCoins.Text == "")
            {
                tbSecondCoins.Text = "0";
            }
        }

        private void CbResultCurrency_Click(object sender, EventArgs e)
        {
            if (cbFirst.SelectedItem != null && cbSecond.SelectedItem != null)
            {
                cbResultCurrency.Items.Add(cbFirst.SelectedItem);
                cbResultCurrency.Items.Add(cbSecond.SelectedItem);
            }
            else if (cbFirst.SelectedItem == null || cbSecond.SelectedItem == null)
            {
                MessageBox.Show("You should select the type of currencies.", "Error!");
            }
            else if (cbFirst.SelectedItem == cbSecond.SelectedItem)
            {
                cbResultCurrency.Items.Add(cbFirst.SelectedItem);
            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
