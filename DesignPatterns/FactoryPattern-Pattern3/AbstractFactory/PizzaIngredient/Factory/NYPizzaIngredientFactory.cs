using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Cheese;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Clam;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Dough;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Pepperoni;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Sauce;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Veggies;

public class NYPizzaIngredientFactory: IPizzaIngredientFactory {
 
	public IDough CreateDough() {
		return new ThinCrustDough();
	}
 
	public ISauce CreateSauce() {
		return new MarinaraSauce();
	}
 
	public ICheese CreateCheese() {
		return new ReggianoCheese();
	}

    public List<IVeggies> CreateVeggies() => [new Garlic(), new Onion(), new Mushroom(), new RedPepper()];

    public IPepperoni CreatePepperoni() {
		return new SlicedPepperoni();
	}

	public IClams CreateClam() {
		return new FreshClams();
	}
}