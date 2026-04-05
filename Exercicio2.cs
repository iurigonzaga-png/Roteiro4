public abstract class Funcionario
{
    public string Nome;
    public double SalarioBase;
    public abstract double CalcularSalario();
}
public class Gerente : Funcionario
{
    public double BonusChefe;
    public override double CalcularSalario()
    {
        return SalarioBase + BonusChefe;
    }
}
public class Programador : Funcionario
{
    public int HorasExtras;
    public double ValorHoraExtra;

    public override double CalcularSalario()
    {
        return SalarioBase + (HorasExtras * ValorHoraExtra);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Gerente gerente = new Gerente
        {
            Nome = "João",
            SalarioBase = 5000,
            BonusChefe = 2000
        };
        Programador programador = new Programador
        {
            Nome = "Maria",
            SalarioBase = 3000,
            HorasExtras = 10,
            ValorHoraExtra = 10
        };
        Console.WriteLine($"Salário do gerente {gerente.Nome}: {gerente.CalcularSalario()}");
        Console.WriteLine($"Salário do programador {programador.Nome}: {programador.CalcularSalario()}");
    }
}
