using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExternalUtils;

namespace Encoder
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            EncodeButton.Checked = true;
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(KeyTextBox.TextLength == 0 && ReferenceTextBox.TextLength == 0)
                {
                    MessageBox.Show("Вы забыли ввести текст и ключ :(", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (KeyTextBox.TextLength == 0)
                {
                    MessageBox.Show("Вы забыли ввести ключ :(", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (ReferenceTextBox.TextLength == 0)
                {
                    MessageBox.Show("Вы забыли ввести текст :(", "Упс!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                string resultText = "";
                if (EncodeButton.Checked == true)
                {
                    Debug.Print(ReferenceTextBox.Text + " " + KeyTextBox.Text);
                    resultText = StringCipher.Encrypt(ReferenceTextBox.Text, KeyTextBox.Text);
                }
                else
                {
                    Debug.Print(ReferenceTextBox.Text + " " + KeyTextBox.Text);
                    resultText = StringCipher.Decrypt(ReferenceTextBox.Text, KeyTextBox.Text);
                }
                ResultTextBox.Text = resultText;
                Debug.Print(resultText);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ResultTextBox.Text = "";
            ReferenceTextBox.Text = "";
        }
    }
}
