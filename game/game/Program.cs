using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random();
            Dog dog1 = new Dog();
            Horse horse1 = new Horse();
            Human human1 = new Human();
            Human human2 = new Human();
            Human human3 = new Human();
            Alien alien1 = new Alien();
            Alien alien2 = new Alien();
            
            
            List<Character> charaterList = new List<Character>();
            charaterList.Add(dog1);
            charaterList.Add(horse1);
            charaterList.Add(human1);
            charaterList.Add(human2);
            charaterList.Add(human3);
            charaterList.Add(alien1);
            charaterList.Add(alien2);

            for(int i = 0 ; i <=5 ; i++)
            {
                Console.Write("enter  "+charaterList[i]+ "  name:");
                charaterList[i].Name = Console.ReadLine();
                Console.WriteLine(" name of " +charaterList[i] +" is : " +charaterList[i].Name +"\n");
            }
            
            for(int i = 0 ; i <=1 ; i++)
            {
                Console.Write("enter "+ charaterList[i] + " age:");
                charaterList[i].Age =Convert.ToInt32(Console.ReadLine()) ;
                Console.WriteLine("age of " + charaterList[i] +" is : " +charaterList[i].Age +"\n");
            }
            
            for(int i = 2 ; i <7 ; i++)
            {
                Console.Write("  character  "+ charaterList[i] + " energy :");
                charaterList[i].Energy = ran.Next(100);
                Console.WriteLine(" energy of" + charaterList[i] +"is : "+charaterList[i].Energy +"\n" );
            }
            
            for(int i = 2 ; i <= 4 ; i++)
            {
                Console.WriteLine("Select one of the options:fruit-meat-vegtable ");
                charaterList[i].Food=Console.ReadLine();
                Console.WriteLine(" food of " + charaterList[i] +" is : " + charaterList[i].Food+"\n" );
            }
            
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("enter  " + charaterList[i] + " color:");
                charaterList[i].Color = Console.ReadLine();
                Console.WriteLine(" color of " +charaterList[i] +" is : " +charaterList[i].Color +"\n");
            }
            
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("enter  "+ charaterList[i] + " breed:");
                charaterList[i].Breed = Console.ReadLine();
                Console.WriteLine(" breed of " +charaterList[i] +" is : " +charaterList[i].Breed +"\n");
            }
            
            for (int i = 0; i <= 1; i++)
            {
                Console.Write("enter "+ charaterList[i] + " gender:");
                charaterList[i].Gender = Console.ReadLine();
                Console.WriteLine(" gender of " +charaterList[i] +" is : " +charaterList[i].Gender+"\n" );
            }
            
            for (int i = 0; i <= 1; i++)
            {
                charaterList[i].animalSound();
                
            }

         
            Tank myTank = new Tank();
            myTank.passenger(human1, myTank);
            Console.WriteLine("enter tank color :");
            myTank.Color= Console.ReadLine( );
            myTank.MaxSpeed = ran.Next(50,100);
            myTank.Power = ran.Next(100);
            myTank.Weight = ran.Next(2000);
            myTank.Damage = ran.Next(100);
            Console.Write("Choose one of the options: autumn ,firefighter :  ");
            myTank.Pattern = Console.ReadLine();
            Console.WriteLine( "pattern "+myTank.Pattern);
            Console.Write("Choose one of the options: Gatling M134 , mpulomet-41:");
            myTank.TypeOfGun = Console.ReadLine();
            
            Console.WriteLine("color of tank : " +myTank.Color);
            Console.WriteLine("type of gun " + myTank.TypeOfGun);
            Console.WriteLine("maxspeed of tank: "+ myTank.MaxSpeed);
            Console.WriteLine("power of tank: " +myTank.Power);
            Console.WriteLine("weight of tank: " + myTank.Weight);
            Console.WriteLine("damade of tank: " + myTank.Damage);
            Console.WriteLine("pattern of tank: " + myTank.Pattern);
            
            Console.WriteLine("************************************************************************");
            
            
            
             Dog myDog = new Dog();
            
            Console.Write("enter  dog name:");
            myDog.Name = Console.ReadLine();
            Console.Write("enter  dog color:");
            myDog.Color=Console.ReadLine();
            Console.Write("enter dog breed :");
            myDog.Breed =Console.ReadLine();
            Console.Write("enter dog gender:");
            myDog.Gender=Console.ReadLine();
            Console.Write("enter dog age:");
            myDog.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "name "+myDog.Name);
            Console.WriteLine( "color "+myDog.Color);
            Console.WriteLine(" breed " +myDog.Breed);
            Console.WriteLine("gender " +myDog.Gender);
            Console.WriteLine( "age " +myDog.Age);
            Console.WriteLine("************************************************************************");
            
            Horse myHorse = new Horse();
            Console.Write("enter horse name:");
            myHorse.Name = Console.ReadLine();
            Console.Write("enter horse color:");
            myHorse.Color=Console.ReadLine();
            Console.Write("enter horse breed :");
            myHorse.Breed =Console.ReadLine();
            Console.Write("enter horse gender:");
            myHorse.Gender=Console.ReadLine();
            Console.Write("enter horse age:");
            myHorse.Age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine( "name "+myHorse.Name);
            Console.WriteLine( "color "+myHorse.Color);
            Console.WriteLine(" breed " +myHorse.Breed);
            Console.WriteLine("gender " +myHorse.Gender);
            Console.WriteLine( "age " +myHorse.Age);
            
            Console.WriteLine("************************************************************************");
            
            
            Car mycar = new Car();
            myTank.passenger(human1, mycar);
            mycar.MaxSpeed = ran.Next(400);
            Console.WriteLine("enter color:");
            mycar.Color= Console.ReadLine( );
            mycar.Power = ran.Next(100);
            mycar.Weight = ran.Next(2000);
            mycar.Acceleration = ran.Next(4);
            mycar.Handling = ran.Next(100);
            
            Console.WriteLine( "max speed of car " + mycar.MaxSpeed);
            Console.WriteLine("color of car " +mycar.Color);
            Console.WriteLine("power of car "+ mycar.Power);
            Console.WriteLine("weight of car "+mycar.Weight);
            Console.WriteLine("acceleration  of car" +mycar.Acceleration);
            Console.WriteLine("handelin of car" + mycar.Handling);
            
            Console.WriteLine("************************************************************************");
            
            Human myCharacter = new Human();
            Console.WriteLine("Enter character name:");
            myCharacter.Name = Console.ReadLine();
            Console.Write("enter character age :");
            myCharacter.Age= Convert.ToInt32(Console.ReadLine());
            Console.Write("energy of character  :");
            myCharacter.Energy= ran.Next(100);
            Console.WriteLine("Select one of the options:fruit-meat-vegtable ");
            myCharacter.Food=Console.ReadLine();
            
            Console.WriteLine("character name  " +myCharacter.Name);
            Console.WriteLine("character age  " +myCharacter.Age);
            Console.WriteLine("charater energy  "+ myCharacter.Energy);
            Console.WriteLine("charater food " +myCharacter.Food);
            
            Console.WriteLine("************************************************************************");
            
            Alien myCharacter1 = new Alien();
            Console.Write("energy of alien  :");
            myCharacter1.Energy= ran.Next(100);
            Console.Write("energy of alien : " + myCharacter1.Energy);
            
            Console.WriteLine("************************************************************************");
            
            Gun colt = new Gun();
            colt.Name = "colt";
            colt.Accuracy= ran.Next(100);
            colt.Damage=ran.Next(100);
            colt.RateOfFire=ran.Next(100);
            colt.Handling=ran.Next(100);
            colt.Range=ran.Next(100);
            
            Console.WriteLine("name of gun  "+ colt.Name);
            Console.WriteLine("accuracy of gun "+ colt.Accuracy);
            Console.WriteLine("damage of gun  " + colt.Damage);
            Console.WriteLine("Rate of fire  of gun " + colt.RateOfFire);
            Console.WriteLine("handling  of gun " + colt.Handling);
            Console.WriteLine("range of gun " + colt.Range);
            Console.WriteLine("************************************************************************");
            
            Gun ak47 = new Gun();
            ak47.Name = "ak47";
            
            ak47.Accuracy=ran.Next(100);
            ak47.Damage=ran.Next(100);
            ak47.RateOfFire=ran.Next(100);
            ak47.Handling=ran.Next(100);
            ak47.Range=ran.Next(100);
            
            Console.WriteLine("range of gun  " +ak47.Range);
            Console.WriteLine("name of gun "+ ak47.Name);
            Console.WriteLine("accuracy of gun "+ ak47.Accuracy);
            Console.WriteLine("damage of gun " + ak47.Damage);
            Console.WriteLine("Rate of fire of gun  " +ak47.RateOfFire);
            Console.WriteLine("handling of gun" + ak47.Handling);
            Console.WriteLine("************************************************************************");
            
             Health he = new Health(); 
            
             he.Heartbeat = ran.Next(70, 150);
             he.Temperature = ran.Next(30, 40);
             he.MovingDistance=ran.Next(100000);
             he.StepCounter= ran.Next(10000);
             Console.WriteLine("heartbeat " + he.Heartbeat);
             Console.WriteLine("temperature " + he.Temperature);
             Console.WriteLine("moving distance " +he.MovingDistance);
             Console.WriteLine("step couner " + he.StepCounter);
            
             Console.WriteLine("************************************************************************");
            
             Spaceship mySpaceship = new Spaceship();
            
             mySpaceship.CargoHoldCapacity = ran.Next(2000);
            
            
            mySpaceship.MaxSpeed = ran.Next(1000);
            
            
             Console.Write("Choose one of the options: Gatling M134 , mpulomet-41:");
             mySpaceship.TypeOfGun = Console.ReadLine();
             myTank.Power = ran.Next(100);
             myTank.Weight = ran.Next(5000);
             myTank.Damage = ran.Next(100);
             myTank.RateOfFire = ran.Next(1000);
            
             Console.WriteLine("argoHoldCapacity  " +mySpaceship.CargoHoldCapacity);
             Console.WriteLine("speed " + mySpaceship.MaxSpeed);
             Console.WriteLine("type of gun " + mySpaceship.TypeOfGun);
             Console.Write("power of space ship: " + mySpaceship.Power);
             Console.Write("weight of space ship : " + mySpaceship.Weight);
             Console.Write("damade of space ship : " + mySpaceship.Damage);
             Console.Write("RateOfFire of space ship : " + mySpaceship.RateOfFire);
             Console.WriteLine("************************************************************************");
            
            Shield myShield = new Shield();
            Console.WriteLine("enter durability:");
            myShield.Durability =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine("Choose one of the options: small ,medium, large:");
            myShield.Size = Console.ReadLine();
            Console.WriteLine("Choose one of the options: wood ,iron, steel ,");
            myShield.BodyMaterial = Console.ReadLine();
            Console.WriteLine(myShield.BodyMaterial);
            Console.WriteLine("enter handling:");
            myShield.Handling = Convert.ToInt32( Console.Read());
            
            Console.WriteLine("Durability of shield : " + myShield.Durability);
            Console.WriteLine("size of shield : " + myShield.Size);
            Console.WriteLine("body material : " + myShield.BodyMaterial);
            Console.WriteLine("handling  : " + myShield.Handling);
            
            




        }
    }
}

