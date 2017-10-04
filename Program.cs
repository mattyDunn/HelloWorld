using System;

namespace HelloWorld
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Start();
		}

        public static void Start()
        {
			Console.WriteLine("Write Two Numbers");
			float hello1 = float.Parse(Console.ReadLine());
			float hello2 = float.Parse(Console.ReadLine());

			Console.WriteLine("Select An Option\n1.-Add\n2.-Subtract\n3.-Multiply\n4.-Divide\n5.-Exit");
			int option = int.Parse(Console.ReadLine());

			EvaluateOption(option, hello1, hello2);
        }

        public static float AddTwoNumbers(float n1, float n2)
        {
            float result = n1 + n2;

            return result;
        }

		public static float SubTwoNumbers(float n1, float n2)
		{
			float result = n1 - n2;

			return result;
		}

		public static float MultTwoNumbers(float n1, float n2)
		{
			float result = n1 * n2;

			return result;
		}

        public static float DivTwoNumbers(float n1, float n2)
		{
			float result = n1 / n2;

			return result;
		}

        public static void EvaluateOption (int option, float n1, float n2)
        {
            if(option == 1)
            {
                Console.WriteLine("Result of the addtion: " + AddTwoNumbers(n1, n2));
            }

            else if (option == 2)
            {
                Console.WriteLine("Result of the Subraction: " + SubTwoNumbers(n1, n2));
            }

			else if (option == 3)
			{
                Console.WriteLine("Result of the Multiplication: " + MultTwoNumbers(n1, n2));
			}

			else if (option == 4)
			{
                Console.WriteLine("Result of the Divition: " + DivTwoNumbers(n1, n2));
			}
            else if(option == 5)
            {
                return;
            }

            else
            {
                Console.WriteLine("Invalid");    
            }
			
            Start();
        }
    }
}
