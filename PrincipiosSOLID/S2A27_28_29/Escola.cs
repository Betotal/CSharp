using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace S2A27_28_29
{
    public class Escola : IDisposable
    {
        public String Nome { get; set; }
        private List<Departamento> Departamentos = new List<Departamento>();

        // Como é uma agregação, ou seja o departamento não existirá sem a Escola,
        // caberá a escola a criação do departamento
        public void AddDepartamento(string nome)
        {  //Composição
            Departamentos.Add(new Departamento(this, nome));  //passa a instacia da escola (this) e o nome do departamento
        }

        public void Dispose()
        {
            foreach (var Depto in Departamentos)
            {
                Depto.Dispose();
            }
        }
    }
}