abstract class Character
{
    private string color;
    private string breed;
    private string gender;
    private float energy;
    private string food;
    private string name;
    private int age;
    
    public virtual void animalSound()
    {
        Console.WriteLine("The animal makes a sound");
    }
    public string Name
    {
        set;
        get;
    }
    
    public string Color
    {
        set;
        get;
    }
    public string Breed
    {
        set;
        get;
    }
    
    public string Gender
    {
        set;
        get;
    }
    
    public float Energy
    {
        get => energy;
        set => energy = value;
    }

    public string Food
    {
        get => food;
        set => food = value;
    }
    public int Age
    {
        set;
        get;
    }
    

}
class Dog :Character
{
    public override void animalSound()
    {
        base.animalSound();
        Console.WriteLine("happ...happ");
    }
}
class Horse :Character
{
    public override void animalSound()
    {
        base.animalSound();
        Console.WriteLine("heee...heee");
    }
 }

  abstract class Machian
 {
    private int maxSpeed;
    private string color;
    private int power;
    private int weight;
    private int acceleration;
    private int handling;

    public void passenger(Character ch1, Tank m1)
    {
        Console.WriteLine("this " +m1 +" for " + ch1); 
     
    }
    public void passenger(Character ch1, Car m2)
    {
        Console.WriteLine("this " +m2 +" for " + ch1); 
     
    }
    public int MaxSpeed
    {
        get => maxSpeed;
        set => maxSpeed = value;
    }

    public string Color
    {
        get => color;
        set => color = value;
    }

    public int Power
    {
        get => power;
        set => power = value;
    }

    public int Weight
    {
        get => weight;
        set => weight = value;
    }

    public int Acceleration
    {
        get => acceleration;
        set => acceleration = value;
    }

    public int Handling
    {
        get => handling;
        set => handling = value;
    }
}

