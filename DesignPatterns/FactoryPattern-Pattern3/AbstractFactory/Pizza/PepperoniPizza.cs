using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;

public class PepperoniPizza: Pizza {
	IPizzaIngredientFactory IngredientFactory;
 
	public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) {
		this.IngredientFactory = ingredientFactory;
	}
 
	public override void Prepare() {
		Console.WriteLine("Preparing " + Name);
		Dough = IngredientFactory.CreateDough();
		Sauce = IngredientFactory.CreateSauce();
		Cheese = IngredientFactory.CreateCheese();
		Veggies = IngredientFactory.CreateVeggies();
		Pepperoni = IngredientFactory.CreatePepperoni();
	}
}
