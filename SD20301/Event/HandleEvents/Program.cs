public delegate void MyEventHandler(object sender, EventArgs e);

class MyClass
{
    //Declare the event
    public event MyEventHandler? MyEvent;
    protected virtual void OnMyEvent()
    {
        MyEvent?.Invoke(this, EventArgs.Empty);
    }

    public void DoSomeThing(){
        //Some logic here
        OnMyEvent(); //Raise the event
    }

}

class Subscriber
{
    public void HandleEvent(object sender, EventArgs e)
    {
        Console.WriteLine("Event occurred!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        MyClass myObject = new MyClass();
        Subscriber subscriber = new Subscriber();

        //Subscribe to the event by attaching a method to it
        myObject.MyEvent += subscriber.HandleEvent;
        myObject.DoSomeThing();
    }
} 