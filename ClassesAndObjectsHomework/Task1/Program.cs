namespace Task1
{
    using System;
    
    class Program
    {
        static void Main()
        {
            Cat firstCat = new Cat("Robert", 3);
            Cat secondCat = new Cat("Lora", 2);
            Cat thirdCat = new Cat("Frankie", 4);
            Cat fourthCat = new Cat("Scarlett", 3);
            Cat fifthCat = new Cat("Roger", 5);
            Cat sixthCat = new Cat("Monika", 3);
            Cat seventhCat = new Cat();
            seventhCat.Name = "Rafael";
            seventhCat.Age = 4;
            Cat eightCat = new Cat();
            eightCat.Name = "Megan";
            eightCat.Age = 2;
            Cat ninthCat = new Cat("Albert", 9);
            Cat tenthCat = new Cat("Jessica", 8);

            Cat[] cats = new Cat[10] {firstCat, secondCat, thirdCat, fourthCat,
            fifthCat, sixthCat, seventhCat, eightCat, ninthCat, tenthCat};

            foreach (Cat item in cats)
            {
                item.SayNameAndAge();
            }
            Console.WriteLine();
        }
    }
}
