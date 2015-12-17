using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_PI
{
    /// <summary>
    /// Form1 Class
    /// </summary>
    public partial class Form1 : Form
    {
        private Validator validator;
        public Controller controller;
        private string fileName = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\PI\LAB_PI\consum.txt";
        private string nameForFirstFile = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\PI\LAB_PI\FirstOutput.txt";
        private string nameForSecondFile = @"C:\Users\Lucian\SkyDrive\Documents\Visual Studio 2013\ANUL II\PI\LAB_PI\SecondOutput.txt";

        /// <summary>
        /// Form Constructor
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            controller = new Controller(fileName, nameForFirstFile, nameForSecondFile);
            validator = new Validator();
        }

        /// <summary>
        /// Load the form with all costumers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            txtTarif.Text = "0.4956";
            lstAbonati.Items.Clear();
            foreach (Abonat ab in controller.costumers())
            {
                lstAbonati.Items.Add(ab.ToString());
            }
        }

        /// <summary>
        /// Generate all costumers and total sum of this month (with specified price)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenereaza_Click(object sender, EventArgs e)
        {
            if (validator.isFloatPositiveNumber(txtTarif.Text))
            {
                float tarif = float.Parse(txtTarif.Text, CultureInfo.InvariantCulture.NumberFormat);
                controller.generateAllCostumersAndTotalSum(tarif);
                MessageBox.Show("Fisierul a fost creat la adresa:" + Environment.NewLine + Environment.NewLine + nameForFirstFile, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Tarif invalid!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Generate a new form and the text will be like a notification file for specified user
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnNotifyForSelectedConsumer_Click(object sender, EventArgs e)
        {
            if (lstAbonati.SelectedIndex == -1) {
                MessageBox.Show("Nici un abonat selectat!", "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string notification = "";
            string info = controller.getCostumerInfo(lstAbonati.Items[lstAbonati.SelectedIndex].ToString().Split(',')[0]);
            if (String.Compare(info, "null") != 0)
            {
                notification = notification + "FURNIZOR: Electrica Furnizare S.A." + Environment.NewLine;
                notification = notification + "CLIENT: " + info.Split(';')[0] + "\n\r______________________________________________________\n\rTip Client: PERSOANA FIZICA\n\r\n\r";
                notification = notification + "Tarif in ziua de facturare: " + txtTarif.Text + " lei/kWh" + "       Cota TVA: 24%\n\r";
                notification = notification + "Index vechi (kWh): " + info.Split(';')[1] + Environment.NewLine;
                notification = notification + "Index nou (kWh): " + info.Split(';')[2] + Environment.NewLine;
                notification = notification + "Total la data de " + System.DateTime.Today.ToShortDateString()+ " (kWh):  " + info.Split(';')[3] + Environment.NewLine;

                int consum = Int32.Parse(info.Split(';')[3]);
                float tarif = float.Parse(txtTarif.Text, CultureInfo.InvariantCulture.NumberFormat);
                notification = notification + "\n\rTOTAL DE PLATA: " + (consum * tarif).ToString("0.00") + " LEI.";
                MessageBox.Show(notification, "INSTIINTARE DE PLATA", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// Generate a new form which contains a table of over consum costumers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnShowUptoMaxConsumer_Click(object sender, EventArgs e)
        {
            if (validator.isNaturalNumber(txtMaxConsum.Text))
            {
                int maxConsum = Int32.Parse(txtMaxConsum.Text);
                SupraAbonatii tabel = new SupraAbonatii(maxConsum, controller);
                tabel.ShowDialog();
                txtMaxConsum.Clear();
            }
            else
            {
                MessageBox.Show("Introduceti un numar natural.", "Eroare", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                txtMaxConsum.Clear();
            }
        }

        /// <summary>
        /// Generate a file with restant costumers
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnGenerateRestantConsumer_Click(object sender, EventArgs e)
        {
            controller.generateAllRestantConsumer();
            MessageBox.Show("Fisierul a fost creat la adresa:" + Environment.NewLine + Environment.NewLine + nameForSecondFile, "", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}