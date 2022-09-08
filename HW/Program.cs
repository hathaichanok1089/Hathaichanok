public class Program 
{
  public static store  Createstore(string Name,
  double Number,
  string OwnerName,
  double RegisteredValue) 
  {
    return new store(Name,
    Number,
    OwnerName,
    RegisteredValue);
  }
 public static void Main(string[] args) 
 {
   Console.WriteLine("Please input name:");
   string name = Console.ReadLine();
   Console.WriteLine("Please input number:");
   double number = double.Parse(Console.ReadLine());
   Console.WriteLine("Please input ownername:");
   string ownername = Console.ReadLine();
   Console.WriteLine("Please input registeredvalue:");
   double registeredValue = double.Parse(Console.ReadLine());
   store Name = Createstore(name,number,ownername,registeredValue);
   PrintstoreInformation(Name);
  }

 static void PrintstoreInformation(store store) 
 {
    Console.WriteLine("**************************");
    Console.WriteLine("name: {0}", store.name);
    Console.WriteLine("numberr: {0}", store.number);
    Console.WriteLine("ownername: {0}", store.ownername);
    Console.WriteLine("registeredvalue: {0}", store.registeredvalue);
    Console.WriteLine("**************************");
  }
}
