using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Task_1.AbstractFood;


/// <summary>
/// После вывода метода Zoo.FeedAnimals необходимо выводить в консоль информацию о том,
/// какие животные и сколько были накормлены и какие животные и сколько не были,
/// а так же чем пытались накормить конкретное животное.
/// </summary>

namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Wolf wlf = new Wolf("Petya");
            Pig pig = new Pig("Grisha");
            Squirrel sq = new Squirrel("Sergey");

            

            Zoo zoo = new Zoo();
            zoo.Add(wlf);
            zoo.Add(pig);
            zoo.Add(sq);

            InformForAnimal(zoo);

            Console.ReadKey();

        }
        //Я может быть тут с вывовдом немного поторопился, все в одну процедуру слил.
        //Два одинаковых цикла и линка

        static void InformForAnimal(Zoo zoo)
        {
            AbstractFood[] randomFood =  { new Beef("Говядинка"), new Strawberry("Клубника"), new Walnut("Грецкий орех"),
                                           new Pumpkin("Тыква") };
            //рандомно покормить зверей
            //Array values = randomFood.ToArray();
            Random random = new Random();
            //Еда на сегодня
            List<AbstractFood> todayFood = new List<AbstractFood>();
            //три раза кормим всех животных
            foreach (var count in zoo)
            {
                AbstractFood randomBar = (AbstractFood)randomFood.GetValue(random.Next(zoo.Count()));
                todayFood.Add(randomBar);
                zoo.FeedAnimals(randomBar);

            }


            var hungryAnimals = zoo.Where(z => (z.IsHungry == true)).ToList();
            var countHungryAnimals = zoo.Where(z => z.IsHungry == true).Count();
            //Чем пытались накормить  каждое оставшеся голодное животное
            foreach (var animal in hungryAnimals)
            {
                Console.WriteLine($"Голодное животное {animal.Type} {animal.Name}");
                var result = todayFood.Where(iterator => iterator.FoodName != animal.FoodType).ToArray();
                Print(result);
            }
            Console.WriteLine("/*//////////////////");
            var notHungryAnimal = zoo.Where(z => z.IsHungry == false).ToList();
            var countNotHungryAnimal = zoo.Where(z => z.IsHungry == false).Count();

            //Чем пытались накормить  каждое не голодное животное
            foreach (var animal in notHungryAnimal)
            {
                Console.WriteLine($"Не голодное животное {animal.Type} {animal.Name}");
                var result = todayFood.Where(iterator => iterator.FoodName != animal.FoodType).ToArray();
                Print(result);
            }
        }
        static void Print(AbstractFood[] food)
        {
            foreach(var i in food)
            Console.WriteLine($"{i.FoodName} {i.NameFood}");
        }
    }
}
