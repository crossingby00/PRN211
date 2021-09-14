using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseCs_1
{
    class Program
    {
        static void Main(string[] args)
        {
             int i;
            #region ex1 
            //ex1
            /*
            Console.WriteLine("Ex1:");
            Console.WriteLine(24/5 );
            */
            #endregion
            #region ex2
            //ex2
            /*
            Console.WriteLine("Ex2:");
            Console.WriteLine((-1 + (4 * 6)) +"\n"+
                 ((35 + 5) % 7) +"\n"+ 
                 (14 + -4 * 6 / 11) +"\n"+ 
                 (2 + 15 / 6 * 1 - 7 % 2)
                );
            */
            #endregion
            #region ex3
            //ex3
            /*
            Console.WriteLine("Ex3:");
            int a;
            int b;
            Console.Write("Input the first number: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Input the second number: ");
            b = int.Parse(Console.ReadLine());

           
            Console.WriteLine(
          "{0} + {1} = " + (a + b) + "\n" +
            "{0} - {1} = " + (a - b) + "\n" +
             "{0} * {1} = " + (a * b) + "\n" +
             "{0} / {1} = " + (a / b) + "\n" +
               "{0} mod {1} = " + (a % b) + "\n", a,b
             );
            */
            #endregion
            #region ex4
            //ex4
            /*
            Console.WriteLine("Ex4:");
            int num1, num2, num3, num4;
            Console.Write("Input the First number: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("Input the Second number: ");
            num2 = int.Parse(Console.ReadLine());
            Console.Write("Input the third number: ");
            num3 = int.Parse(Console.ReadLine());
            Console.Write("Input the four number: ");
            num4 = int.Parse(Console.ReadLine());

            double aver = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("The average of {0}, {1}, {2}, {3}, is: {4} "
                ,num1, num2,num3,num4,aver ) ;
            */
            #endregion
            #region ex5
            //ex5
            /*
            Console.WriteLine("\nEx5:");
            Console.Write("Input a number: ");
            int numToRe = int.Parse(Console.ReadLine());
            int r, t, sum = 0;
            for (t = numToRe; t != 0; t = t / 10){
                r = t % 10;
                sum = sum * 10 + r;
            }
            Console.Write("The number in reverse order is : {0} \n", sum);
            */
            #endregion
            #region ex6
            //ex6
            /*
            Console.WriteLine("\nEx6:");
            int n;
            int[] arr = new int[100];
            Console.Write("Input the number of elements to store in the array : " );
            n = int.Parse(Console.ReadLine());

            Console.Write("Input " +n +"number of elements in the array :\n");
            for (i = 0; i < n; i++){
                Console.Write("element - " + i + ": ");
                arr[i] = int.Parse(Console.ReadLine());
            }

            Console.Write("\nThe values store into the array are : \n");
            for (i = 0; i < n; i++){
                Console.Write("{0}  ", arr[i]);
            }

            Console.Write("\n\nThe values store into the array in reverse are :\n");
            for (i = n - 1; i >= 0; i--){
                Console.Write("{0} ", arr[i]);
            }
            */
            #endregion
            #region ex7
            //ex7 
            /*
            int n1, j=0,k=0;
            Console.WriteLine("\nEx7:");
            Console.Write("Input the number of elements to store in the array : ");
            n1 = int.Parse(Console.ReadLine());
            int[] arr1 = new int[100];
            int[] arr2 = new int[100];
            int[] arr3 = new int[100];

            Console.Write("Input " + n1 + "number of elements in the array :\n");
            for ( i = 0; i < n1; i++){
                Console.Write("element - " + i + ": ");
                arr1[i] = int.Parse(Console.ReadLine());

            }
            for ( i = 0; i < n1; i++){
                if (arr1[i] % 2 == 0){
                    arr2[j] = arr1[i];
                    j++;
                }else{
                    arr3[k] = arr1[i];
                    k++;
                }
            }
            Console.Write("\nThe Even elements are : \n");
            for (i = 0; i < j; i++){
                Console.Write(arr2[i] +" ");
            }

            Console.Write("\nThe Odd elements are :\n");
            for (i = 0; i < k; i++){
                Console.Write(arr3[i] +" ");
            }
            Console.Write("\n\n");
            */
            #endregion
            #region ex8
            //ex8
            /*
            int n3, e, f;
            Console.WriteLine("\nEx8:");
            Console.Write("Input the size of array : ");
            n3 = int.Parse(Console.ReadLine());
            int[] arr4 = new int[100];
            Console.Write("Input " + n3 + "number of elements in the array :\n");
            for (i = 0; i < n3; i++)
            {
                Console.Write("element - " + i + ": ");
                arr4[i] = int.Parse(Console.ReadLine());
            }
            Console.Write("Input the value to be inserted : ");
            e = int.Parse(Console.ReadLine());
            Console.Write("Input the Position, where the value to be inserted :");
            f = int.Parse(Console.ReadLine());
            Console.Write("The current list of the array :\n");
            for (i = 0; i < n3; i++)
                Console.Write("{0} ", arr4[i]);

            for (i = n3; i >= f; i--)
                arr4[i] = arr4[i - 1];

            arr4[f - 1] = e;

            Console.Write("\n\nAfter Insert the element the new list is :\n");
            for (i = 0; i <= n3; i++)

                Console.Write("{0} ", arr4[i]);
            */
            #endregion
            #region ex9
            //ex9
            /*
            Console.WriteLine("Enter a string: ");
            string str = Console.ReadLine();
            Console.WriteLine("Enter the index of desired removal: ");
            int index = int.Parse(Console.ReadLine());

            str = str.Substring(0, index) + str.Substring(index + 1, str.Length - index - 1);
            Console.WriteLine(str);
            str = str.Substring(index, index);
            Console.WriteLine(str);
            */
            #endregion
            #region ex10
           
            Console.WriteLine("Test Data:  ");
            string str1 = Console.ReadLine();
            char[] cArr = str1.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArr.Length - 1; i > -1; i--)
            {
                reverse += cArr[i];
            }
          
            Console.WriteLine(reverse);
            #endregion

        }
    }
}
