﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace simhoppprojekt
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form1 = new Form1();
            TavlingsClass t1 = new TavlingsClass("tavling1");
            PresenterForm1 presenter = new PresenterForm1(form1, t1);
            Application.Run(form1);
        }
    }
}