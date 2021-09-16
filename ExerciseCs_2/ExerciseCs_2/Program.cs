using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCs_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ex1
            /*
            Console.WriteLine("ex1");
            int x1 = int.Parse(Console.ReadLine());
            int x2 = int.Parse(Console.ReadLine());
            int y;

            for (int x = x1; x <= x2; x++)
            {
                y = x * x - 2 * x + 1;
                Console.Write(y + " " );
            }
            */
            #endregion

            #region ex2
            /*
            Console.WriteLine("ex2");
            for (int x =1; x < 500; x++)
            {
                if(x%3==0 && x % 5 == 0)
                {
                    Console.Write(x +" ");
                }
            }
            */
            #endregion

            #region ex3
            /*
            Console.WriteLine("ex3");
            int user, pass;
            int attempts = 0;

            do
            {
                user = Convert.ToInt32(Console.ReadLine());
                pass = Convert.ToInt32(Console.ReadLine());

                if ((user != 12) && (pass != 1234))
                {
                    Console.WriteLine("Login failed");
                    attempts++;
                }
            }
            while (((user != 12) && (pass != 1234)) && (attempts != 3));

            if ((user == 12) || (pass == 1234))
                Console.WriteLine("Login successful");
            */
            #endregion

            #region ex4
            /*
            Console.WriteLine("ex4");
            int num1, num2;
            do
            {
                num1 = Convert.ToInt32(Console.ReadLine());
                if (num1 != 0)
                {
                    num2 = Convert.ToInt32(Console.ReadLine());
                    if (num2 == 0)
                    {
                        Console.WriteLine("Cannot divide by 0");
                        Console.WriteLine();
                    }
                    else
                    {
                        Console.WriteLine("Division is {0}", num1 / num2);
                        Console.WriteLine("Remainder is {0}", num1 % num2);
                        Console.WriteLine();
                    }
                }
            }
            while (num1 != 0);
            Console.WriteLine("Goodbye!");
            */
            #endregion

            #region ex5
            /*
            Console.WriteLine("ex5");
            int x, y;
            x = int.Parse(Console.ReadLine());
            y = int.Parse(Console.ReadLine());

            int i = x;
            Console.WriteLine("for statement.");

            for (i = x; i <= y; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("while");
            int k = x;
            while (k != y + 1)
            {
                Console.Write(k + " ");
                k++;

            }
            Console.WriteLine("");
            Console.WriteLine("do while");
            int l = x;
            do
            {
                Console.Write(l + " ");
                l++;
            } while (l !=y+1);
            */
            #endregion

            #region ex6
            /*
            Console.WriteLine("ex6");
            int[] arr = new int[10];
            int i, n;
            Console.Write("Input the size of array : ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Input {0} elements in the array in ascending order:\n", n);
            for (i = 0; i < n; i++)
            {
                Console.Write("{0} : ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            int sum = 0, max = arr[0], min = arr[0];
            for ( i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                if (arr[i] > max)
                    max = arr[i];
                if (arr[i] < min)
                    min = arr[i];
            }
            Console.WriteLine("Sum: {0} {1}", arr.Sum(), sum);
            double ave = sum / arr.Length;
            Console.WriteLine("Mean: {0}", ave);
            Console.WriteLine("Max: {0} {1}", arr.Max(), max);
            Console.WriteLine("Min: {0} {1}", arr.Min(), min);
            */
            #endregion

            #region ex7
            /*
            Console.WriteLine("ex7");
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} is " + (num1 % 2 == 0 ? " positive" : " negative"), num1);
            Console.WriteLine("{0} is " + (num2 % 2 == 0 ? " positive" : " negative"), num2);
            Console.WriteLine("Both is " + (num2 % 2 == 0 && num1 % 2 == 0 ? " positive" : " negative"));
            */

            #endregion

            #region ex8
            /*
            Console.WriteLine("ex8");
            Console.Write("Enter quantity of values from the array of intergers: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            string num = "";
            bool isFound = false;
            do
            {
                isFound = false;
                num = Console.ReadLine();
                if (num.Equals("end"))
                {
                    break;
                }
                for (int i = 0; i < length; i++)
                {
                    if (num.Equals(arr[i] + ""))
                    {
                        Console.WriteLine("The number {0} exist", num);
                        isFound = true;
                        break;
                    }
                }
                if (!isFound)
                {
                    Console.WriteLine("Not existed");
                }
            } while (true);
            */
            #endregion

            #region ex9
            /*
            Console.WriteLine("ex9");
            Console.Write("Enter quantity of values from the array of intergers: ");
            int length = int.Parse(Console.ReadLine());
            int[] arr = new int[length];
            for (int i = 0; i < length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }

            float totalPos = 0, totalNega = 0;
            int countPos = 0, countNega = 0;
            for (int i = 0; i < length; i++)
            {
                if (arr[i] > 0)
                {
                    totalPos += arr[i];
                    countPos++;
                }
                if (arr[i] < 0)
                {
                    totalNega += arr[i];
                    countNega++;
                }
            }
            Console.WriteLine("Average numbers negatives is " + totalNega / countNega);
            Console.WriteLine("Average numbers positives is " + totalPos / countPos);

            */
            #endregion

            #region ex10
            /*
            Console.WriteLine("ex10");
            int[,] arr = new int[2, 5];

            float total1 = 0, total2 = 0;

            for (int i = 0; i < 5; i++)
            {
                arr[0, i] = int.Parse(Console.ReadLine());
                total1 += arr[0, i];
            }
            for (int j = 0; j < 5; j++)
            {
                arr[1, j] = int.Parse(Console.ReadLine());
                total2 += arr[0, j];
            }
            Console.WriteLine("Average for group 1  is " + total1 / (5));
            Console.WriteLine("Average for group 2 is " + total2 / (5));
            */

            #endregion

            #region ex11
            /*
            Console.WriteLine("ex11");

            Car[] arr = new Car[3];
            for (int i = 0; i < 3; i++)
            {
                String Model = Console.ReadLine();
                int AnyoFabricacion = int.Parse(Console.ReadLine());

                arr[0] = new Car(Model, AnyoFabricacion);
            }
            #endregion
            */
            #endregion

            #region ex12
            /*
            Console.WriteLine("ex12");
            string text = Console.ReadLine();
            int pos = int.Parse(Console.ReadLine());
            char letter = char.Parse(Console.ReadLine());

            Console.WriteLine(ChangeLetter(text, pos, letter));
            */
            #endregion

            #region ex13
            /*
            String text = Console.ReadLine();

            Console.WriteLine(IsAlphabetic(text));
             */
            #endregion

            #region ex14
            /*
            String IsNum = Console.ReadLine();

            Console.WriteLine(IsNumber(IsNum));
            */
            #endregion

            #region ex15
            /*
            int Num = int.Parse(Console.ReadLine());
            Double(ref Num);
            Console.WriteLine(Num);
            */
            #endregion
        }



        #region ex11
        /*
        class Car
        {
            public string Model;
            public int AnyoFabricacion;


            public Car()
            {
            }

            public Car(string model, int anyoFabricacion)
            {
                AnyoFabricacion = anyoFabricacion;
                Model = model;
            }

            public int AnyoFabricacion1 { get => AnyoFabricacion; set => AnyoFabricacion = value; }
            public string Model1 { get => Model; set => Model = value; }

            public override string ToString()
            {
                return "Model: " + Model + ", Year of production: " + AnyoFabricacion + "\n ";
            }

        }
        */
        #endregion

        #region ex12
        /*
        public static string ChangeLetter(string text, int pos, char letter)
        {
            text = text.Remove(pos, 1);
            text = text.Insert(pos, letter.ToString());
            return text;
        }
        */
        #endregion

        #region ex13
        /*
        public static Boolean IsAlphabetic(String text)
        {
            text = text.ToUpper();
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i]<'A'||text[i]>'Z')
                {
                    return false;
                }
            }

            return true;
        }
        */
        #endregion

        #region ex14
        /*
        public static Boolean IsNumber(String isNum)
        {
           
            for (int i = 0; i < isNum.Length; i++)
            {
                if (isNum[i] < '0' || isNum[i] > '9')
                {
                    return false;
                }
            }

            return true;
        }
        */
        #endregion

        #region ex15
        /*
        private static void Double(ref int num)
        {
            num *= 2;
        }
        */
        #endregion
    }
}




