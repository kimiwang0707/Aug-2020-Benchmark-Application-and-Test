// Student Name： Yuxi Wang    
// Student ID: 22001587

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace D201BenchmarkApp
{
    static class Program
    {
        /// <summary>
        /// The main entrance of program.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form());
        }
    }
}
