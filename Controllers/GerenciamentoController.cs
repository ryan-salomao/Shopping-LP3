using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Av3Shopping.Models;
using Av3Shopping.ViewModels;

namespace Av3Shopping.Controllers;

public class GerenciamentoController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public static List<LojaViewModel> lojas = new List<LojaViewModel>();

    public GerenciamentoController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult CadastrarLoja()
    {      
        return View();
    }

    public IActionResult VerificarCadastro([FromForm] int numero, [FromForm] int piso, [FromForm] string nome, [FromForm] string descricao, [FromForm] string categoria, [FromForm] string email)
    {
        foreach (var loja in lojas)
        {
            if(loja.Nome.Equals(nome))
            {
                ViewData["Nome"] = nome;
                return View("VerificarCadastro");
            }
        }        

        LojaViewModel novaLoja = new LojaViewModel(numero, piso, nome, descricao, categoria, email);
        lojas.Add(novaLoja);

        return View("CadastrarLoja");
    }

    public IActionResult DetalhesLoja(int numero)
    {       
        return View(lojas[numero]);
    }

    public IActionResult ListaDeLojas()
    {
        return View(lojas);
    }

    public IActionResult DeletarLoja(int numero)
    {
        foreach(var loja in lojas)
        {
            if(loja.Numero == numero)
            {
               lojas.Remove(loja);
            }
        }

        return View("DeletarLoja");
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}