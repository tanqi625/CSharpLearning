using System;
using System.Security.Cryptography.X509Certificates;
class One
{
    string output = "";
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello\tWorld");
        int n = Convert.ToInt32(Console.ReadLine());
        string str = Console.ReadLine();
        
        
        string str2 = str + "666";
        string var = str2.Replace(str,"");
        Console.WriteLine(var);
        Console.Write("n:{0}", GetNum(n));
    }
    public static int GetNum(int x){
        return x + 10;
    }
}

class _2:One
{
    public static void Main(string[] args)
    {
        string str = Console.ReadLine();
        string str = 
    }



}