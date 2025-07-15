using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Cheese;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Clam;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Dough;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Pepperoni;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Sauce;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Veggies;

public class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory 
{
	public IDough CreateDough() {
		return new ThickCrustDough();
	}

	public ISauce CreateSauce() {
		return new PlumTomatoSauce();
	}

	public ICheese CreateCheese() {
		return new MozzarellaCheese();
	}

    public List<IVeggies> CreateVeggies() => [ new BlackOlives(),
                              new Spinach(),
                              new Eggplant() ];

    public IPepperoni CreatePepperoni() {
		return new SlicedPepperoni();
	}

	public IClams CreateClam() {
		return new FrozenClams();
	}
}
