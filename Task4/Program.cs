//Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
//Створіть структуру з ім'ям – Notebook. Поля структури: модель, виробник, вартість.
//У структурі має бути реалізований конструктор для ініціалізації полів та метод для виведення вмісту полів на екран

namespace Task4
{
    internal class Program
    {
        struct Notebook
        {
            public string model;
            public string vendor;
            public decimal price;

            public Notebook(string model, string vendor, decimal price)
            {
                this.model = model;
                this.price = price;
                this.vendor = vendor;
            }

            public void Print()
            {
                Console.WriteLine($"Model {model}, vendor {vendor}, price {price}");
            }
        }

        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("Model1","Vendor1",12);
            notebook.Print();
        }
    }
}