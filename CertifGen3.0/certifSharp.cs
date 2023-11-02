#define NOTIMPLEMENTED 

using PdfSharp.Pdf;


namespace CertifGen3._0
{
    public partial class certifSharp : Form
    {
        public certifSharp()
        {
            InitializeComponent();
            System.Text.Encoding.RegisterProvider(System.Text.CodePagesEncodingProvider.Instance);

            ////Initializer default
            generer.Enabled = false;
            villeTextBox.Hide();
            ziptextBox.Hide();
            villeLabel.Hide();
            zipLabel.Hide();
            nomMedecinBox.Hide();
            optionnel.Hide();
            nomMed.Hide();

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)

        {
            string dossierEleve = System.Environment.GetEnvironmentVariable("USERPROFILE") + @"\Documents\Certificats\" + nomEleve.Text + @"\";

            if (!Directory.Exists(dossierEleve))
                Directory.CreateDirectory(dossierEleve);



            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.InitialDirectory = dossierEleve;

                saveFileDialog.FileName = "Certificat_" + prenomEleve.Text + "_" + DateTime.Today.Day + "-" + DateTime.Today.Month + "-"
                    + DateTime.Today.Year + "_" + System.Guid.NewGuid().ToString();

                saveFileDialog.AddExtension = true;
                saveFileDialog.DefaultExt = "pdf";
                saveFileDialog.Filter = "Fichiers PDF (*.pdf)|*.pdf";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    PdfDocument doc = new PdfDocument();

                    medadom medadom = new medadom(doc, nomEleve.Text, prenomEleve.Text, dateNaissanceBox.Text, genre.Text, dateSelector.Text, motifsZone.Text);

                    doc.Save(saveFileDialog.FileName);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (typeMenu.Text == "Medadom")
            {
                generer.Text = "Générer";
                generer.Enabled = true;
                villeTextBox.Hide();
                ziptextBox.Hide();
                villeLabel.Hide();
                zipLabel.Hide();
                nomMedecinBox.Hide();
                optionnel.Hide();
                nomMed.Hide();
            }
            else
            {
#if NOTIMPLEMENTED
                generer.Enabled = false;
                generer.Text = "Disponible plus tard";



#else
                generer.Text = "Générer";
                generer.Enabled = true;

                villeTextBox.Show();
                ziptextBox.Show();
                villeLabel.Show();
                zipLabel.Show();
                nomMedecinBox.Show();
                optionnel.Show();
                nomMed.Show();
#endif
            }
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void label6_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prenomEleve_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dateNaissanceBox_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}