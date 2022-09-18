namespace TrabalhoMatricula
{
    public class Aluno
    {
        public string Name { get; set; }
        public string MotherName { get; set; }
        public string BornState { get; set; }
        public string ActualState { get; set; }
        public string DateBorn { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public int Process { get; set; }
        public void StudentRegister(int contador)
        {
            Console.Write($"Digite o nome do aluno {contador}: ");
            Name = Console.ReadLine();
            Console.Write($"Digite o nome da mãe do aluno {contador}: ");
            MotherName = Console.ReadLine();
            Console.Write($"Digite o estado no qual o aluno {contador} nasceu: ");
            BornState = Console.ReadLine();
            Console.Write($"Digite o estado atual em que o aluno {contador} reside: ");
            ActualState = Console.ReadLine();
            Console.Write($"Digite a data de nascimento do aluno {contador}: ");
            DateBorn = Console.ReadLine();
            Console.Write($"Digite o telefone do aluno {contador}: ");
            Phone = Console.ReadLine();
            Console.Write($"Digite o endereço do aluno {contador}: ");
            Adress = Console.ReadLine();
            Console.WriteLine($"{Name} matriculado");
        }
        public void RemoveStudent(string userInputName)
        {
            if (userInputName == Name)
            {
                Console.WriteLine($"Clique ENTER para expulsar {Name}");
                Console.ReadKey();
                Console.WriteLine($"{Name} expulso");
                Name = null;
            }
            else
            {
            }
        }
        public int Status()
        {
            Process = 0;
            Random random = new Random();
            Random rando1 = new Random();

            Process = (random.Next(10) + random.Next(10)) / 2;
            return Process;
        }
    }
}