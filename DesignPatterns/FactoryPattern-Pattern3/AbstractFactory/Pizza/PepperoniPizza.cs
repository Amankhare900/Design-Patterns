using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;

public class PepperoniPizza: Pizza {
	IPizzaIngredientFactory _ingredientFactory;
 
	public PepperoniPizza(IPizzaIngredientFactory ingredientFactory) {
		_ingredientFactory = ingredientFactory;
	}
 
	public override void Prepare() {
		Console.WriteLine("Preparing " + Name);
		Dough = _ingredientFactory.CreateDough();
		Sauce = _ingredientFactory.CreateSauce();
		Cheese = _ingredientFactory.CreateCheese();
		Veggies = _ingredientFactory.CreateVeggies();
		Pepperoni = _ingredientFactory.CreatePepperoni();
	}
}
