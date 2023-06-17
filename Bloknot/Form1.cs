using System.Drawing.Imaging;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bloknot
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ñòåğåòüÂñ¸ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
        }

        private void âûõîäToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void îòêğûòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MenuFileOpen();

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ñîõğàíèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Text Document  | | All Files (*.*)|*.*";
            save.OverwritePrompt = true;
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.RichText);
                }
                catch (System.ArgumentException ex)
                {
                    richTextBox1.SaveFile(openFileDialog1.FileName, RichTextBoxStreamType.PlainText);
                }
                this.Text = "Ôàéë[" + openFileDialog1.FileName + "]";

            }
        }

        private void êîïèğîâàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox1.Text);
        }

        private void âûğåçàòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectedText != "")
                // Cut the selected text in the control and paste it into the Clipboard.
                richTextBox1.Cut();
        }

        private void âñòàâèòüToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void îòìåíàToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}