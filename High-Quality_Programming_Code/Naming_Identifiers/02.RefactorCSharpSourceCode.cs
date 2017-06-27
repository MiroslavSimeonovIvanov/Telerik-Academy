using System;

public class GenderIdentification
{
    public enum Gender { Male, Female };

    public class Human
    {
        public Gender Sex { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public static void Main()
    {
        Human human = new Human();
        int identificationNumber = human.Age;

        if (identificationNumber % 2 == 0)
        {
            human.Name = "The Dude";
            human.Sex = Gender.Male;
        }
        else
        {
            human.Name = "Sexy chick";
            human.Sex = Gender.Female;
        }
    }
}
