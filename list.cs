using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginAndSignUp
{
    public class list
    {
        private static list instance;
        public static list Instance
        {

            get
            {
                if (instance == null)
                    instance = new list();
                return instance;
            }
            set => instance = value;
        }
         List<employer> listemloy;

        public List<employer> ListEmloy { get=>listemloy; set=>listemloy = value; }

        private list()
        {
            listemloy = new List<employer>();

            listemloy.Add(new employer("sp01", "2", "3", "4", "5", "6", "7"));
            listemloy.Add(new employer("1", "2", "3", "4", "5", "6", "7"));

        }
        
    }
}
 