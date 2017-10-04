using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
			Console.WriteLine("Write Two Numbers");
            float hello1 = float.Parse(Console.ReadLine());
            float hello2 = float.Parse(Console.ReadLine());
			Console.WriteLine(hello1 + hello2);
		}
    }
}
