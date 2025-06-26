using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Burger;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Factory;

public interface IBurgerFactory
{
  public abstract IBurger CreateBurger(string type);
}