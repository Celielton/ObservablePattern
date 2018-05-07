using ObservablePattern.Interfaces;
using System;
using System.Collections.Generic;

namespace ObservablePattern.Models
{
    public class EmailControl : ISubject
    {

        private readonly List<IObserver> _users;

        public EmailControl()
        {
            this._users = new List<IObserver>();
        }

        public void SendEmail()
        {
            this._users.ForEach(user => user.ReceiveEmail());
        }

        public void Subscribe(IObserver observer)
        {
            this._users.Add(observer);
        }

        public void Unsubscribe(IObserver observer)
        {
            this._users.Remove(observer);
        }
    }
}
