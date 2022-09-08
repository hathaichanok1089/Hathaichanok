public class Program2
{

public static void Main(string[] args) 
 {
   Console.WriteLine("Please input money:");
   double input = double.Parse(Console.ReadLine());
  money (input);
 }

   public static double [] money(double input)
   {
   double money,i,ii,iii,iv,v,vi,vii,viii,ix,x,xi;
   i = input/1000;
   money = input%1000;
   
   ii = money/500;
   money = money%500;

   iii = money/100;
   money = money%100;

   iv = money/50;
   money = money%50;

   v = money/20;
   money = money%20;

   vi = money/10;
   money = money%10;

   vii = money/5;
   money = money%5;

   viii = money/2;
   money = money%2;

   ix = money/1;
   money = money%1;

   x = money/.50;
   money = money%.50;

   xi = money/.25;
   money = money%.25;

    Console.WriteLine("**************************");
    Console.WriteLine("1000: {0}", Math.Floor(i));
    Console.WriteLine("500: {0}", Math.Floor(ii));
    Console.WriteLine("100: {0}", Math.Floor(iii));
    Console.WriteLine("50: {0}", Math.Floor(iv));
    Console.WriteLine("20: {0}", Math.Floor(v));
    Console.WriteLine("10: {0}", Math.Floor(vi));
    Console.WriteLine("5: {0}", Math.Floor(vii));
    Console.WriteLine("2: {0}", Math.Floor(viii));
    Console.WriteLine("1: {0}", Math.Floor(ix));
    Console.WriteLine(".50: {0}", Math.Floor(x));
    Console.WriteLine(".25: {0}", Math.Floor(xi));
    double[] output = {Math.Floor(i),Math.Floor(ii),Math.Floor(iii),Math.Floor(iv),Math.Floor(v),Math.Floor(vi),Math.Floor(vii),Math.Floor(viii),Math.Floor(ix),Math.Floor(x),Math.Floor(xi)};
    return output;
  }
}