namespace PessoaJ
{
    class Pessoa_Juridica : Clientes.Clientes
    {
        public string cnpj {get; set;}
        public string ie {get; set;}

        public override void Pagar_imposto(float v)
        {
            this.valor = v;
            this.valor_imposto = this.valor * 20 / 100;
            this.total = this.valor + this.valor_imposto;
        }
    }
}