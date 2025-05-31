int NUMERO, MULTIPLICADOR, RESULTADO;

Console.Write("Digite um número para gerar sua tabuada: ");
NUMERO = Convert.ToInt32(Console.ReadLine());

MULTIPLICADOR = 0;

while (MULTIPLICADOR <= 10)
{
    RESULTADO = NUMERO * MULTIPLICADOR;
    Console.WriteLine($"{NUMERO} x {MULTIPLICADOR} = {RESULTADO}");
    MULTIPLICADOR += 1;
}