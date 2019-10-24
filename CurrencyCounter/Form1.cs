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
                cbFirst.Items.Add(value.Name);
                cbSecond.Items.Add(value.Name);
            }

        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (Validate())
            {
                Bill first = new Bill(double.Parse(tbFirstMain.Text), double.Parse("0." + tbFirstCoins.Text));
                Bill second = new Bill(double.Parse(tbSecondMain.Text), double.Parse("0."+tbSecondCoins.Text));

                Bill result = null;
                if (cbFirst.SelectedItem != cbSecond.SelectedItem)
                {
                    first = Logic.ToDollar(first, cbFirst.Text);
                    second = Logic.ToDollar(second, cbSecond.Text);

                    if (cbOperation.SelectedItem == "+")
                    {
                        result = first + second;
                    }
                    else
                    {
                        result = first - second;
                    }

                    result = Logic.FromDollar(result, cbResultCurrency.Text);
                }
                else
                {
                    if (cbOperation.SelectedItem == "+")
                    {
                        result = first + second;
                    }
                    else
                    {
                        result = first - second;
                    }
                }

                lblResult.Text = result.ToString() + $" {cbResultCurrency.Text}";
            }
        }

        private bool Validate()
        {
            bool isCorrect = true;
            if (cbResultCurrency.SelectedItem == null)
            {
                isCorrect = false;
                MessageBox.Show("You should select the type of result currency.", "Error!");
            }

            if (cbOperation.SelectedItem == null)
            {
                isCorrect = false;
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

            return isCorrect;
        }

        private void CbResultCurrency_Click(object sender, EventArgs e)
        {
            cbResultCurrency.Items.Clear();
            if (cbResultCurrency.Items.Count == 0)
            {
                if (cbFirst.SelectedItem != null && cbSecond.SelectedItem != null)
                {
                    if (cbFirst.SelectedItem == cbSecond.SelectedItem && cbSecond.SelectedItem != null)
                    {
                        cbResultCurrency.Items.Add(cbFirst.SelectedItem);
                    }
                    else
                    {
                        cbResultCurrency.Items.Add(cbFirst.SelectedItem);
                        cbResultCurrency.Items.Add(cbSecond.SelectedItem);
                    }
                }
                else
                {
                    MessageBox.Show("You should select the type of currencies.", "Error!");
                }
            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
