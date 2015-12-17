using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_PI
{
    /// <summary>
    /// Repository Class
    /// </summary>
    class Repository
    {
        public List<Abonat> Costumers;
        private string nameForFirstFile, nameForSecondFile;

        /// <summary>
        /// Repository constructor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Repository(string a, string b)
        {
            Costumers = new List<Abonat>();
            this.nameForFirstFile = a;
            this.nameForSecondFile = b;
        }

        /// <summary>
        /// Add a costumer
        /// </summary>
        /// <param name="ab"></param>
        public void addAbonat(Abonat ab)
        {
            Costumers.Add(ab);
        }

        /// <summary>
        /// Returns converted list in array
        /// </summary>
        /// <returns></returns>
        public Abonat[] toArray()
        {
            return Costumers.ToArray();
        }

        /// <summary>
        /// Return all costumer info
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string getCostumerInfo(string name)
        {
            foreach (Abonat ab in Costumers)
            {
                if (ab.Name == name)
                {
                    int consum = ab.NewConsum - ab.OldConsum;
                    return ab.ToString() + ";" + ab.OldConsum + ";" + ab.NewConsum + ";" + consum.ToString();
                }
            }
            return "null";
        }

        /// <summary>
        /// Generate all costumers and total sum of this month (with specified price)
        /// </summary>
        /// <param name="tarif"></param>
        public void generateAllCostumersAndTotalSum(float tarif)
        {
            float totalSum = 0;
            string line = "";

            foreach (Abonat abonat in Costumers)
            {
                int totalKWHforCostumer = abonat.NewConsum - abonat.OldConsum;
                float totalSumforCostumer = totalKWHforCostumer * tarif;
                totalSum = totalSum + totalSumforCostumer;
                line = line + abonat.ToString() + " | De plata: " + totalSumforCostumer.ToString() + " lei. " + Environment.NewLine;
            }
            line = line + "-----------------------------------------------------------" + Environment.NewLine;
            line = line + "Total de plata pentru aceasta luna: " + totalSum.ToString() + " lei";

            File.WriteAllText(nameForFirstFile, line);
        }

        /// <summary>
        /// Function generate into a text file all restant consumers
        /// </summary>
        public void generateAllRestantConsumers()
        {
            string line = "ABONATII RESTANTI AI SISTEMULUI DE ENERGIE ELECTRICA" + Environment.NewLine + Environment.NewLine;

            foreach (Abonat abonat in Costumers)
                if (abonat.isRestant())
                    line = line + abonat.ToString() + Environment.NewLine;

            File.WriteAllText(nameForSecondFile, line);
        }
    }
}