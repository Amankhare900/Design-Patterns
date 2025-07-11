using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory;

public abstract class BurgerShop
{
  public void OrderBurger(string type)
  {
    IBurger burger = CreateBurger(type);
    burger.Prepare();
  }
  public abstract IBurger CreateBurger(string type);
}