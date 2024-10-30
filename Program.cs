namespace Curso_Filipe
{
    public class ContaBancariaClass
    {
        public static void Main()
        {
            ContaBancaria contaPoupanca = new ContaPoupança { NumeroConta = "ABC-00" };
            contaPoupanca.Depositar(200);
            contaPoupanca.Sacar(50);
        }
    }
}


