class Program
{
    struct Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        public mostrar(nome){
            Console.WriteLine(nome)
        }
    }
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa()
        p1.nome = "nicolas";
        p1.altura = 1.74;
        p1.idade = 18;
        p1.mostrar(18)
    }
}