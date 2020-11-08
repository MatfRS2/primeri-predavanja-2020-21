/*

An event is a notification sent by an object to signal the occurrence of an action. 

Events in .NET follow the observer design pattern. The class who raises events is called Publisher, and the class who receives 
the notification is called Subscriber. There can be multiple subscribers of a single event. 

Typically, a publisher raises an event when some action occurred. The subscribers, who are interested in getting a notification 
when an action occurred, should register with an event and handle it.

In C#, an event is an encapsulated delegate. It is dependent on the delegate. The delegate defines the signature for the event 
handler method of the subscriber class.

 */


using System;
using System.Threading;

namespace RS2.SimpleEvent
{
    // delegat preko kog ide komunikacija
    public delegate void Notify();  
        
    public class BusinessLogic
    {
        // deklarisanje dogadjaja
        public event Notify ProcessCompleted;

        // metoda u okviru kog se ispaljuje dogadjaj
        public void StartProcess()
        {
            Console.WriteLine("BL: Metod je pokrenut!");
            // some code here..
            Console.WriteLine("BL: Simulacija izvrsvanja prograskog koda!");
            Thread.Sleep(500);
            // potom se ispaljuje dogadjaj
            Console.WriteLine("BL: Ispali dogadjaj!");
            FireProcessCompleted();
            // some code here..
            Console.WriteLine("BL: Simulacija izvrsvanja prograskog koda!");
            Thread.Sleep(500);
            Console.WriteLine("BL: Gotovo!");

        }

        // metod koji ispaljuje dogadjaj
        protected virtual void FireProcessCompleted() //protected virtual method
        {
            // ako dogadjaj nije null, pokreni delegat
            if( ProcessCompleted != null) 
                ProcessCompleted.Invoke();
        }
    }

    // rukovalac dogadjajem
    public static class HandleProcesCompleted 
    {
        // event handler
        public static void onProcessCompleted()
        {
            Console.WriteLine("EH: Process is Completed!");
        }
    }

    class Program
    {
        static void onProcessCompleted2()
        {
            Console.WriteLine("PR: Process is Completed!");
        }

        public static void Main()
        {
            BusinessLogic bl = new BusinessLogic();
            // registruj rukovaoca za dogadjaj
            bl.ProcessCompleted += HandleProcesCompleted.onProcessCompleted;
            bl.ProcessCompleted += onProcessCompleted2;
            
            bl.StartProcess();
        }


    }
}

