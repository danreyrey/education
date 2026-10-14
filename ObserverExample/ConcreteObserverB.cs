namespace ObserverExample;

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is Subject concreteSubject &&
            (concreteSubject.State == 0 || concreteSubject.State >= 2))
        {
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
        }
    }
}