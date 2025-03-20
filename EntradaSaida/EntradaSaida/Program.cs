//Console.WriteLine("nicolas diovani");
//Console.Write("nicolas"); //mesma coisa do writeline mas n pula uma linha

//string nicolas = Console.ReadLine();
//Console.WriteLine(nicolas);
//int codigo = Console.Read();
//Console.WriteLine(codigo);
//Console.ReadKey();
//Console.ReadKey();
string nome1, nome2, nome3, nome4, auxiliar;

Console.Write("digite o nome 1: ");
nome1 = Console.ReadLine();

Console.Write("digite o nome 2: ");
nome2 = Console.ReadLine();

Console.Write("digite o nome 3: ");
nome3 = Console.ReadLine();

Console.Write("digite o nome 4: ");
nome4 = Console.ReadLine();

//mecanismo para inverter os nomes
auxiliar = nome1;
nome1 = nome4;
nome4 = auxiliar;
auxiliar = nome2;
nome2 = nome3;
nome3 = auxiliar;

Console.WriteLine("nome 4: " + nome4 + "\nnome 3: " + nome3 + "\nnome 2: " + nome2 + "\nnome 1: " + nome1);