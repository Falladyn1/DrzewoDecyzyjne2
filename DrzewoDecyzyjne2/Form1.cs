using DrzewoDecyzyjne2;
using System.Windows.Forms;

namespace DrzewoDecyzyjne2
{
    public partial class Form1 : Form
    {
        private string filePath = string.Empty;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            DialogResult res = openFileDialog1.ShowDialog();
            filePath = openFileDialog1.FileName;

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

        private void btnBuildTree_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                MessageBox.Show("Najpierw wczytaj plik z danymi", "Brak pliku", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int countPartions = (int)numericUpDownPartion.Value;
            int depth = (int)numericUpDownDepth.Value;
            bool partionWay = radioBtnGini.Checked;

            ZbiorDanych zbior = new ZbiorDanych();
            zbior.wczytajDane(filePath);


        }
    }
}
