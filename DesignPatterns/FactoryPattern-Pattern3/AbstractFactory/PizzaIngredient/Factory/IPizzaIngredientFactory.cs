using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Cheese;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Clam;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Dough;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Veggies;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

public interface IPizzaIngredientFactory {
 
	public IDough CreateDough();
	public ISauce CreateSauce();
	public ICheese CreateCheese();
	public List<IVeggies> CreateVeggies();
	public IPepperoni CreatePepperoni();
	public IClams CreateClam();
 
}