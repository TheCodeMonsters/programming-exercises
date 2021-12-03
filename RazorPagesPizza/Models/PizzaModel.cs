using Microsoft.AspNetCore.Mvc;
using RazorPagesPizza.Models;
using RazorPagesPizza.Services;

public class PizzaModel{
    [BindProperty]
    public Pizza NewPizza { get; set; } = new();

    public IActionResult OnPostDelete(int id)
    {
        PizzaService.Delete(id);
        return RedirectToAction("Get");
    }

}