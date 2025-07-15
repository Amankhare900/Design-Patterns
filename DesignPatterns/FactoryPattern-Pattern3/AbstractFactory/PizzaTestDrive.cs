using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaStore;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory;
public class PizzaTestDrive
{

    public static void Test()
    {
        PizzaStore.PizzaStore nyStore = new NYPizzaStore();
        PizzaStore.PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza.Pizza pizza = nyStore.OrderPizza("cheese");
        Console.WriteLine("Aman ordered a " + pizza.GetName() + "\n");

        pizza = chicagoStore.OrderPizza("cheese");
        Console.WriteLine("Nittin ordered a " + pizza.GetName() + "\n");

        pizza = nyStore.OrderPizza("clam");
        Console.WriteLine("Ayush ordered a " + pizza.GetName() + "\n");

        pizza = chicagoStore.OrderPizza("clam");
        Console.WriteLine("Keshav ordered a " + pizza.GetName() + "\n");

        pizza = nyStore.OrderPizza("pepperoni");
        Console.WriteLine("Gaurav ordered a " + pizza.GetName() + "\n");

        pizza = chicagoStore.OrderPizza("pepperoni");
        Console.WriteLine("Manish ordered a " + pizza.GetName() + "\n");

        pizza = nyStore.OrderPizza("veggie");
        Console.WriteLine("Gaurav ordered a " + pizza.GetName() + "\n");

        pizza = chicagoStore.OrderPizza("veggie");
        Console.WriteLine("Rahul ordered a " + pizza.GetName() + "\n");
    }
}