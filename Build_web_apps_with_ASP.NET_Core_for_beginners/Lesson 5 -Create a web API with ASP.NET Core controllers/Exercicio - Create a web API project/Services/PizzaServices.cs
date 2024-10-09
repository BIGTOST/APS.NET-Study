using ContosoPizza.Models;

namespace ContosoPizza.Services;

public static class PizzaService
{
    static List<Pizza> Pizzas {get;}
    static int nextId = 3;

    static PizzaService()
    {
        Pizzas = new List<Pizza>
        {
            new Pizza { Id = 1, Name = "Classic Italian", IsGlutenFree = false },
            new Pizza { Id = 2, Name = "Veggie", IsGlutenFree = true }
        };
    }

    public static List<Pizza> GetAll()
    {
        return Pizzas;
    }

    public static Pizza? GetOnePizza(int idPizza)
    {
        return Pizzas.FirstOrDefault( p => p.Id == idPizza);
    }

    public static void AddPizza(Pizza newPizza)
    {
        newPizza.Id = nextId++;
        Pizzas.Add(newPizza);
    }

    public static void UpdatePizza(Pizza updatedPizza)
    {
        var position = Pizzas.FindIndex(p => p.Id == updatedPizza.Id);
        if(position == -1)
        {
            return;
        }

        Pizzas[position] = updatedPizza;
    }

    public static void DeletePizza(int id)
    {
        var pizza = GetOnePizza(id);

        if(pizza is null)
        {
            return;
        }

        Pizzas.Remove(pizza);
    }

}
