using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextWizard
{
    public partial class TextWizardForm : Form
    {
        public TextWizardForm()
        {
            InitializeComponent();
        }

        private void ConvertString()
        {
            try
            {
                output.Text = Conversion.ConvertString(input.Text, conversion.Text, EncodingSelection.Text);
                if (!string.IsNullOrEmpty(output.Text))
                    Clipboard.SetText(output.Text);
            }
            catch (Exception ex)
            {
                output.Text = "ERROR: " + ex.Message;
            };
        }

        private void inputTextChanged(object sender, EventArgs e)
        {
            ConvertString();
        }

        private void conversionTextChanged(object sender, EventArgs e)
        {
            ConvertString();
        }

        private void TextWizardFormOnLoad(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            Task.Run(() =>
            {
                foreach (EncodingInfo info in Encoding.GetEncodings().OrderBy(m => m.Name))
                    EncodingSelection.DropDownItems.Add(info.Name);
            });

            conversion.Text = "To Base64";
            EncodingSelection.Text = "utf-8";

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
            EncodingSelection.Text = e.ClickedItem.Text;
            ConvertString();
        }

        private void SaveMouseDown(object sender, MouseEventArgs e)
        {
            using (SaveFileDialog dialog = new SaveFileDialog())
            {
                dialog.DefaultExt = "txt";
                dialog.Filter = "Text files(*.txt)|*.txt|All files(*.*)|*.*";

                if (dialog.ShowDialog() == DialogResult.Cancel)
                    return;

                try
                {
                    File.WriteAllText(dialog.FileName, output.Text, Encoding.GetEncoding(EncodingSelection.Text));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Failed to save file!\n" + ex.Message);
                };
            };
        }
    }
}
