// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace D201BenchmarkApp
{
    public class FileManager
    {
        /// <summary>
        /// Load the staff in Staff.txt.
        /// </summary>
        /// <returns></returns>
        public List<MyClass> LoadCreatures()
        {
            try
            {
                // Read the document of Staff.txt, add all data to creaturelist.
                List<MyClass> creatureList = new List<MyClass>();
                var strs= File.ReadAllLines("Staff.txt");
                foreach (var item in strs)
                {
                    var s = item.Replace("/r/n", "");
                    string[] values = s.Split(',');
                    MyClass c = new MyClass();
                    c.Id = int.Parse(values[0]);
                    c.Staff_Name = values[1];
                    c.Birthday = values[2];
                    c.Email = values[3];
                    c.Salary = int.Parse(values[4]);
                    creatureList.Add(c);
                }               

                return creatureList;
            }

            catch (Exception )
            {
                return null;
            }
        }

        /// <summary>
        /// Save the selected staff information as a txt document.
        /// </summary>
        /// <param name="c"></param>
        /// <param name="fileName"></param>
        /// <returns></returns>
        public bool SaveCreature(MyClass c, string fileName)
        {
            try
            {
                //Use streamwriter to write staff information as a new document.
                StreamWriter sw = new StreamWriter(fileName);
                sw.WriteLine("STAFF DETAILS");
                sw.WriteLine("Staff ID: " + c.Id);
                sw.WriteLine("Staff Name: " + c.Staff_Name);
                sw.WriteLine("Staff Birthday: " + c.Birthday);
                sw.WriteLine("Staff Email: " + c.Email);
                sw.WriteLine("Staff Annual Salary: " + "$"+ c.Salary);

                sw.Dispose();

                return true;
            }
            catch (Exception )
            {
                return false;
            }

        }
         

        /// <summary>
        /// Save the document of Staff.txt for any update.
        /// </summary>
        /// <param name="myClasses"></param>
        public  static void  SaveFiles(List<MyClass> myClasses)
        {

            try
            {
                // If document is not empty, for any update, new data will be appended to the end of data.
                string s = "";
                foreach (var item in myClasses)
                {
                    s += item.Id.ToString() + "," + item.Staff_Name.ToString() + "," + item.Birthday + "," + item.Email + "," + item.Salary + "\r\n";
                }
                if (myClasses.Count == 1)
                {
                    StreamWriter sw = File.AppendText("Staff.txt");
                    sw.Write(s);
                    sw.Flush();
                    sw.Close();
                    sw.Dispose();
                }
                //If document is empty, then create and cover the original one, save all data in new document.
                else
                {
                    File.WriteAllText("Staff.txt", s);
                }
            }
            catch (Exception )
            {
                MessageBox.Show("Error! Try again!");
            }
            
           
          
        }
     


    }
}
