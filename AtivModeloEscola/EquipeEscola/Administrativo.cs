using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtivModeloEscola.EquipeEscola
{
    // Subclasse Administrativo
    public class Administrativo : Funcionario
    {
        // Novo atributo Setor que o funcionário trabalha
        public string Setor { get; set; }

        // Método abstrato CalcularSalario com bônus de 5% no salário base
        public override float CalcularSalario()
        {
            // Usando o float, por isso o f depois do número
            return Salario * 1.05f;
        }
    }
}
