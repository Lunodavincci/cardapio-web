using CardapioWeb.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CardapioWeb.Controllers
{
    public class ProdutoController : Controller //o controller recebera as informações e inviará para o bd
    {
        private readonly IProdutoRepository _produtoRepository;
        public ProdutoController(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }
        public IActionResult ListarProdutos() //metodos sempre retornam uma ação no controller
        {
            var produtos = _produtoRepository.GetAll();
            return View();
        }
    }
}
