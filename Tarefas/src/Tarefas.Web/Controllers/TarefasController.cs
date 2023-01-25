using Microsoft.AspNetCore.Mvc;
using Tarefas.Web.Models;

namespace Tarefas.Web.Controllers;

public class TarefasController : Controller
{

    public IActionResult Create()
    {
        return View();
    }

    public IActionResult Index()
    {
        var listaDeTarefas = new List<TarefaViewModel>()
        {
            new TarefaViewModel() { Titulo = "Escovar os Dentes", Descricao = "Todas as manhãs"},
            new TarefaViewModel() { Titulo = "Arrumar a cama", Descricao = "Todas as manhãs"},
            new TarefaViewModel() { Titulo = "Tirar o lixo", Descricao = "Segunda, quarta e sexta"},
        };
        return View(listaDeTarefas);
    }

}