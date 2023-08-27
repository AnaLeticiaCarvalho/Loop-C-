
// Menu com while

string option;

while(true)
{
    Console.WriteLine("Digite a sua opção: ");
    Console.WriteLine("1 - Cadastrar cliente ");
    Console.WriteLine("2 - Buscar cliente ");
    Console.WriteLine("3 - Apagar cliente");
    Console.WriteLine("4 - Encerrar ");

    option = Console.ReadLine();

    switch (option)
    {
        case "1":
            Console.WriteLine("Cadastro de cliente");
            break;

        case "2":
            Console.WriteLine("Buscar cliente");
            break;

        case "3":
            Console.WriteLine("Apagar cliente");
            break;

        case "4":
            Console.WriteLine("Encerrar");
            Environment.Exit(0);
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;

    }




}










// Do While

/*int soma = 0, numero = 0;
do
{
    Console.WriteLine("Digite um número: (0 para parar) ");
    numero = Convert.ToInt32(Console.ReadLine());
    soma += numero;

} while (numero != 0);

Console.WriteLine("A soma de todos os números digitados é: {soma}");*/


// While

/*int num = 5;
int contador = 0;


    {
            Console.WriteLine($"{num} x {contador} =  {num * contador}");
            contador ++;

}
*/



/*int numero = 5;

for (int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} =  {numero * contador}");
}
*/