class Car:Machian
{
    
}
class Tank: Machian
{
    private int damage;
    private int rateOfFire;
    private string pattern;
    private string typeOfGun;
    
    public int Damage
    {
        get => damage;
        set
        {
            damage = value;

        }
        
    }


    public int RateOfFire
    {
        get => rateOfFire;
        set
        {
            
            
            rateOfFire = value;

        }
    }
    public string Pattern
    {
        get => pattern;
        set => pattern = value;
    }

    public string TypeOfGun
    {
        get => typeOfGun;
        set => typeOfGun = value;
    }

    

}

class Spaceship : Tank
{
    private int cargoHoldCapacity;
    public int CargoHoldCapacity
    {
        get => cargoHoldCapacity;
        set => cargoHoldCapacity = value;
    }
}

class Gun
{
    private string name;
    private int accuracy;
    private int damage;
    private int rateOfFire;
    private int handling;
    private int range;

    public string Name
    {
        get => name;
        set => name = value;

    }

    public int Accuracy
    {
        
        get =>accuracy;
        set => accuracy = value;
    }

    public int Damage
    {
        get => damage;
        set
        {
            damage = value;

        }
    }

    public int RateOfFire
    {
        get => rateOfFire;
        set
        {
            
            
            rateOfFire = value;

        }
    }

    public int Handling
    {
        get => handling;
        set
        {
            
            handling = value;

        }
    }

    public int Range
    {
        get => range;
        set
        {
           
            range = value;

        }
    }
}


class Human:Character
{
    
}

class Alien : Character
{
    
}


 class Health
{
    private int heartbeat;
    private int  temperature;
    private int movingDistance;
    private int stepCounter;

    public int Heartbeat
    {
        get => heartbeat;
        set => heartbeat = value;
    }

    public int StepCounter
    {
        get => stepCounter;
        set => stepCounter = value;
    }

    public int Temperature
    {
        get => temperature;
        set => temperature = value;
    }

    public int MovingDistance
    {
        get => movingDistance;
        set => movingDistance = value;
    }
}

class Shield
{
    private int durability;
    private string size;
    private string bodyMaterial;
    private int handling;

    public int Durability
    {
        get => durability;
        set => durability = value;
    }


    public string Size { get; set; }

    public string BodyMaterial { get; set; }

    public int Handling { get; set; }
}

