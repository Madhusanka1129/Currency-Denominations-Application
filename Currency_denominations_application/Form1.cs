using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Currency_denominations_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeButtonHoverEffects();
        }

        private void InitializeButtonHoverEffects()
        {
            // Set initial button style
            processButton.FlatStyle = FlatStyle.Flat;
            processButton.FlatAppearance.BorderSize = 1;
            processButton.BackColor = SystemColors.Control;
            processButton.FlatAppearance.BorderColor = SystemColors.ControlDark;

            // Assign event handlers
            processButton.MouseEnter += processButton_MouseEnter;
            processButton.MouseLeave += processButton_MouseLeave;
        }

        private void processButton_Click(object sender, EventArgs e)
        {
            try
            {
                decimal salesAmount = Convert.ToDecimal(amountTexBox.Text);

                decimal fiveThousend = Math.Floor(salesAmount / 5000);
                decimal balenceOffiveThousend = salesAmount % 5000;

                decimal twoThousend = Math.Floor(balenceOffiveThousend / 2000);
                decimal balenceOfTwoThousend = balenceOffiveThousend % 2000;

                decimal oneThousend = Math.Floor(balenceOfTwoThousend / 1000);
                decimal balenceOfoneThousend = balenceOfTwoThousend % 1000;

                decimal fiveHundred = Math.Floor(balenceOfoneThousend / 500);
                decimal balenceOffiveHundred = balenceOfoneThousend % 500;

                decimal oneHundred = Math.Floor(balenceOffiveHundred / 100);
                decimal balenceOfoneHundred = balenceOffiveHundred % 100;

                decimal fifty = Math.Floor(balenceOfoneHundred / 50);
                decimal balenceOffifty = balenceOfoneHundred % 50;

                decimal twenty = Math.Floor(balenceOffifty / 20);
                decimal balenceOftwenty = balenceOffifty % 20;

                decimal ten = Math.Floor(balenceOftwenty / 10);
                decimal balenceOften = balenceOftwenty % 10;

                decimal coins = balenceOften;

                _5000NotesTexBox.Text = fiveThousend.ToString();
                _2000NotesTexBox.Text = twoThousend.ToString();
                _1000NotesTexBox.Text = oneThousend.ToString();
                _500NotesTexBox.Text = fiveHundred.ToString();
                _100NotesTexBox.Text = oneHundred.ToString();
                _50NotesTexBox.Text = fifty.ToString();
                _20NotesTexBox.Text = twenty.ToString();
                _10NotesTexBox.Text = ten.ToString();
                coinsTexBox.Text = coins.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Calculation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void processButton_MouseEnter(object sender, EventArgs e)
        {
            processButton.BackColor = Color.FromArgb(74, 144, 226); // Nice blue
            processButton.ForeColor = Color.White;
            processButton.FlatAppearance.BorderColor = Color.FromArgb(58, 123, 200);
            processButton.Cursor = Cursors.Hand;
            processButton.Size = new Size(processButton.Width + 2, processButton.Height + 2);
        }

        private void processButton_MouseLeave(object sender, EventArgs e)
        {
            processButton.BackColor = SystemColors.Control;
            processButton.ForeColor = SystemColors.ControlText;
            processButton.FlatAppearance.BorderColor = SystemColors.ControlDark;
            processButton.Cursor = Cursors.Default;
            processButton.Size = new Size(processButton.Width - 2, processButton.Height - 2);
        }

        // Other textbox event handlers remain here
        private void textBox11_TextChanged(object sender, EventArgs e) { }
        private void textBox8_TextChanged(object sender, EventArgs e) { }
        private void textBox9_TextChanged(object sender, EventArgs e) { }
        private void textBox10_TextChanged(object sender, EventArgs e) { }
        private void textBox7_TextChanged(object sender, EventArgs e) { }
    }
}