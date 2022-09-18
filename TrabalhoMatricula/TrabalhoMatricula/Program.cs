using TrabalhoMatricula;

int index = 10;
Aluno[] aluno = new Aluno[index];

for (int i = 0; i < index; i++)
{
    aluno[i] = new Aluno();
}

aluno[0].Name = "Fernando";
aluno[0].MotherName = "Joseline";
aluno[0].Phone = "47 991463256";
aluno[0].DateBorn = "26/02/2004";
aluno[0].ActualState = "SC";
aluno[0].Adress = "Rua Bahia,355";

Console.WriteLine($"Seja bem vindo a escola E.E Frederico Hardt\n");
bool userUsing = true;
while (userUsing)
{
    Console.WriteLine("1 - Cadastrar aluno\n2- Expulsar aluno\n3 - Checar estado do aluno\n4 - Encerrar\n");
    Console.Write("Digite sua escolha: ");
    var userInputChoice = Console.ReadLine();
    if (userInputChoice == "1")
    {
        int contador = 1;
        Console.Clear();
        Console.WriteLine("Quantos alunos deseja cadastrar? Limite de 9");
        int userInputQtd = Convert.ToInt32(Console.ReadLine());
        if (userInputQtd > 9)
        {
            Console.WriteLine("Não é permitido colocar mais de 9");
        }
        else
        {
            for (int i = 0; i < userInputQtd; i++)
            {
                if (aluno[i].Name == null)
                {
                    aluno[i].StudentRegister(contador);
                    contador++;
                }
                else
                {
                    userInputQtd++;
                }
            }
        }
    }
    if (userInputChoice == "2")
    {
        int contador = 1;
        Console.Clear();
        Console.WriteLine("Digite o nome do aluno para expulsar");
        for (int i = 0; i < aluno.Length; i++)
        {
            if (aluno[i].Name == null)
            {
            }
            else
            {
                Console.WriteLine($"{contador} - Aluno: {aluno[i].Name} Mãe: {aluno[i].MotherName}");
                contador++;
            }
        }
        string userInputStdChoice = Console.ReadLine();
        for (int i = 0; i < aluno.Length; i++)
        {
            if (aluno[i].Name == null)
            {
            }
            else
            {
                aluno[i].RemoveStudent(userInputStdChoice);
            }
        }
    }
    if (userInputChoice == "3")
    {
        Console.Clear();
        for (int i = 0; i < aluno.Length; i++)
        {
            if (aluno[i].Name == null)
            {
            }
            else
            {
                Console.WriteLine($"Nome: {aluno[i].Name} Nota: {aluno[i].Process = aluno[i].Status()}");
            }
            Thread.Sleep(250);
        }
    }
    if (userInputChoice == "4")
    {
        Thread.Sleep(350);
        Console.WriteLine("Encerrando...");
        userUsing = false;
    }
}