using System;
using System.Collections.Generic;
using System.Text;

namespace Dados
{
    class Jogando
    {
        Random z = new Random();
        public int JogadaJogador1 { get; set; }
        public int Jogada1 { get; set; }
        public int Jogada2 { get; set; }
        public bool Vitoria { get; set; }
        public bool Derrota { get; set; }

        public int Computador { get; set; }
        public void Resultado()
        {
            Jogada1 = z.Next(1, 7);
            Jogada2 = z.Next(1, 7);

            if (Jogada1 + Jogada2 == JogadaJogador1)
            {
                do
                {
                    Computador = z.Next(1, 7);
                } while (Computador == JogadaJogador1);
            }
   
        }
    }
}
