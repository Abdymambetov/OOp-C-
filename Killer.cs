using System;

namespace project{
    // наследование Killer наследуется с помощью знака : от Robot,  в с# нет множественного наследования 
    class Killer : Robot{
        //аксессор:
        public int Health{get; set;}
        public void Lazer(){
            System.Console.WriteLine("Lazer using");
            this.surname = "Kilmonger";
            // base.surname = "Kilmonger";
        }

        //констркутор по умолчанию:
        public Killer(){}


        //конструктор:

        //base в данном контексте обозначает базовый класс, от которого происходит наследование.
        //вызывается конструктор базового класса с аргументами name, weight и coordinates.
        // Таким образом, base(name, weight, coordinates) инициализирует поля базового класса с помощью переданных аргументов. 
        // После этого выполняется дополнительная логика в конструкторе производного класса (Killer), 
        // в данном случае устанавливается значение Health и вызывается метод printValues() базового класса.
        public Killer(string name, int weight, byte[] coordinates, int health) : base(name, weight, coordinates){
            this.Health = health;
            base.printValues();
        }
    }
}