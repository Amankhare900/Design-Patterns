using System.Text;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Cheese;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Clam;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Dough;
using PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.PizzaIngredient.Veggies;

namespace PRACTICEPATTERN.DesignPatterns.FactoryPattern.AbstractFactory.Pizza;

public abstract class Pizza
{
    public string Name { get; set; } = "";
    public IDough? Dough { get; set; }
    public ISauce? Sauce { get; set; }
    public List<IVeggies>? Veggies { get; set; }
    public ICheese? Cheese { get; set; }
    public IPepperoni? Pepperoni { get; set; }
    public IClams? Clam { get; set; }
    public abstract void Prepare();

    public void Bake()
    {
        Console.WriteLine("Bake for 25 minutes at 350");
    }
    public void Cut()
    {
        Console.WriteLine("Cutting the pizza into diagonal slices");
    }
    public void Box()
    {
        Console.WriteLine("Place pizza in official PizzaStore box");
    }
    public void SetName(string name)
    {
        this.Name = name;
    }

    public string GetName()
    {
        return Name;
    }
    public string ToString() {
		StringBuilder result = new();
		result.Append("---- " + Name + " ----\n");
		if (Dough != null) {
			result.Append(Dough);
			result.Append('\n');
		}
		if (Sauce != null) {
			result.Append(Sauce);
			result.Append('\n');
		}
		if (Cheese != null) {
			result.Append(Cheese);
			result.Append('\n');
		}
		if (Veggies != null) {
			for (int i = 0; i < Veggies.Count; i++) {
				result.Append(Veggies[i]);
				if (i < Veggies.Count - 1) {
					result.Append(", ");
				}
			}
			result.Append('\n');
		}
		if (Clam != null) {
			result.Append(Clam);
			result.Append('\n');
		}
		if (Pepperoni != null) {
			result.Append(Pepperoni);
			result.Append('\n');
		}
		return result.ToString();
	}

}