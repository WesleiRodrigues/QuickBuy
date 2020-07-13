using System.Collections.Generic;

namespace QuickBuy.Dominio.Entidades
{
    public class Usuario : Entidades
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        
        //Um usuário pode ter um ou mais pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email)) AdicionarCritica("E-mail não foi informado");
            if (string.IsNullOrEmpty(Senha)) AdicionarCritica ("Senha não foi informada");
        }
    }
}
