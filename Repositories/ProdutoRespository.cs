using CardapioWeb.Context;
using CardapioWeb.Models;
namespace CardapioWeb.Repositories
{
    public class ProdutoRespository: IProdutoRepository //herdando atributos do IProduto
    {
        private readonly AppDBContext _dbContext; // essa classe precisa usar recurso do appDBcontext

        public ProdutoRespository(AppDBContext dbContext) //metodo construtor
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Produto> GetAll()
        {
            return _dbContext.Produtos.ToList(); //tolist força a ser uma lista
        }
        public Produto GetById(int id)
        {
            return _dbContext.Produtos.FirstOrDefault(p => p.Id == id); //busca o id individualmente
        }
        public IEnumerable<Produto> GetByPreferido()
        {
            return _dbContext.Produtos.Where(p => p.Produto_Preferido).ToList();   
        }
    }
}
