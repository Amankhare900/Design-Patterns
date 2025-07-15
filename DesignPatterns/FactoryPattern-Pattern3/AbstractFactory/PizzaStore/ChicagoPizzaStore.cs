
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Factory;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaStore;
public class ChicagoPizzaStore : PizzaStore
{

    protected override Pizza.Pizza CreatePizza(String item)
    {
        Pizza.Pizza pizza = null;
        IPizzaIngredientFactory ingredientFactory = new ChicagoPizzaIngredientFactory();

        if (item.Equals("cheese"))
        {
            pizza = new CheesePizza(ingredientFactory);
            pizza.SetName("Chicago Style Cheese Pizza");
        }
        else if (item.Equals("veggie"))
        {
            pizza = new VeggiePizza(ingredientFactory);
            pizza.SetName("Chicago Style Veggie Pizza");
        }
        else if (item.Equals("clam"))
        {
            pizza = new ClamPizza(ingredientFactory);
            pizza.SetName("Chicago Style Clam Pizza");

        }
        else if (item.Equals("pepperoni"))
        {
            pizza = new PepperoniPizza(ingredientFactory);
            pizza.SetName("Chicago Style Pepperoni Pizza");
        }
        return pizza;
    }
}