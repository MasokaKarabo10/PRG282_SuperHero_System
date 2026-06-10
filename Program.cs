using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PRG282_SuperHeroSystem.DataLayer;
using PRG282_SuperHeroSystem.PresentationLayer;
using PRG282_SuperHeroSystem.BussinessLayer;

namespace PRG282_SuperHeroSystem
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            Console.WriteLine("hello world");
            Console.WriteLine("this is me again");
        }

       
    }
}
