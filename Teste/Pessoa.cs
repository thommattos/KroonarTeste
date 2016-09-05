namespace Teste
{
    class Pessoa
    {
        public int PessoaID { get; set; }
        public int Acao { get; set; }

        public Pessoa() { }

        public void AbrirPorta()
        {
            Porta acesso = new Porta();

            acesso.ObterStatus();

            if (acesso.Status == "trancada")
            {
                acesso.Abrir();
            }
        }
    }
}
