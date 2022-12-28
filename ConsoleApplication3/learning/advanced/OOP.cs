namespace ConsoleApplication3
{
    public class OOP
    {
         private Dog dog = new Dog(); // exemplar of the class Dog

        public void Zoopark()
        {
            dog.Name = "Sharik";
            // we can edit public fields from
            // other classes by colling
            // and assign new value
            dog.Age = 3;
            Dog doggie;
            doggie = dog;
            doggie.Name = "Tuzik"; // new name for new exemplar
        }

    }
    // classes
  sealed  class Dog : Animal // investigation of the class Animal
  // modificator sealed turn off investigation from class Dog
  // sealed make class Dog as if "packed"
    {
        

    }

    class Animal
    {
        // fields
        private string _name; //  private field _name has not accessible in other classes
        private float _wight;
        private int _age;
        public string Name // Property for the field _name
        {
            get => _name; 
            set => _name = value;
        }

        // modificator public gets rights
        // to using his fields, method and properties
        // in other classes 
        public float Weight => _wight; // public reference to private field _weight
        public int Age
        {
            get => _age; // public reference to private field _old
            set => _age = value;
        }

        // class Cat : Dog 
        // // class Cat can't investigation from class Dog
        // {
        //     
        // }
    }
        ///sdsrefxdsdsz
}
