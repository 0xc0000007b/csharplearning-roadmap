using System;
using System.Runtime.Remoting.Channels;using ConsoleApplication3;

namespace ConsoleApplication3
{
    public class Enum
    {
      // read more about Enum: https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/enum
        
        public enum LanguageDifference : int
        {
            JavaScript = 10,
            Java = 26,
            Cplusplus = 50,
            Sharp = 25,
            Python = 5,
            Ruby = 15,
            php = 20,
            go = 18
        }
       public   void LearnLanguage(LanguageDifference lang)
        {
            switch (lang)
            {
                case LanguageDifference.Java:
                    Console.WriteLine($"the difference of java is { (int)LanguageDifference.Java}" );
                    break;
                case LanguageDifference.Cplusplus:
                    Console.WriteLine($"the difference of c++ equal is {LanguageDifference.Cplusplus}");
                    break;
            }   
        }

    }

}
       public enum HitByWeapon
       {
          Pistol = 3,
           Bazooka = 60,
           NukeBomb = 1600,
           SniperRiffle = 150,
           MachineGun = 200 
       }
    public abstract class Weapon 
    {
        public abstract void WeaponHit();
    }

public class Pistol : Weapon
{
    public override void WeaponHit()
    {
        Console.WriteLine($"you hit the enemy by {(int)HitByWeapon.Pistol} HP");
    }
}

public class Bazooka : Weapon
{
    public override void WeaponHit()
    {
        Console.WriteLine($"you destroy enemy tank");
    }
}

