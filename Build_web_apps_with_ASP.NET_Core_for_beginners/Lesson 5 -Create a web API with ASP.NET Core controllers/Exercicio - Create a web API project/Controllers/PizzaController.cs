using ContosoPizza.Models;
using ContosoPizza.Services;
using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Conrtollers;

[ApiController]
[Route("[controller]")]

public class PizzaController : ControllerBase
{
    public PizzaController()
    {
    }

    //* Get
    [HttpGet]
    public ActionResult<List<Pizza>> GetAll()
    {
        return PizzaService.GetAll();
    }

    //* Get One
    [HttpGet("{id}")]
    public ActionResult<Pizza> findOne(int id)
    {
        var pizza = PizzaService.GetOnePizza(id);

        if(pizza == null)
        {
            return NotFound();
        }

        return pizza;
    }

    //* Post
    [HttpPost("create")]
    public IActionResult CreatePizza(Pizza newPizza)
    {
        PizzaService.AddPizza(newPizza);
        return CreatedAtAction(nameof(findOne), new {id = newPizza.Id}, newPizza);
    }

    //*Put
    [HttpPut("updateWithPut/{id}")]
    public IActionResult updatePizza(int Id, Pizza pizza)
    {
        //* verify if the pizzar what we wanna update has the sane id has the one we sent throw params
        if(Id!= pizza.Id)
        {
            return BadRequest();
        }

        //* verify if the pizza exists
        var existingPizza = PizzaService.GetOnePizza(Id);
        if(existingPizza is null)
        {
            return NotFound();
        }

        PizzaService.UpdatePizza(pizza);

        return NoContent();
    }

    [HttpPost("updateWithPost/{id}")]
    public IActionResult updatePizzaButPost(int Id, Pizza pizza)
    {
        //* verify if the pizzar what we wanna update has the sane id has the one we sent throw params
        if(Id!= pizza.Id)
        {
            return BadRequest();
        }

        //* verify if the pizza exists
        var existingPizza = PizzaService.GetOnePizza(Id);
        if(existingPizza is null)
        {
            return NotFound();
        }

        PizzaService.UpdatePizza(pizza);

        return NoContent();
    }

    [HttpDelete("delete/{id}")]
    public IActionResult deletePizza(int id)
    {
        var pizza = PizzaService.GetOnePizza(id);

        if(pizza is null)
        {
            return NotFound();
        }

        PizzaService.DeletePizza(id);

        return NoContent();
    }
}
