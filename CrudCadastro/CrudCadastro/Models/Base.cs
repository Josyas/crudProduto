namespace CrudCadastro.Models
{
    public abstract class Base
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }
    }
}
