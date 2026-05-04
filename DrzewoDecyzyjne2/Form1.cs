using System.Windows.Forms;

namespace DrzewoDecyzyjne2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            DialogResult res = openFileDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                textBoxLoc.Text = openFileDialog1.FileName;
                labelOpenFile.Text = "Za³adowany plik";
            }
        }

        private void textBoxLoc_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;
            if (textBox != null)
            {
                int textWidth = TextRenderer.MeasureText(textBox.Text, textBox.Font).Width;
                textBox.Width = textWidth + 10;
            }
        }
    }
}
