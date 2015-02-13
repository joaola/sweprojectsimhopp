using System;
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
            TavlingsClass t1 = new TavlingsClass("vm i magplask","2015-02-15");

            Hopplist kurt = new Hopplist(1, "Kurt", "slavicboyz", 1990, "?", "hallsberg", "3mmagplask");
            List<float> tempbetyg = new List<float>();
            tempbetyg.Add(10);
            tempbetyg.Add(8.5f);
            tempbetyg.Add(9f);
            tempbetyg.Add(8);
            tempbetyg.Add(7);
            tempbetyg.Add(6);
            tempbetyg.Add(6);
            kurt.AddHopp(new Hopp(101,"A",1.5f,3,tempbetyg));
            kurt.AddHopp(new Hopp(202, "A", 2f, 3, tempbetyg));
            t1.AddPerson(kurt);


            PresenterForm1 presenter = new PresenterForm1(form1, t1);
            Application.Run(form1);
        }
    }
}
