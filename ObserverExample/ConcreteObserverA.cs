namespace ObserverExample;

public class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject is Subject concreteSubject && concreteSubject.State < 3)
        {
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
        }
    }
}