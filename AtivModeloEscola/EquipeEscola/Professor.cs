using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivModeloEscola.EquipeEscola
{
    // Subclasse Professor
    public class Professor : Funcionario
    {
        // Novo atributo Disciplina que o professor leciona
        public string Disciplina { get; set; }

        // Método abstrato CalcularSalario com bônus de 10% no salário base
        public override float CalcularSalario()
        {
            // Usando o float, por isso o f depois do número
            return Salario * 1.1f;
        }
    }
}
