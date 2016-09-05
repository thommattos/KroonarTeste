using System;

namespace Teste
{
    class Porta
    {
        public int PortaID { get; set; }
        public string Status { get; set; }

        public Porta() {
            Status = "trancada";
        }

        public void ObterStatus()
        {
            Console.WriteLine("A porta está " + Status);
        }

        public void Destrancar()
        {
            if (Status == "trancada")
            {
                Status = "encostada";
            }

            ObterStatus();
            //Console.WriteLine("A porta está " + Status);
        }

        public void Abrir()
        {
            Destrancar();

            if (Status == "encostada")
            {
                Status = "aberta";
            }

            //Console.WriteLine("A porta está " + Status)
            ObterStatus();
        }

    }
}
