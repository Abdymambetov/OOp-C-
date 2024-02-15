using System;

namespace project{
    class Robot{
        // private // доступен исключительно внутри этого класса 
        // protected //будет доступен только внутри класса где он создан и в классах наследниках 
        // public // доступен везде 

        private static int count;
        public  static int state;
        private string name;
        private int weight;
        private byte[] coordinates;


        

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
        public void printValues(){
            System.Console.WriteLine(this.name + " weight: " + this.weight + ". Coordinates: ");
            foreach(byte el in coordinates){
                System.Console.WriteLine(el);
            }
        }

        public static void Print(){
            System.Console.WriteLine("Count: " + count);
        }

        //ключевое слово this нельзя применять с статическим модификатором
    }
}