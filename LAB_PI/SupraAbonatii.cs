using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB_PI
{
    /// <summary>
    /// SupraAbonatii Class
    /// </summary>
    public partial class SupraAbonatii : Form
    {
        private int maxConsum;
        private Controller controller;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="max"></param>
        /// <param name="con"></param>
        public SupraAbonatii(int max, Controller con)
        {
            InitializeComponent();
            controller = con;
            maxConsum = max;
        }

        /// <summary>
        /// Form Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SupraAbonatii_Load(object sender, EventArgs e)
        {
            loadSupraAbonatii();
        }

        /// <summary>
        /// The method which shows in a table all over consumed costumers
        /// </summary>
        private void loadSupraAbonatii()
        {
            listView1.View = View.Details;
            listView1.GridLines = true;
            listView1.FullRowSelect = true;

            List<Abonat> supraAbonati = controller.supraAbonati(maxConsum);
            listView1.Sort();
            ListViewItem itm;
            string[] arr = new string[6];
            listView1.Items.Clear();

            foreach (Abonat ab in supraAbonati)
            {
                int dif = ab.NewConsum - ab.OldConsum;
                arr[0] = ab.Name;
                arr[1] = ab.Address;
                arr[2] = maxConsum.ToString(); 
                arr[3] = dif.ToString();
                arr[4] = (dif - maxConsum).ToString();
                itm = new ListViewItem(arr);
                itm.BackColor = Color.LightGray;
                listView1.Items.Add(itm);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}