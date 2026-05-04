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

            try
            {
                ZbiorDanych zbior = new ZbiorDanych();
                zbior.wczytajDane(filePath);

                CV validation = new CV(countPartions, zbior.LiczbaWierszy);
                var dataIndex = validation.makeCV();

                dataGridView1.Rows.Clear();
                int correctClasificied = 0;
                int allTests = 0;

                Func<ZbiorDanych, int[], (int, double)> metodaPodzialu = null;

                if (partionWay == false)
                {
                    metodaPodzialu = PodzialEntropia;
                }

                foreach (var (trainIndexes, testIndexes) in dataIndex)
                {
                    DrzewoDecyzyjne2.Drzewo.Drzewo drzewo = new DrzewoDecyzyjne2.Drzewo.Drzewo(depth, metodaPodzialu);
                    drzewo.utworzDrzewo(zbior, trainIndexes);

                    foreach (int idx in testIndexes)
                    {
                        allTests++;

                        double[] cechy = new double[zbior.LiczbaCech];
                        for (int c = 0; c < zbior.LiczbaCech; c++)
                        {
                            cechy[c] = zbior[idx, c];
                        }

                        string oczekiwanaKlasa = zbior.pobierzEtykiete(idx);
                        string przewidzianaKlasa = drzewo.Test(cechy);

                        string status = (oczekiwanaKlasa == przewidzianaKlasa) ? "Trafione" : "Pud³o";
                        if (status == "Trafione")
                            correctClasificied++;
                        int rowIndex = dataGridView1.Rows.Add(allTests, cechy[0], cechy[1], cechy[2], cechy[3], oczekiwanaKlasa, przewidzianaKlasa, status);

                        // 5. Kolorowanie wiersza
                        if (status == "Trafione")
                            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.LightGreen;
                        else
                            dataGridView1.Rows[rowIndex].DefaultCellStyle.BackColor = System.Drawing.Color.Salmon;
                    }
                }

                double procentDokladnosci = ((double)correctClasificied / allTests) * 100;
                MessageBox.Show($"Zakoñczono! Dok³adnoœæ: {procentDokladnosci:F2}%\nPoprawnie sklasyfikowano: {correctClasificied} z {allTests} irysów.", "Wyniki Cross-Walidacji", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Coœ posz³o nie tak przy budowie drzewa:\n{ex.Message}", "B³¹d krytyczny", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private double ObliczEntropie(int[] indeksy, ZbiorDanych dane)
        {
            int n = indeksy.Length;
            if (n == 0) return 0.0;

            var licznikiEtykiet = new Dictionary<string, int>();
            foreach (int idx in indeksy)
            {
                string etykieta = dane.pobierzEtykiete(idx);
                if (licznikiEtykiet.ContainsKey(etykieta)) licznikiEtykiet[etykieta]++;
                else licznikiEtykiet[etykieta] = 1;
            }

            double entropia = 0.0;
            foreach (var para in licznikiEtykiet)
            {
                double p = (double)para.Value / n;
                if (p > 0)
                {
                    entropia -= p * Math.Log2(p);
                }
            }
            return entropia;
        }

        private (int cecha, double prog) PodzialEntropia(ZbiorDanych dane, int[] indeksy)
        {
            int najlepszaCecha = -1;
            double najlepszyProg = 0;
            double najmniejszaEntropia = double.MaxValue;

            for (int i = 0; i < dane.LiczbaCech; i++)
            {
                double[] progi = dane.pobierzProgi(i, indeksy);
                foreach (double prog in progi)
                {
                    List<int> lewaPodgrupa = new List<int>();
                    List<int> prawaPodgrupa = new List<int>();

                    foreach (int idx in indeksy)
                    {
                        if (dane[idx, i] <= prog)
                            lewaPodgrupa.Add(idx);
                        else
                            prawaPodgrupa.Add(idx);
                    }

                    if (lewaPodgrupa.Count == 0 || prawaPodgrupa.Count == 0) continue;

                    double nLewa = lewaPodgrupa.Count;
                    double nPrawa = prawaPodgrupa.Count;
                    double nRazem = nLewa + nPrawa;

                    double aktualnaEntropia = (nLewa / nRazem) * ObliczEntropie(lewaPodgrupa.ToArray(), dane) +
                                              (nPrawa / nRazem) * ObliczEntropie(prawaPodgrupa.ToArray(), dane);

                    if (aktualnaEntropia < najmniejszaEntropia)
                    {
                        najmniejszaEntropia = aktualnaEntropia;
                        najlepszaCecha = i;
                        najlepszyProg = prog;
                    }
                }
            }
            return (najlepszaCecha, najlepszyProg);
        }
    }
}
