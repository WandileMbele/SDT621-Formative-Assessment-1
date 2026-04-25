using System;
using System.Windows.Forms;

namespace ProgrammingLanguageManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string language = txtLanguage.Text.Trim();

            if (string.IsNullOrEmpty(language))
            {
                MessageBox.Show("Please enter a programming language.");
                return;
            }

            foreach (string item in lstLanguages.Items)
            {
                if (item.Equals(language, StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("This language already exists in the list.");
                    return;
                }
            }

            lstLanguages.Items.Add(language);
            lblDateTime.Text = "Added on: " + DateTime.Now.ToString();
            txtLanguage.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please select a language to remove.");
                return;
            }

            lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            lblDateTime.Text = "Removed on: " + DateTime.Now.ToString();
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
