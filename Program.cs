using System;

namespace ArrayManipulations
{
    class Program
    {
        static void Main(string[] args)
        {
            ArraySumNew();
        }
        static void ArraySumNew()
        {
            int[] strNo = { 10, 23, 30, 41, 50, 65, 70 };
            int[] age = { 5, 40, 6, 25, 50, 22, 70 };
            int[] strNoByAge = new int[age.Length];

            for (int i = 0; i < strNo.Length; i++)
            {

                strNoByAge[i] = strNo[i] * age[i];
                Console.Write(strNoByAge[i] + " ");
            }
        }
        static void ArraySumStr()
        {
            int[] strNo = { 10, 23, 30, 41, 50, 65, 70 };
            int[] age = { 5, 40, 6, 25, 50, 22, 70 };
            string[] strNoByAge = new string[age.Length];

            for (int i = 0; i < strNo.Length; i++)
            {
                string strNoStr = strNo[i].ToString();
                string ageStr = age[i].ToString();

                strNoByAge[i] = strNoStr + ageStr;
                Console.WriteLine($"{strNo[i].ToString()}  {age[i].ToString()}");
                Console.WriteLine(strNoByAge[i]);
            }
        }
        static void StringArrayMerge()
        {
            string[] streetName = { "Ade Str", "Ojo Str", "ok Str", "Oj str", "B str", "Y str", "M str" };
            int[] streetNo = { 5, 40, 6, 25, 50, 22, 70 };
            string[] streetAddress = new string[streetNo.Length];

            for (int i = 0; i < streetNo.Length; i++)//use one iteration since the array is of equal lenght
            {
                string streetNoStr = streetNo[i].ToString();
                string streetNameStr = streetName[i];

                streetAddress[i] = streetNameStr + streetNoStr;
                //Console.WriteLine($"{streetNo[i].ToString()}  {streetNameStr}");  
                Console.WriteLine(streetAddress[i]);
            }
        }
        static void DeleteArray()
        {
            string[] streetName = { "Ade Str", "Ojo Str", "ok Str", "Oj str", "B str", "Y str", "M str" };
            int[] streetNo = { 52, 40, 6, 25, 50, 22, 70 };
            string[] streetAddress = new string[streetNo.Length];


            for (int i = 0; i < streetNo.Length; i++)//use one iteration since the array is of equal lenght
            {
                streetNo[i] = 0;
                Console.WriteLine(streetNo[i]);
                streetName[i] = "";
                Console.WriteLine(streetName[i]);
            }
        }
        static void MaxMin()
        {
            int a = 15, b = 25, c = 30;
            //Console.WriteLine(Math.Max(a, Math.Max(b, c)));
            int firstLevel = Math.Max(a, b);
            int secondLevel = Math.Max(firstLevel, c);
            //Console.WriteLine(Convert.ToInt32(secondLevel));
            Console.WriteLine(secondLevel); // if the values are many you can break it down like this

            
            int x = 25, y = 25, z = 30;
            Console.WriteLine(Math.Min(x, Math.Min(y, z)));

            int[] streetNo = { 52, 40, 6, 25, 50, 22, 70 };
            //int maxi = Math.Max(streetNo);
            ///int[] mysort = Array.Sort(streetNo);
            Console.WriteLine("Testing");
            
                



        }
    }
}
