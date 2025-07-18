namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaStore;

public abstract class PizzaStore
{

    protected abstract Pizza.Pizza CreatePizza(String item);

    public Pizza.Pizza OrderPizza(String type)
    {
        Pizza.Pizza pizza = CreatePizza(type);
        Console.WriteLine("--- Making a " + pizza.GetName() + " ---");
        pizza.Prepare();
        pizza.Bake();
        pizza.Cut();
        pizza.Box();
        return pizza;
    }
}