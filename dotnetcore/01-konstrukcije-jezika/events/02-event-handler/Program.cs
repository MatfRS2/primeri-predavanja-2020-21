/*

.NET Framework includes built-in delegate types EventHandler for the most common events. 

Typically, any event should include two parameters: the source of the event and event data. 

Use the EventHandler delegate for all events that do not include event data. 

 */


using System;
using System.Threading;

namespace RS2.EventHandlerSample
{
    public class BusinessLogic
    {
        // deklarisanje dogadjaja
        public event EventHandler ProcessCompleted;

        // metoda u okviru koje se ispaljuje dogadjaj
        public void StartProcess()
        {
            Console.WriteLine("BL: Metod je pokrenut!");
            // some code here..
            Console.WriteLine("BL: Simulacija izvrsvanja prograskog koda!");
            Thread.Sleep(500);
            // potom se ispaljuje dogadjaj
            Console.WriteLine("BL: Ispali dogadjaj!");
            FireProcessCompleted(EventArgs.Empty);
            // some code here..
            Console.WriteLine("BL: Simulacija izvrsvanja prograskog koda!");
            Thread.Sleep(500);
            Console.WriteLine("BL: Gotovo!");
        }

        // metod koji ispaljuje dogadjaj
        protected virtual void FireProcessCompleted(EventArgs e)
        {
            if(ProcessCompleted != null)
                ProcessCompleted.Invoke(this, e);
        }
    }

    class Program
    {
        public static void Main()
        {
            BusinessLogic bl = new BusinessLogic();
            // registruj rukovaoca za dogadjaj
            bl.ProcessCompleted += onProcessCompleted; 

            bl.StartProcess();
        }

        // rukovalac dogadjaja
        public static void onProcessCompleted(object sender, EventArgs e)
        {
            Console.WriteLine("EH: Process Completed!");
        }
    }

}


