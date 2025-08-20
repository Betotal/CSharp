namespace Aula6
{
    class Funcionario
    {
        public string Nome { get; set; }
        public float Salario { get; set; }

        public virtual double CalcularBonus()
        {
            return 0;
        }
    }
}
