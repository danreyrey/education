namespace ObserverExample;

public class Subject : ISubject
{
    public int State { get; set; }
    
    private List<IObserver> _observers = new List<IObserver>();

    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attached an observer.");
        this._observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        Console.WriteLine("Subject: Detached an observer.");
        this._observers.Remove(observer);
    }

    public void Notify()
    {
        Console.WriteLine("Subject: Notify observers ...");
        
        foreach (var observer in _observers)
        {
            observer.Update(this);
        }
    }

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important ...");
        this.State = new Random().Next(0, 10);
        
        Thread.Sleep(15);
        
        Console.WriteLine("Subject: My state has just changed to: " + this.State);
        this.Notify();
    }
}