using PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod;

public class BurgerShop
{
  public static void MakeBurger()
  {
    IBurgerFactory burgerFactory = new KingBurger();
    Console.WriteLine("which burger do you want? basic, standard, or premium ?");
    string type = Console.ReadLine() ?? "basic";
    IBurger burger = burgerFactory.CreateBurger(type);
    burger.Prepare();
  }
}