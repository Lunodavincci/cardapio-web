using CardapioWeb.Context;
using CardapioWeb.Models;
namespace CardapioWeb.Repositories
{
    public class ProdutoRespository: IProdutoRepository //herdando atributos do IProduto
    {
        private readonly AppDBContext _dbcontext; // essa classe precisa usar recurso do appDBcontext

        public ProdutoRespository(AppDBContext dbContext) //metodo construtor
        {
            _dbcontext = dbContext;
        }
        public IEnumerable<Produto> GetAll()
        {
            return _dbcontext.Produtos.ToList(); //tolist força a ser uma lista
        }
        public Produto GetById(int id)
        {
            return _dbcontext.Produtos.FirstOrDefault(p => p.Id == id); //busca o id individualmente
        }
        public IEnumerable<Produto> GetByPreferido()
        {
            return _dbcontext.Produtos.Where(p => p.Produto_Preferido).ToList();   
        }
    }
}
