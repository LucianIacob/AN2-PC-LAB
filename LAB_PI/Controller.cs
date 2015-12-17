using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_PI
{
    /// <summary>
    /// Controller class
    /// </summary>
    public class Controller
    {
        private string fileName, nameForFirstFile, nameForSecondFile;
        private Repository repository;

        /// <summary>
        /// Constructor of the controller
        /// </summary>
        /// <param name="file"></param>
        /// <param name="a"></param>
        /// <param name="b"></param>
        public Controller(string file, string a, string b)
        {
            this.fileName = file;
            this.nameForFirstFile = a;
            this.nameForSecondFile = b;
            repository = new Repository(nameForFirstFile, nameForSecondFile);
            readFromFile();
        }

        /// <summary>
        /// Read all costumers (from file)
        /// </summary>
        private void readFromFile()
        {
            int oldConsum = 0, newConsum = 0;
            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] info = line.Split(',');
                try
                {
                    oldConsum = Int32.Parse(info[3]);
                    newConsum = Int32.Parse(info[4]);
                }
                catch (Exception ex)
                {
                    Console.Write(ex.Message);
                }
                Abonat ab = new Abonat(info[0], info[1], info[2], oldConsum, newConsum);
                repository.addAbonat(ab);
            }
        }

        /// <summary>
        /// Return an array with all costumers
        /// </summary>
        /// <returns></returns>
        public Abonat[] costumers()
        {
            return repository.toArray();
        }

        /// <summary>
        /// Return the costumer info
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public string getCostumerInfo(string name)
        {
            return repository.getCostumerInfo(name);
        }

        /// <summary>
        /// Returns costumers that exceeded the maximum consumption
        /// </summary>
        /// <param name="maxConsum"></param>
        /// <returns></returns>
        public List<Abonat> supraAbonati(int maxConsum)
        {
            List<Abonat> supraAbonati = new List<Abonat>();
            foreach (Abonat abonat in repository.toArray())
            {
                if (abonat.upToMaxConsum(maxConsum) == true)
                    supraAbonati.Add(abonat);
            }
            return supraAbonati;
        }

        /// <summary>
        /// Generate all costumers and total sum of this month (with specified price)
        /// </summary>
        /// <param name="tarif"></param>
        public void generateAllCostumersAndTotalSum(float tarif)
        {
            repository.generateAllCostumersAndTotalSum(tarif);
        }

        /// <summary>
        /// Function generate into a text file all restant consumers
        /// </summary>
        public void generateAllRestantConsumer()
        {
            repository.generateAllRestantConsumers();
        }
    }
}