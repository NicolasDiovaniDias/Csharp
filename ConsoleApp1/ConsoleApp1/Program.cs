class Program
{
    struct Pessoa
    {
        public string nome;
        public int idade;
        public double altura;
        //mostrar(string nome, string idade)
        //{
            
        //}
        public string Retorno(string nome, int idade)
        {
            string junto = nome + idade.ToString();
            Console.WriteLine(junto);
            return junto;
        }
    }
    static void Main(string[] args)
    {
        Pessoa p1 = new Pessoa();
        p1.nome = "nicolas";
        p1.altura = 1.74;
        p1.idade = 18;
        Pessoa p2 = new Pessoa()
        {
            nome="antonio",
            idade=13,
            altura=1.45
        };
        Console.WriteLine(p1.Retorno("nicolas", 19));
    }
}