using System.Net;

class GenericList<T>
{
    List<T> list = new List<T>();

    public void Add(T item)
    {
        list.Add(item);
    }

    public T Get(int index)
    {
        return list[index];
    }

   /*  public int Count()
    {
        return list.Count;
    } */

    public int Count{
        get{
            return list.Count;
        }
    }

    public void PrintAllElement(){
        Console.WriteLine("All elements of the list:");
        foreach (var item in list)
        {
            Console.WriteLine($"{item}\t");
        }
    }
}

class Program
{   
    static void Main(string[] args)
    {
        //Using the generic list with intergers
        GenericList<int> intList = new GenericList<int>();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        intList.PrintAllElement();

        //Using the genicric list with strings
        GenericList<string> stringList = new GenericList<string>();
        stringList.Add("Hello");
        stringList.Add("Hi");
        stringList.Add("Nhut");
        stringList.PrintAllElement();
    }
}