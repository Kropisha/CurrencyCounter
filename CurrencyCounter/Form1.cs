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
            if (Validate())
            {
                Bill first = new Bill(int.Parse(tbFirstMain.Text), double.Parse(tbFirstCoins.Text)*0.01);
                Bill second = new Bill(int.Parse(tbSecondMain.Text), double.Parse(tbSecondCoins.Text)*0.01);

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
                tbFirstMain.Text = "0.0";
            }

            if (tbFirstCoins.Text == "")
            {
                tbFirstCoins.Text = "0.0";
            }

            if (tbSecondMain.Text == "")
            {
                tbSecondMain.Text = "0.0";
            }

            if (tbSecondCoins.Text == "")
            {
                tbSecondCoins.Text = "0.0";
            }

            return isCorrect;
        }

        public ComboBox.ObjectCollection Previous { get; set; }

        private void CbResultCurrency_Click(object sender, EventArgs e)
        {
            ComboBox.ObjectCollection current = null;
            if (cbResultCurrency.Items.Count != 0)
            {
                current.Add(cbFirst.SelectedItem);
                current.Add(cbSecond.SelectedItem);
            }
            if (cbResultCurrency.Items.Count == 0 || current!=Previous)
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

                Previous = cbResultCurrency.Items;
            }
        }

        private void BtnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
