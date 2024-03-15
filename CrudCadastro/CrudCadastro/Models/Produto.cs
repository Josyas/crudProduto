using System.ComponentModel.DataAnnotations.Schema;

namespace CrudCadastro.Models
{
    public class Produto : Base
    {
        public string? Descricao { get; set; }
        public DateTime DataValidade { get; set; }
        public double Valor {  get; set; }
        public int Idcategoria { get; set; }
        public Categoria? Categoria { get; set; }
    }
}
