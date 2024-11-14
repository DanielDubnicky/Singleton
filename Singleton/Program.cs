using System.Dynamic;

namespace Singleton;

class Program
{
    static void Main(string[] args)
    {
        Singleton singleton = Singleton.VratInstanci();
        singleton.Hodnota = 2;
        Singleton singleton2 = Singleton.VratInstanci();
        Console.WriteLine(singleton.DoSmth());
        Console.WriteLine(singleton2.DoSmth());

        if(singleton == singleton2){
            Console.WriteLine("Good");
        } else {
            Console.WriteLine("Bad");
        }
    }
}

public class Singleton
{
    private Singleton() {}
    private static Singleton _instance;
    private static readonly object _padlock = new object();

    public int Hodnota {get; set;}

    public static Singleton VratInstanci()
    {
        lock (_padlock)
        {
            if (_instance == null)
            {       
                _instance = new Singleton();
            }
        
        }
        return _instance;
    }

    public string DoSmth(){
        return $":) {Hodnota}";
    }
}
