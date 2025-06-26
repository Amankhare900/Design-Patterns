using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory;

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