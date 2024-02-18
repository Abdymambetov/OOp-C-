using System;


namespace project{
    // наследование Killer наследуется с помощью знака : от Robot,  в с# нет множественного наследования 
    class Bot : Robot{
        

        //констркутор по умолчанию:
        public Bot(){}


        //конструктор:
        //base в данном контексте обозначает базовый класс, от которого происходит наследование.
        //вызывается конструктор базового класса с аргументами name, weight и coordinates.
        // Таким образом, base(name, weight, coordinates) инициализирует поля базового класса с помощью переданных аргументов. 
        // После этого выполняется дополнительная логика в конструкторе производного класса (Killer), 
        // в данном случае устанавливается значение Health и вызывается метод printValues() базового класса.
        public Bot(string name, int weight, byte[] coordinates) : base(name, weight, coordinates){
            
        }
        //через base обращаемся к родительскому классу и вызываем от туда метод

        public override void printValues()
        {
            System.Console.WriteLine(this.Name + " weight: " + this.Weight + ". Coordinates: ");
            foreach(byte el in this.Coordinates){
                System.Console.WriteLine(el);
            }
        }
    }
}