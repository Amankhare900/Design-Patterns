using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;

public class ClamPizza: Pizza {
	IPizzaIngredientFactory _ingredientFactory;
 
	public ClamPizza(IPizzaIngredientFactory ingredientFactory) {
		_ingredientFactory = ingredientFactory;
	}
 
	public override void Prepare() {
		Console.WriteLine("Preparing " + Name);
		Dough = _ingredientFactory.CreateDough();
		Sauce = _ingredientFactory.CreateSauce();
		Cheese = _ingredientFactory.CreateCheese();
		Clam = _ingredientFactory.CreateClam();
	}
}
