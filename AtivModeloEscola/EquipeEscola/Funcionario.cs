using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivModeloEscola.EquipeEscola
{
    // Classe abstrata Funcionario
    public abstract class Funcionario
    {
        // Atributos
        public string Nome { get; set; }
        public int Idade { get; set; }
        public float Salario { get; set; }

        // Método abstrato para implementar nas subclasses
        public abstract float CalcularSalario();
    }
}
