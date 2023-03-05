internal class Program
{
    private static void Main(string[] args)
    {
        int conta, pago, troco, nota;

        Console.WriteLine("Digite o valor da conta: ");
        conta = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor pago: ");
        pago = int.Parse(Console.ReadLine());

        troco = (pago - conta);

        nota = (int)troco / 100;
        Console.WriteLine("Notas de 100: " + nota);
        troco %= 100;

        nota = (int)troco / 50;
        Console.WriteLine("Notas de 50: " + nota);
        troco %= 50;

        nota = (int)troco / 20;
        Console.WriteLine("Notas de 20: " + nota);
        troco %= 20;

        nota = (int)troco / 10;
        Console.WriteLine("Notas de 10: " + nota);
        troco %= 10;

        nota = (int)troco / 5;
        Console.WriteLine("Notas de 5: " + nota);
        troco %= 5;

        nota = (int)troco / 2;
        Console.WriteLine("Notas de 2: " + nota);
        troco %= 2;

        if (troco == 1)
        {
            Console.WriteLine("Poderia doar 1 real ao churrasco da firma?");
        }

    }
}