using System;
using System.Collections.Generic;
namespace project{
    class Program{
        static void Main(){
            Robot bot = new Robot("Bot", 800, new byte[] {0,0,0});
            //Испоьзую модификатор private:
            // bot.setValues("Bot", 800, new byte[] {0,0,0});
            bot.printValues();
            bot.Weight = -100;
            bot.Width = -100;
            // System.Console.WriteLine(bot.Width);
            System.Console.WriteLine(bot.Weight);


            Killer killer = new Killer("Killer", 1000, new byte[] {0,0,10}, 100);
            // killer.setValues("Killer", 1000, new byte[] {0,0,10});
            killer.printValues();
            // killer.Health = 100;
            killer.Lazer();
            // Robot.count = 0;
            Robot.Print();


            // массив указателей - каждый элемент это опеределенный объект на основе какого-то класса
            List<Killer> robots = new List<Killer>();
            robots.Add(new Killer("Alex", 400, new byte[] {0, 0, 10}, 100));
            robots.Add(new Killer("Bob", 600, new byte[] {0, 10, 10}, 100));
            robots.Add(new Killer("John", 800, new byte[] {10, 0, 10}, 100));
            robots.Add(new Killer("Josh", 400, new byte[] {0, 50, 10}, 100));


            Robot newRobot = null;

            foreach(Killer obj in robots){
                //оператор as позволыет преоброзовать один определенный объект с одним оперделенным типом данных (классом) к объекту другого типа данных (объекту у которого будет другой класс)
                //оператор is позволяет проверить принадлежит ли объект к определенному типу данных
                if(obj.Name == "Alex") newRobot = obj as Robot;
                System.Console.WriteLine(obj.Name);
                System.Console.WriteLine(obj is Robot);
            }
            






            // Испоьзовал модификатор public: 
            // bot.name = "Bot";
            // bot.weight = 800;
            // bot.coordinates = new byte[] {0,0,0};

            // System.Console.WriteLine(bot.name + " weight: "+ bot.weight);

            // Robot killer = new Robot();
            // killer.weight = 1000;
            // killer.name = "Killer";
            // killer.coordinates = new byte[] {0,0,10};










            // повтор try catch:
            // try{
            //     int num = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine(num);
            // } catch(FormatException){
            //     Console.WriteLine("It's not true");
            // }
            // try{
            //     int a, b, result;
            //     System.Console.WriteLine("Enter first number: ");
            //     a = Convert.ToInt32(Console.ReadLine());
            //     System.Console.WriteLine("Enter second number: ");
            //     b = Convert.ToInt32(Console.ReadLine());
            //     result = a / b;
            //     System.Console.WriteLine($"Result: {result}");
            // }catch(DivideByZeroException){
            //     System.Console.WriteLine("Not zero");
            // }catch(FormatException){
            //     Console.WriteLine("It's not true");
            // }finally{
            //     System.Console.WriteLine("Not bad");
            // }

            //повтор методов строк:
            // string word = "Hello";
            // word += "!";
            // word += String.Concat(word, "jdjljds");
            // System.Console.WriteLine(String.Compare(word, "Hello!"));

            // string people = "Hello, Alex, John";
            // string[] names = people.Split(new char[]{','});
            // foreach(string el in names){
            //     System.Console.WriteLine(el);
            // }
            // people = String.Join(" ", names);
            // System.Console.WriteLine(people);
            // System.Console.WriteLine(word.Trim());
            // System.Console.WriteLine(word.Substring(0, word.Length - 1));
            // System.Console.WriteLine("Enter words");
            // string text = Console.ReadLine();


            //работа с файлами:
            // using(FileStream stream = new FileStream("info.txt", FileMode.OpenOrCreate)){
            //     byte[] array = System.Text.Encoding.Default.GetBytes(text);
            //     stream.Write(array, 0, array.Length);
            // }
            // using(FileStream stream1 = File.OpenRead("info.txt")){
            //     byte[] array = new byte[stream1.Length];
            //     stream1.Read(array, 0, array.Length);
            //     string textFromFile = System.Text.Encoding.Default.GetString(array);
            //     System.Console.WriteLine(textFromFile);
            // }


            // работа с функциями:
            // int res1 = Sum(12, 10);
            // int res2 = Sum(1, 1);
            // Print(res1.ToString());
            // Print(res2.ToString());

            // byte[] nums = {5,7,8,4,5};
            // byte res = Sum(nums);
            // System.Console.WriteLine(res);
        }

        // public static byte Sum(byte[] digits){
        //     byte sum = 0;
        //     foreach(byte item in digits){
        //         sum+=item;
        //     }
        //     return sum;
        // }
        // public static void Print(string item){
        //     System.Console.WriteLine(item);
        // }
        // public static int Sum(int a, int b){
        //     int res = a + b;
        //     return res;
        // }
    }
}
