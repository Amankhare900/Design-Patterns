using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaStore;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory;
public class PizzaTestDrive
{

    public static void Test()
    {
        PizzaStore.PizzaStore nyStore = new NYPizzaStore();
        PizzaStore.PizzaStore chicagoStore = new ChicagoPizzaStore();

        Pizza.Pizza pizza = nyStore.orderPizza("cheese");
        Console.WriteLine("Aman ordered a " + pizza + "\n");

        pizza = chicagoStore.orderPizza("cheese");
        Console.WriteLine("Nittin ordered a " + pizza + "\n");

        pizza = nyStore.orderPizza("clam");
        Console.WriteLine("Ayush ordered a " + pizza + "\n");

        pizza = chicagoStore.orderPizza("clam");
        Console.WriteLine("Keshav ordered a " + pizza + "\n");

        pizza = nyStore.orderPizza("pepperoni");
        Console.WriteLine("Gaurav ordered a " + pizza + "\n");

        pizza = chicagoStore.orderPizza("pepperoni");
        Console.WriteLine("Manish ordered a " + pizza + "\n");

        pizza = nyStore.orderPizza("veggie");
        Console.WriteLine("Gaurav ordered a " + pizza + "\n");

        pizza = chicagoStore.orderPizza("veggie");
        Console.WriteLine("Rahul ordered a " + pizza + "\n");
    }
}