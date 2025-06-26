using PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Burger;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.FactoryMethod.Factory;

public interface IBurgerFactory
{
  public abstract IBurger CreateBurger(string type);
}