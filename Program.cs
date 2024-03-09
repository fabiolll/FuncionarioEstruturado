namespace FuncionarioEstruturado;

class Program
{
    static void Main(string[] args)
    {
        string nome;
        double salarioB, imposto, salarioL, porcentagem;
        Console.WriteLine("Salario funcionario!");
        Console.WriteLine("Nome: ");
        nome = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Salario bruto: ");
        salarioB = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Imposto: ");
        imposto = Convert.ToInt32(Console.ReadLine());
        salarioL = salarioB - imposto;
        Console.WriteLine($"Nome: {nome}\nSalario bruto: {salarioB}\nImposto: {imposto}\nSalario liquido: {salarioL}\n");
        Console.WriteLine("Informe a porcentagem para o novo salario bruto: ");
        porcentagem = Convert.ToInt32(Console.ReadLine());
        porcentagem = ((salarioB*porcentagem)/100)+salarioB;
        salarioL = porcentagem - imposto;
        Console.WriteLine($"Novo salario\nNome: {nome}\nSalario bruto: {porcentagem}\nImposto: {imposto}\nSalario liquido: {salarioL}\n");

    }
}
