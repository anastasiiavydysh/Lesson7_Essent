//Створіть клас MyClass і структуру MyStruct, які містять поля public string change.
//У класі Program створіть два методи: static void ClassTaker(MyClass myClass),
//який надає полю change екземпляра myClass значення «змінено». static void StruktTaker(MyStruct myStruct),
//який надає полю change екземпляра myStruct значення «змінено». Продемонструйте різницю у використанні класів
//та структур, створивши у методі Main() екземпляри структури та класу. Змініть значення полів екземплярів на
//«не змінено», а потім викличте методи ClassTaker і StruktTaker. Виведіть на екран значення полів екземплярів.
//Проаналізуйте отримані результати.

namespace Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyClass myClass = new MyClass();
            myClass.change = "не змінено";

            MyStruct myStruct = new MyStruct();
            myStruct.change = "не змінено";

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);

            MyClass.ClassTaker(myClass);
            MyStruct.StruktTaker(myStruct);

            Console.WriteLine(myClass.change);
            Console.WriteLine(myStruct.change);
        }
    }
}