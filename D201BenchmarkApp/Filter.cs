// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace D201BenchmarkApp
{
    public class Filter
    {
        /// <summary>
        /// Sort by acsending based on staff name.
        /// </summary>
        /// <param name="cList"></param>
        /// <returns></returns>
        public List<MyClass> SortAZ(List<MyClass> cList)
        {
            cList = cList.OrderBy(x => x.Staff_Name).ToList();

            return cList;
        }


        /// <summary>
        /// Sort by descending based on staff name.
        /// </summary>
        /// <param name="cList"></param>
        /// <returns></returns>
        public List<MyClass> SortZA(List<MyClass> cList)
        {
            cList = (from x in cList
                     orderby x.Staff_Name descending select x).ToList();

            return cList;
        }


        /// <summary>
        /// Search staff based on staff name and ID, if staff name contains inputing data, then return result; 
        /// If inputing ID is equal to staff ID, then return result.
        /// </summary>
        /// <param name="cList"></param>
        /// <param name="term"></param>
        /// <returns></returns>
        public List<MyClass> Search (List<MyClass> cList, string term)
        {
            List<MyClass> results = new List<MyClass>();

            // Search staff by name (case insensitive) and ID.
            foreach (MyClass c in cList)
            {
                if (c.Staff_Name.ToLower().Contains(term.ToLower()) || c.Id.ToString() == term )
                {
                    results.Add(c);
                }
            }

            return results;
        }

    }
}
