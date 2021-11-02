using System;

namespace _02._11._21RefOut
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int num;
            string strNum;

            strNum = Console.ReadLine();
            num = Convert.ToInt32(strNum);

            int[] aa = new int []{ 1, 2, 3, 5, 6, 7 };

            foreach (var item in AddArr(aa, num ))
            {
                Console.WriteLine(item);
            }

        }



        static int [] AddArr(int [] arr , int num)
        {
            // arry resizela elave

            Array.Resize(ref arr, arr.Length + 1);
            arr[arr.Length - 1] = num;

            return arr;

        }   //Task 3

        //static string [] StrArr(string text , string test)
        //{

        //}

        static string [] LastStr()
        {
            string[] text = { "Bu gunun havasi", "Hava soyuqdur meselen" };

            string[] addArr = new string[0];

            foreach (var txt in text)
            {
                string[] txt1 = txt.Split(' '); 
               
                string last = txt1[txt1.Length - 1]; // sonuncunu gotur

                // arr size

                Array.Resize(ref addArr, addArr.Length + 1);
                addArr[addArr.Length - 1] = last;

            }
            return addArr;


        }                 // task 5

    }
}