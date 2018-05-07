namespace ObservablePattern.Interfaces
{
    public interface ISubject
    {
        void Subscribe(IObserver observer);
        void Unsubscribe(IObserver observer);
        void SendEmail();
    }
}
