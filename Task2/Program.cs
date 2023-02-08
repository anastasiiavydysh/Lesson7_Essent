//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Потрібно: Описати структуру з ім'ям Train, що містить такі поля: назву пункту призначення, номер поїзда, час відправлення.
//Написати програму, яка виконує такі дії: введення з клавіатури даних до масиву, що складається з восьми елементів типу
//Train (записи мають бути впорядковані за номерами поїздів); виведення на екран інформації про поїзд, номер
//якого введено з клавіатури (якщо таких поїздів немає, вивести відповідне повідомлення). 

using System.Collections.Immutable;
using System.Globalization;

namespace Task2
{
    internal class Program
    {
        public struct Train{
            public string destination;
            public int trainNum;
            public DateTime departureTime;
        }

        public static Train[] Sort(Train[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i].trainNum < arr[i - 1].trainNum)
                {
                    var tmp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = tmp;
                }
            }
            return arr;
        }

        public static Train FindTrain(Train[] arr, int trainNum)
        {
            for(int i= 0; i < arr.Length; i++)
            {
                if (arr[i].trainNum == trainNum)
                    return arr[i];
            }
           throw new Exception("This train is not exist");
        }

        static void Main(string[] args)
        {            
            Train[] arr = new Train[8];
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write($"Enter destination for {i} item of array -> ");
                arr[i].destination = Console.ReadLine();
                Console.Write($"Enter train number for {i} item of array -> ");
                arr[i].trainNum = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter departure day for {i} item of array -> ");
                int day = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter departure month for {i} item of array -> ");
                int month = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter departure year (format 'yyyy') for {i} item of array -> ");
                int year = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter departure hour for {i} item of array -> ");
                int hour = Convert.ToInt32(Console.ReadLine());
                Console.Write($"Enter departure minutes for {i} item of array -> ");
                int minute = Convert.ToInt32(Console.ReadLine());

                arr[i].departureTime = new DateTime(year, month, day, hour, minute, 00);
            }

            arr = Sort(arr);

            Console.WriteLine("Enter your train number -> ");
            int clientNumber = Convert.ToInt32(Console.ReadLine());
            Train clientTrain = FindTrain(arr, clientNumber);
            Console.WriteLine("Your train: destination " + clientTrain.destination + ", train number "+clientTrain.trainNum + ", date "+ clientTrain.departureTime);
        }       
    }
}