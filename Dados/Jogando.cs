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
        public int Ptsvitoria { get; set; }
        public int Ptsderrota { get; set; }
        public int Ptsvitoria2 { get; set; }
        public int Ptsderrota2 { get; set; }

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
        
            public int vitoria()
            {
                if (JogadaJogador1 == Jogada1 + Jogada2)
                {
                    return JogadaJogador1;
                }
                else
                {
                Computador = z.Next(1, 7);
                return Computador ;
                }
            }
            public int derrota()
            {
                if (JogadaJogador1 <= Jogada1 + Jogada2)
                {
                
                Computador = Jogada1 + Jogada2;
                    return Computador;
                }
                else
                {
                    return JogadaJogador1;
                }
            }

        public void Pontuaçao()
        {
            Ptsvitoria = JogadaJogador1;
        }
    }
}
