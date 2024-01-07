using System;

namespace QuizTasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4. Verilmiş ədədin tərsdən yazıldıqda da eyni ədəd olub olmadığını tapan alqoritm
            //(misalçün 808 tərsdən yazıldıqda da 808 olur)

            //Console.WriteLine("Ededi daxil et: ");
            //string num = Console.ReadLine();
            //string reversedNum = "";
            //for (int i = num.Length; i >= 0; i--)
            //{
            //    reversedNum += num[i];
            //}
            //if (reversedNum == num)
            //{
            //    Console.WriteLine("Eded tersine yazildiqda eyni olur");
            //}
            //else
            //{
            //    Console.WriteLine("Eded tersine yazildiqda eyni olmur!");
            //}
            


        }

        static void AddElement(int[] arr)
        {
            //5.Verilmiş array - ə verilmiş elementi əlavə edən metod
            arr = new int[] { 3, 7, 9, 5, 6 };
            int[] arr2 = new int[arr.Length + 1];
            Console.WriteLine("Elave etmek istediyin ededi daxil et: ");
            int newElement = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < arr.Length; i++)
            {
                arr2[i] = arr[i];
            }
            arr2[arr2.Length - 1] = newElement;

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.WriteLine(arr2[i]);
            }
        }

        static string DeleteLastSpace(string str)
        {

            //6. Verilmiş yazının sonundaki boşluqları silən metod
            str = "Salam  ";
            int lastIndex = str.Length - 1;
            string newStr = "";
            for (int i = str.Length; i >= 0; i--)
            {
                if (str[i] != ' ')
                {
                    lastIndex= i;
                    break;
                }
            }
            for (int i = 0; i < lastIndex + 1; i++)
            {
                newStr += str[i];
            }
            return newStr;
        }
    }
}
