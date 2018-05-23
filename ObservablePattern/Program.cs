using ObservablePattern.Interfaces;
using ObservablePattern.Models;
using System;

namespace ObservablePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
             * References
             * https://www.devmedia.com.br/como-implementar-o-design-pattern-observer-no-net/32846
             * 
             * 
             */

            ISubject emailControl = new EmailControl();

            var first = new User("First");
            var second = new User("Second");
            var third = new User("Thrid");

            Console.ForegroundColor = ConsoleColor.Green;
            //--------- newlester for all users ----------//
            emailControl.Subscribe(first);
            emailControl.Subscribe(second);
            emailControl.Subscribe(third);

            //--------- send email-----------------------//
            emailControl.SendEmail();


            Console.WriteLine(Environment.NewLine);


            //------ the second user has unsubcribe ----//
            emailControl.Unsubscribe(second);

            //--------- newlester for all users ----------//
            emailControl.SendEmail();


            Console.ReadKey();


        }
    }
}
