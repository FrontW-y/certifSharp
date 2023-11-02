using PdfSharp.Drawing;
using PdfSharp.Drawing.Layout;
using PdfSharp.Pdf;
using System.Text;

namespace CertifGen3._0
{
    internal class medadom
    {

        private List<string> listePrenom = new List<string>()
        {
            "Jean", "Marie","Pierre",  "Nicolas", "François","Julie","Claire","Sophie","Lina","Élise","Diego",
            "Tiago","Camille","Mohammed","Ahmed","Fatima","Salma","Youssef  ","Ali","Nadia","Zahra",
            "Sara","Hamza","Lyna","Sadam","Li","Wang","Zhang","Liu","Chen","Yang"
        };

        private List<string> listNom = new List<string>()
        {
            "MARTIN", "BERNARD", "DUBOIS", "THOMAS", "ROBERT",
            "RICHARD", "PETIT", "DURAND", "LEROY", "MOREAU",
            "HASSAN", "ALI", "MAHMOUD", "ABDULLAH", "HUSSEIN",
            "SAID", "OMAR", "YOUSEF", "IBRAHIM", "AHMED",
            "LI", "WANG", "ZHANG", "LIU", "CHEN", "YANG",
            "HUANG", "ZHAO", "WU", "ZHOU"
        };



        private List<string> villes = new List<string>()
        {
            "Paris, 75000","Marseille, 13000","Lyon, 69000","Toulouse, 31000",
            "Nice, 06000","Nantes, 44000","Strasbourg, 67000","Montpellier, 34000",
            "Bordeaux, 33000","Lille, 59000","Rennes, 35000",
            "Reims, 51100","Le Havre, 76600","Saint-Etienne, 42000",
            "Toulon, 83000","Grenoble, 38000","Dijon, 21000","Angers, 49000",
            "Nîmes, 30000","Saint-Denis, 97400","Amiens, 80000",
            "Brest, 29200","Carcassonne, 11000","Colmar, 68000",
            "Douai, 59500","Fréjus, 83600","La Roche-sur-Yon, 85000",
            "Le Puy-en-Velay, 43000","Limoges, 87000","Manosque, 04100","Mulhouse, 68100","Niort, 79000",
            "Perpignan, 66000",
            "Poitiers, 86000", "Quimper, 29000","Roanne, 42300","Saint-Brieuc, 22000",
            "Tarbes, 65000","Valence, 26000","Vannes, 56000"
        };

        private List<string> rue = new List<string>()
        {
            "rue de la Paix,", "rue de Rivoli,", "avenue des Champs-Élysées,",
            "boulevard Saint-Germain,", "rue du Faubourg Saint-Honoré,", "rue Saint-Antoine,",
            "place de la Concorde,", "rue de la Roquette,", "rue de Charonne,",
            "boulevard de la Villette,", "rue de la Pompe,", "rue des Martyrs,",
            "rue Montmartre,", "rue Saint-Denis,", "rue de la Huchette,",
            "rue des Petits Champs,", "rue de la Grange aux Belles,", "rue des Francs Bourgeois,",
            "rue du Temple,", "rue de la Folie Méricourt,", "rue de Belleville,",
            "rue de la Butte aux Cailles,", "rue de la Tombe-Issoire,", "rue des Rosiers,",
            "rue du Cherche-Midi,", "rue du Bac,", "rue de Passy,",
            "rue de Vaugirard,", "rue de la Convention,", "rue de Sèvres,",
            "rue du Poteau,", "rue de la Cour des Noues,", "rue de la République,",
            "rue Saint-Maur,", "rue des Pyrénées,", "rue de la Mare,",
            "rue de la Fontaine au Roi,", "rue du Marché Saint-Honoré,", "rue du Louvre,",
            "rue de la Rochechouart,", "rue de la Grange Batelière,", "rue de Turbigo,",
            "rue des Archives,", "rue du Regard,", "rue du Faubourg Poissonnière,",
            "rue de la Tour,"
        };


        private string nomDoc;
        private string numeroFiness;
        private string numeroTel;
        private string adresse;



        private const float x_title = 85f;
        private const float y_title = 49f;

        private const float x_logo = 440f;
        private const float y_logo = 18f;
        private const float w_logo = 144;
        private const float h_logo = 46;

        private const float x_drNom = 35f;
        private const float y_drNom = 106f;

        private const float x_dateCreation = 393;
        private const float y_dateCreation = 128;

        private const float x_medecinType = 35f;
        private const float y_medecinType = 142f;

        private const float x_nomCentre = 35f;
        private const float y_nomCentre = 182f;

        private const float x_adresse = 35f;
        private const float y_adresse = 200f;

        private const float x_finess = 35f;
        private const float y_finess = 216f;

        private const float x_tel = 35f;
        private const float y_tel = 232f;

        private const float x_solicitation = 30f;
        private const float y_solicitation = 301f;

        private const float x_nomPatient = 130f;
        private const float y_nomPatient = 335f;

        private const float x_interogatoire = 20f;
        private const float y_interogatoire = 372f;
        private const float y_interogatoireDeux = 392f;


        private const float x_motifs = 53f;
        private const float y_motifs = 450f;

        private const float x_conseil = 35f;
        private const float y_conseil = 640f;

        private const float x_nomSign = 35f;
        private const float y_nomSign = 710;




        private const string titre = "Compte rendu de téléconsultation";
        private const string nomDomaine = "Maison médikal";

