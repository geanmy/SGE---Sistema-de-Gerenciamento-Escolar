namespace SGE
{
    internal class program
    {
        struct student
        {
            public string name { get; set; }
            public ushort pontuation { get; set; }
        }

        static void Main (string[] args)
        {
            student[] students = new student[5];
            ushort opc, count = 0;

            do
            {
                opc = GetUserOption();

                switch(opc)
                {
                    case 1:
                        //TODO: Cadastrar Aluno.
                        Console.Write("Digite o nome do aluno: ");
                        students[count].name = Console.ReadLine();

                        Console.Write("\nDigite a nota do aluno: ");

                        if(ushort.TryParse(Console.ReadLine(), out ushort result))
                        {
                            students[count++].pontuation = result;
                        } else
                        {
                            throw new ArgumentOutOfRangeException();
                        }
                        break;
                    case 2:
                        //TODO: Listar alunos.
                        for(ushort i = 0; i < students.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(students[i].name))
                            {
                                Console.WriteLine($"Aluno: {students[i].name} Nota: {students[i].pontuation}");
                            } else
                            {
                                break;
                            }
                        }
                        break;
                    case 3:
                        //TODO: Cálcular média geral;
                        float sum = 0;

                        for (ushort i = 0; i < students.Length; i++)
                        {
                            if (!string.IsNullOrEmpty(students[i].name))
                            {
                                sum += students[i].pontuation;
                            }
                            else
                            {
                                break;
                            }
                        }

                        Console.WriteLine($"Média geral: {sum / count}\n");
                        break;
                    case 4:
                        return;
                    default:
                        break;
                }
            } while (true);
        }

        private static ushort GetUserOption()
        {
            Console.Write("SGE - Sistema de Gerenciamento Escolar\n\n1 - Cadastrar aluno\n2 - Listar alunos\n3 - Cálcular média geral\n4 - Sair\n\nOpção: ");

            if (ushort.TryParse(Console.ReadLine(), out ushort opc))
            {
                return opc;
            } else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}