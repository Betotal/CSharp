namespace Aula6
{
    class Desenvolvedor : Funcionario
    {
        public override double CalcularBonus()
        {
            return Salario * 0.1;
        }
    }
}
