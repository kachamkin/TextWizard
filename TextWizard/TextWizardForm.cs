using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace TextWizard
{
    public partial class TextWizardForm : Form
    {
        private string encodingName;
        public TextWizardForm()
        {
            InitializeComponent();
        }

        private void inputTextChanged(object sender, EventArgs e)
        {
            ConvertString();
        }

        private void ConvertString()
        {
            try
            {
                output.Text = Conversion.ConvertString(input.Text, conversion.Text, encodingName);
                if (!string.IsNullOrEmpty(output.Text))
                    Clipboard.SetText(output.Text);
            }
            catch (Exception ex)
            {
                output.Text = "ERROR: " + ex.Message;
            };
        }

        private void conversionTextChanged(object sender, EventArgs e)
        {
            ConvertString();
        }

        private void TextWizardFormOnLoad(object sender, EventArgs e)
        {
            conversion.Text = "To Base64";

            foreach (EncodingInfo info in Encoding.GetEncodings().Cast<EncodingInfo>().OrderBy(m => m.Name))
                EncodingSelection.DropDownItems.Add(info.Name);

            encodingName = "utf-8";
            EncodingSelection.Text = encodingName;

            if (Clipboard.ContainsText())
            {
                input.Text = Clipboard.GetText();
                ConvertString();
            };
        }

        private void InvertMouseDown(object sender, MouseEventArgs e)
        {
            input.Text = output.Text;
            ConvertString();
        }

        private void EncodingSelected(object sender, ToolStripItemClickedEventArgs e)
        {
            encodingName = e.ClickedItem.Text;
            EncodingSelection.Text = encodingName;
            ConvertString();
        }

        private void SaveMouseDown(object sender, MouseEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.DefaultExt = "txt";
            dialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;

            try
            {
                File.WriteAllText(dialog.FileName, output.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to save file!\n" + ex.Message);
            };
        }
    }
}