        private const string solicitation = "J'ai été sollicité(e) ce jour, dans le cadre du service MEDADOM, par le patient :";
        private const string interogatoirePartUn = "L’interrogatoire lors de la téléconsultation, en tenant compte de l'absence de possibilité,";
        private const string interogatoirePartDeux = "d'examen clinique, permet de noter : ";
        private const string conseil = "Il est conseillé de solliciter un avis complémentaire pour réevaluation si le problème devait\n persister. En cas d'aggravation ressentie, consultez un service d'urgence.";
        private const string medecinType = "Médecin Généraliste";


        private string GenererTelephone()
        {
            Random rd = new Random();
            StringBuilder numero = new StringBuilder("+33 9");

            for (int i = 0; i < 4; i++)
            {
                numero.Append(" ");
                numero.Append(rd.Next(0, 10));
                numero.Append(rd.Next(0, 10));
            }

            return numero.ToString();
        }

        private void GenererAdress()
        {

            Random random = new Random();

            string tempAdresse = villes[random.Next(villes.Count())];
            int tempNumeroRue = random.Next(1, 150);
            string tempRue = rue[random.Next(rue.Count())];


            var departement = tempAdresse.Split(",")[1].Trim().Substring(0, 2);
            var numeroDepartement = int.Parse(departement).ToString();
            var numerosAleatoires = new int[7];

            for (int i = 0; i < 7; i++)
            {
                numerosAleatoires[i] = random.Next(0, 10);
            }

            var result = numeroDepartement + string.Join("", numerosAleatoires.Select(n => n.ToString()));

            numeroFiness = result;
            adresse = tempNumeroRue + " " + " " + tempRue + " " + tempAdresse;
        }



        public medadom(PdfDocument doc, string nom, string prenom, string dateNaissance, string genre, string dateAbs, string motifs)
        {

            PdfPage page = doc.AddPage();
            XGraphics gfx = XGraphics.FromPdfPage(page);
            XFont title_font = new XFont("ArialMT", 18);
            XFont global_font = new XFont("ArialMT", 13);
            XImage logo = XImage.FromFile("./ressource/logo.png");
            XTextFormatter tf = new XTextFormatter(gfx);
            XPen pen = new XPen(XColors.Black, 1);
            Random rand = new Random();


            XPoint[] points = new XPoint[]
            {
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Point de départ
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Premier point de contrôle du premier segment
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Deuxième point de contrôle du premier segment
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Point final du premier segment
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Point de départ du deuxième segment
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Premier point de contrôle du deuxième segment
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100)),   // Deuxième point de contrôle du deuxième segment
                new XPoint(rand.Next(50, 100), page.Height - rand.Next(50, 100))    // Point final du deuxième segment
            };


            XRect rect = new XRect(x_motifs, y_motifs, page.Width, page.Height);

            GenererAdress();

            nomDoc = "Dr. " + listePrenom[rand.Next(listePrenom.Count())] + " " + listNom[rand.Next(listNom.Count())];

            gfx.DrawImage(logo, new XRect(x_logo, y_logo, w_logo, h_logo));

            gfx.DrawString(titre, title_font, XBrushes.Black, new XRect(x_title, y_title, page.Width, 0), XStringFormats.Default);

            gfx.DrawString(nomDomaine, global_font, XBrushes.Black, new XRect(x_nomCentre, y_nomCentre, page.Width, 0), XStringFormats.Default);

            gfx.DrawString(nomDoc, global_font, XBrushes.Black, new XRect(x_drNom, y_drNom, page.Width, 0), XStringFormats.Default);
            gfx.DrawString(GenererTelephone(), global_font, XBrushes.Black, new XRect(x_tel, y_tel, page.Width, 0), XStringFormats.Default);

            gfx.DrawString(adresse, global_font, XBrushes.Black, new XRect(x_adresse, y_adresse, page.Width, 0), XStringFormats.Default);

            gfx.DrawString("No Finess : " + numeroFiness, global_font, XBrushes.Black, new XRect(x_finess, y_finess, page.Width, 0), XStringFormats.Default);


            gfx.DrawString(medecinType, global_font, XBrushes.Black, new XRect(x_medecinType, y_medecinType, page.Width, 0), XStringFormats.Default);
            gfx.DrawString(dateAbs, global_font, XBrushes.Black, new XRect(x_dateCreation, y_dateCreation, page.Width, 0), XStringFormats.Default);

            gfx.DrawString(solicitation, global_font, XBrushes.Black, new XRect(x_solicitation, y_solicitation, page.Width, 0), XStringFormats.Default);
            gfx.DrawString(nom + " " + prenom + " né(e) le : " + dateNaissance, global_font, XBrushes.Black, new XRect(x_nomPatient, y_nomPatient, page.Width, 0), XStringFormats.Default);


            gfx.DrawString(interogatoirePartUn, global_font, XBrushes.Black, new XRect(x_interogatoire, y_interogatoire, page.Width, 0), XStringFormats.Default);
            gfx.DrawString(interogatoirePartDeux, global_font, XBrushes.Black, new XRect(x_interogatoire, y_interogatoireDeux, page.Width, 0), XStringFormats.Center);

            /*** Dispose le block de motifs ***/

            tf.DrawString(motifs, global_font, XBrushes.Black, rect, XStringFormats.TopLeft);

            /*** Dispose le block de conseil qui sert de epilogue ***/
            tf.DrawString(conseil, global_font, XBrushes.Black, new XRect(x_conseil, y_conseil, page.Width, page.Height), XStringFormats.TopLeft);

            /*** Dispose le block du nom du medecin ***/
            tf.DrawString(nomDoc, global_font, XBrushes.Black, new XRect(x_nomSign, y_nomSign, page.Width, 0), XStringFormats.TopLeft);

            gfx.DrawCurve(pen, points, 2);


        }
    }
}
