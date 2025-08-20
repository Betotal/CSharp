namespace Aula6
{
    class Gerente : Funcionario
    {
        public override double CalcularBonus()
        {
            return Salario * 0.20;
        }
    }
}
