using QuickBuy.Dominio.Enumerados;

namespace QuickBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool EhBoleto
        { get { return Id == (int)TipoFormaPagamentoENum.Boleto; } }
        public bool EhCartaoCredito
        { get { return Id == (int)TipoFormaPagamentoENum.CartaoCredito; } }
        public bool EhDeposito
        { get { return Id == (int)TipoFormaPagamentoENum.Deposito; } }
        public bool NaoFoiDefinido
        { get { return Id == (int)TipoFormaPagamentoENum.NaoDefinido; } }
    }
}
