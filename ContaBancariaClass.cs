using System;


// abstração. ex: sistema bancario
public abstract class ContaBancaria
{
	public required string NumeroConta {  get; set; }
	public decimal Saldo { get; set; }

    // Método abstrato: as classes derivadas devem implementar esse método
    public abstract void Sacar(decimal valor);

    public void Depositar(decimal valor)
	{
		Saldo += valor;
		Console.WriteLine($"deposito de {valor}. Saldo atual de {Saldo:C}");
	}
}

// classe derivada da ContaBancaria

public class ContaPoupança : ContaBancaria
{
	public override void Sacar(decimal valor)
	{
		if(Saldo>=valor)
		{
            Saldo -= valor;
            Console.WriteLine($"saque de {valor} realizado. Saldo atual de {Saldo}");
        }
		else
		{
			Console.WriteLine($"Saldo insuficiente. Saldo atual de {Saldo}");
		}
		
	}
}
