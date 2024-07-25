using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CardapioWeb.Models
{
    [Table("Produtos")]//referencia a que bd o codigo vai se referenciar
    public class Produto
    {
        [Key] //declara a classe como sendo chave primaria no bd
        public int Id { get; set; }
        [Display(Name = "Nome do Produto")] //criar um 'apelido' para o campo 
        [Required(ErrorMessage ="Campo Obrigatório")] //mostra para o usuário uma mensagem de erro caso nao escreva nd
        [MinLength(5, ErrorMessage = "mais de {0} caraceres")]//qtd minima de caracteres

        public string Nome { get; set; }
        [Display(Name = "Descrição curta do produto")]
        [Required (ErrorMessage = "Campo obrigatório")]

        public string Descricao_Curta { get; set;}
        [Display(Name = "Descrição detalhada do produto")]
        [Required(ErrorMessage = "Campo obrigatório")]

        public string Descricao_Detalhada { get; set;}

        public decimal Preco { get; set;}

        public string Local_Imagem { get; set;}

        public bool Produto_Preferido { get; set; }

        public string Em_Estoque { get; set;}

        public virtual Categoria Categoria { get; set;} //conxeão com o bd estrangeiro
    }
}
