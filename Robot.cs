using System;

namespace project{

    // данный класс является абстрактным, это означает что оно лишь описывает общие характеристики, также здесь могут быть некоторые методы которые должны реализовать в классах наследниках и плюс на основе этого класса нельзя создать объекта
    abstract class Robot : IRun, IJump{
        // private // доступен исключительно внутри этого класса 
        // protected //будет доступен только внутри класса где он создан и в классах наследниках 
        // public // доступен везде 

        private static int count;
        public  static int state;
        private string name;
        private int weight;
        private byte[] coordinates;
        protected string surname;

        // аксессоры:
        public string Name{
            get{
                return name;
            } private set{}
        }
        public int Weight{
            //get - Метод для получения значения свойства
            get{
                // System.Console.WriteLine("Result: ");
                return this.weight;
            }
            //set - Метод для установки значения свойства
            set{
                if(value < 1) this.weight = 1;
                else if(value > 5000) this.weight = 5000;
                else this.weight = value;
            }
        }

        public byte[] Coordinates{
            get{
                return this.coordinates;
            }
            private set{}
        }


        //отдельный аксессор:
        public int Width{private get; set;}
        public float speed { get; set; }
        public float y { get; set; }


        // public Robot(){} // конструктор по умолчанию, все классы имеют такой конструктор
        public Robot(string name, int weight, byte[] coordinates){
            System.Console.WriteLine("Object creat");
            this.setValues(name, weight, coordinates);
            count++;

        }
        public Robot(){
            count++;
        }

        //для private:
        public void setValues(string name, int weight, byte[] coordinates){
            this.name = name;
            this.weight = weight;
            this.coordinates = coordinates;
        }
        public void setValues(string name, int weight){
            this.name = name;
            this.weight = weight;
        }
        public void setValues(string name){
            this.name = name;
        }

        // Абстрактный метод - это метод, который объявлен в абстрактном классе, но не имеет конкретной реализации в этом классе.
        // Любой класс, который наследует абстрактный класс, обязан реализовать все его абстрактные методы.
        // В языках, поддерживающих абстрактные методы, ключевое слово abstract используется для их объявления.
        public abstract void printValues();



        //virtual - виртуальный метоl это метод, который может быть переопределен в производных классах. 
        // Виртуальные методы позволяют создавать иерархии классов, где производные классы могут изменять поведение методов базового класса по своему усмотрению.
        // Чтобы объявить метод как виртуальный, используется ключевое слово virtual. Производные классы могут затем переопределить этот метод с помощью ключевого слова override.
        // public virtual void printValues(){
        //     System.Console.WriteLine(this.name + " weight: " + this.weight + ". Coordinates: ");
        //     foreach(byte el in coordinates){
        //         System.Console.WriteLine(el);
        //     }
        // }

        public static void Print(){
            System.Console.WriteLine("Count: " + count);
        }

        public void RobotRun()
        {
            System.Console.WriteLine("Robot is now running");
        }

        public void Jump()
        {
            System.Console.WriteLine("Robot is jumping");
        }

        //ключевое слово this нельзя применять с статическим модификатором
    }
}