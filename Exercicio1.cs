using System;
public class Pagamento
{
    public virtual void ProcessarPagamento()
    {
        Console.WriteLine("Processando pagamento genérico...");
    }
}
public class CartaoCredito : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando Cartão de Crédito...");
    }
}
public class BoletoBancario : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Gerando Boleto...");
    }
}
public class Pix : Pagamento
{
    public override void ProcessarPagamento()
    {
        Console.WriteLine("Processando Pix...");
    }
}

class Program
{
    static void Main()
    {
        Pagamento[] meusPagamentos = new Pagamento[3];
        meusPagamentos[0] = new CartaoCredito();
        meusPagamentos[1] = new BoletoBancario();
        meusPagamentos[2] = new Pix();
        for (int i = 0; i < meusPagamentos.Length; i++)
        {
            meusPagamentos[i].ProcessarPagamento();
        }
        Console.WriteLine("\nPagamentos processados");
    }
}
