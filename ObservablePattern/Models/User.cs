using ObservablePattern.Interfaces;
using System;

namespace ObservablePattern.Models
{
    public class User : IObserver
    {
        public User(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public void ReceiveEmail()
        {
            Console.WriteLine($"{this.Name} e-mail received!");
        }
    }
}
