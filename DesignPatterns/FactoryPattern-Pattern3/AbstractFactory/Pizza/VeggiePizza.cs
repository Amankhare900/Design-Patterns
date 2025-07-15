using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;

public class VeggiePizza: Pizza {
	IPizzaIngredientFactory _ingredientFactory;
 
	public VeggiePizza(IPizzaIngredientFactory ingredientFactory) {
		_ingredientFactory = ingredientFactory;
	}
 
	public override void Prepare() {
		Console.WriteLine("Preparing " + Name);
		Dough = _ingredientFactory.CreateDough();
		Sauce = _ingredientFactory.CreateSauce();
		Cheese = _ingredientFactory.CreateCheese();
		Veggies = _ingredientFactory.CreateVeggies();
	}
}
