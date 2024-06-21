using CardapioWeb.Models;
namespace CardapioWeb.Repositories
{
    public interface IProdutoRepository
    {
        IEnumerable <Produto> GetAll(); //metódo que vai retornar a lista de produtos
        IEnumerable <Produto> GetByPreferido(); //lista que busca vários produtos
        Produto GetById(int id); //busca pelo id
    }
}
