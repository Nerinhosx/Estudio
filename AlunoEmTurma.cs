using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estudio
{
    class AlunoEmTurma
    {
        private string cpfA;
        private int idT;

        public string CpfA { get => cpfA; set => cpfA = value; }
        public int IdT { get => idT; set => idT = value; }

        public AlunoEmTurma(string cpfA, int idT)
        {
            this.cpfA = cpfA;
            this.idT = idT;
        }
    }
}
