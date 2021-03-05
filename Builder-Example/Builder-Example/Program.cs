using System;
using Builder_Example.RefactoringGuruExample;
using Builder_Example.SystemBlockExample;

namespace Builder_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            // Клиентский код создаёт объект-строитель, передаёт его директору,
            // а затем инициирует  процесс построения. Конечный результат
            // извлекается из объекта-строителя.
            var director_ = new Director_();
            var builder_ = new ConcreteBuilder();
            director_.Builder = builder_;

            Console.WriteLine("Standard basic product:");
            director_.buildMinimalViableProduct();
            Console.WriteLine(builder_.GetProduct().ListParts());

            Console.WriteLine("Standard full featured product:");
            director_.buildFullFeaturedProduct();
            Console.WriteLine(builder_.GetProduct().ListParts());

            // Помните, что паттерн Строитель можно использовать без класса
            // Директор.
            Console.WriteLine("Custom product:");
            builder_.BuildPartA();
            builder_.BuildPartC();
            Console.Write(builder_.GetProduct().ListParts());


            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            //Пример Builder-pattern на сборке системного блока
            //Через builder
            Console.WriteLine("Через builder");
            Console.WriteLine("");
            var builder = new SystemBlockBuilder();

            //Без RAM
            builder.setBody();
            builder.setMotherBoard();
            builder.setPSU();
            builder.setCPU();
            builder.setVideoAdapter();
            builder.setNetworkAdapter();
            builder.setSoundAdapter();
            builder.setHardDrive();
            builder.setSSD();

            Console.WriteLine("Without Ram \n" + builder.GetProduct().ToString());
            Console.WriteLine("");
            builder.Reset();

            //Без видеокарты
            builder.setBody();
            builder.setMotherBoard();
            builder.setPSU();
            builder.setCPU();
            builder.setRAM();
            builder.setNetworkAdapter();
            builder.setSoundAdapter();
            builder.setHardDrive();
            builder.setSSD();

            Console.WriteLine("Without videocard \n" + builder.GetProduct().ToString());
            Console.WriteLine("");
            builder.Reset();


            //Через director
            Console.WriteLine("Через director");
            var director = new Director();
            director.Builder = builder;

            //Без RAM
            director.WithoutRam();

            Console.WriteLine("Without Ram \n" + builder.GetProduct().ToString());
            Console.WriteLine("");

            //Без видеокарты
            director.WithoutVideoCard();

            Console.WriteLine("Without videocard \n" + builder.GetProduct().ToString());
            Console.WriteLine("");

            Console.ReadKey();
        }
    }
}
