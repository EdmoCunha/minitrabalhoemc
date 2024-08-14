// // See https://aka.ms/new-console-template for more information

// //tipo de variasveis
// Console.WriteLine("Hello, World!");
// int x = 10;
// double pi = 3.1415;
// char letra = 'M';
// bool istrue = true;
// string texto = "5";

// //var u = "texto";

// double outroValor ;
// //conversao implicita

// outroValor = x;
// //conversai explicita

// int valorInteiro = (int) pi;

// //conversao explicita com a classe convert
// int y = Convert.ToInt32(texto);

// //operadores
// //*/+- =, ++
// int numero;
// Console.WriteLine("Digite um número:");
// numero =Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("O usuario digitou" + numero);
// //interpolação de strings
// Console.WriteLine($"O dobro do que o usuário digitou: {numero * 2}");




Console.WriteLine("Digite o primeiro número:");
double numero1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Digite o segundo número:");
double numero2 = Convert.ToDouble(Console.ReadLine());

double soma = numero1 + numero2;
double subtracao = numero1 - numero2;
double multiplica = numero1 * numero2;
double divisao = numero1 / numero2;

Console.WriteLine("A soma dos números é: " + soma);


Console.WriteLine($"A subtração dos números é: {subtracao}");


Console.WriteLine("A multiplicação dos números é: {0}", multiplica);


Console.WriteLine($"A divisão dos números é: {divisao}");





