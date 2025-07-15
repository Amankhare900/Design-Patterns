using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;

public class CheesePizza: Pizza {
	IPizzaIngredientFactory IngredientFactory;
 
	public CheesePizza(IPizzaIngredientFactory ingredientFactory) {
		this.IngredientFactory = ingredientFactory;
	}
 
	public override void Prepare() {
		Console.WriteLine("Preparing " + Name);
		Dough = IngredientFactory.CreateDough();
		Sauce = IngredientFactory.CreateSauce();
		Cheese = IngredientFactory.CreateCheese();
	}
}
