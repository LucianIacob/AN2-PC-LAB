using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_PI
{
    /// <summary>
    /// Abonat Class
    /// </summary>
    public class Abonat
    {
        private string _name;
        private string _address;
        private string _status_account;
        private int _oldConsum;
        private int _newConsum;

        public string Name
        {
            get
            {
                return _name;
            }
        }

        public string Address
        {
            get
            {
                return _address;
            }
        }

        public string Status_account
        {
            get
            {
                return _status_account;
            }
        }

        public int OldConsum
        {
            get
            {
                return _oldConsum;
            }
        }

        public int NewConsum
        {
            get
            {
                return _newConsum;
            }
        }

        /// <summary>
        /// Abonat Constructor
        /// </summary>
        /// <param name="n"></param>
        /// <param name="add"></param>
        /// <param name="status"></param>
        /// <param name="old"></param>
        /// <param name="newC"></param>
        public Abonat(string n, string add, string status, int old, int newC)
        {
            _name = n;
            _address = add;
            _status_account = status;
            _oldConsum = old;
            _newConsum = newC;
        }

        /// <summary>
        /// Abonat to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Name + ", " + Address;
        }

        /// <summary>
        /// Verify if a costumer passed normal consum
        /// </summary>
        /// <param name="max"></param>
        /// <returns></returns>
        public bool upToMaxConsum(int max)
        {
            if (NewConsum - OldConsum <= max)
                return false;
            return true;
        }

        /// <summary>
        /// Verify if a costumer is restant
        /// </summary>
        /// <returns></returns>
        public bool isRestant()
        {
            if (String.Compare(Status_account, "t") == 0)
                return true;
            return false;
        }
    }
}