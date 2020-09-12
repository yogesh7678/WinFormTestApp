using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsTestApp
{
    public partial class FormCalculator : Form
    {
        public FormCalculator()
        {
            InitializeComponent();
            labelCount.Text = $"(Count: {comboBoxSelectHobby.Items.Count})";
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNum.Text != "" && textBoxSecondNum.Text != "")
            {
                int sum = int.Parse(textBoxFirstNum.Text) + int.Parse(textBoxSecondNum.Text);
                textBoxResult.Visible = true;
                textBoxResult.Text = sum.ToString();
            }
            else
            {
                MessageBox.Show("Please enter into the fileds");
            }
            
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNum.Text != "" && textBoxSecondNum.Text != "")
            {
                int sub = int.Parse(textBoxFirstNum.Text) - int.Parse(textBoxSecondNum.Text);
                textBoxResult.Visible = true;
                textBoxResult.Text = sub.ToString();
            }
            else
            {
                MessageBox.Show("Please enter into the fileds");
            }
            
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNum.Text != "" && textBoxSecondNum.Text != "")
            {
                int mul = int.Parse(textBoxFirstNum.Text) * int.Parse(textBoxSecondNum.Text);
                textBoxResult.Visible = true;
                textBoxResult.Text = mul.ToString();
            }
            else
            {
                MessageBox.Show("Please enter into the fileds!");
            }
            
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (textBoxFirstNum.Text != "" && textBoxSecondNum.Text != "")
            {
                int div = int.Parse(textBoxFirstNum.Text) / int.Parse(textBoxSecondNum.Text);
                textBoxResult.Visible = true;
                textBoxResult.Text = div.ToString();
            }
            else
            {
                MessageBox.Show("Please enter into the fileds");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void buttonAddHobby_Click(object sender, EventArgs e)
        {
            comboBoxSelectHobby.Items.Add(textBoxAddHobby.Text);
            textBoxAddHobby.Clear();
            textBoxAddHobby.Focus();
            labelCount.Text = $"(Count: {comboBoxSelectHobby.Items.Count})";
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            comboBoxSelectHobby.Items.Remove(comboBoxSelectHobby.SelectedItem);
            labelCount.Text = $"(Count: {comboBoxSelectHobby.Items.Count})";
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            SecondForm secondForm = new SecondForm();
            secondForm.Show();
        }
    }
}
