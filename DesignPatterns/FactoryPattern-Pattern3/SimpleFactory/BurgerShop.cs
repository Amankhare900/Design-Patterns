using PRACTICEPATTERN.DesignPatterns.FactoryPattern.SimpleFactory.Burger;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.SimpleFactory.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.SimpleFactory;

public class BurgerShop
{
  public static void MakeBurger()
  {
    Console.WriteLine("which burger do you want? basic, standard, or premium ?");
    string type = Console.ReadLine() ?? "basic";
    IBurger burger = BurgerFactory.CreateBurger(type);
    burger.Prepare();
  }
}