namespace access_modifiers
{
    
    internal class Program
    {
        
        static string[] No = new string[0];
        static Group group = new Group();

        static void Main(string[] args)
        {
            int studentLimit;
            do
            {
                Console.WriteLine("No deyerini daxil edin(2 boyuk herf ve 3 reqem):");
                string inputNo = Console.ReadLine();
                if (IsValidNo(inputNo))
                {
                    No = new string[] { inputNo };
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis No deyeridi. Yeniden yoxlayin.");
                }
            } while (true);


            do
            {
                Console.WriteLine(" Student Limit deyerini daxil edin: (0 ve 20 arasi ):");
                if (int.TryParse(Console.ReadLine(), out studentLimit) && studentLimit >= 0 && studentLimit <= 20)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Yanlis  Student Limit deyeridir. Yeniden yoxlayin.");
                }
            } while (true);

            

            string answer;

            do
            {
                Console.WriteLine("Secim etmek isteyirsiniz mi? (beli ve ya xeyr)");
                answer = Console.ReadLine();

                if (answer == "beli")
                {
                    ShowMenu();
                }
                else if (answer == "xeyr")
                {
                    break;
                }

            } while (answer != "xeyr");

            static void ShowMenu()
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. Telebe elave et:");
                Console.WriteLine("2. Butun telebelere bax:");
                Console.WriteLine("3. Telebeler uzre axtaris et:");
                Console.WriteLine("0. Proqrami bitir!");
                Console.WriteLine(" ");
                Console.WriteLine("Secim edin!");

                int choice=int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Proqrami bitir!");
                        break;
                    case 1:
                        AddStudent();
                        break;
                    case 2:
                        group.ShowStudentInfo();
                        break;
                    case 3:
                       group.SearchByFullName();
                        break;
                    default:
                        Console.WriteLine("Yanlis secim! Zehmet olmasa duzgun secim edin.");
                        break;
                }

            }
        }

        static bool IsValidNo(string input)
        {
            if (input.Length != 5)
                return false;

            for (int i = 0; i < 2; i++)
            {
                if (!char.IsUpper(input[i]))
                    return false;
            }

            for (int i = 2; i < input.Length; i++)
            {
                if (!char.IsDigit(input[i]))
                    return false;
            }

            return true;
        }
    

        static void AddStudent()
        {
            

            Console.WriteLine("Full Name:");
            string FullName = Console.ReadLine();
            Console.WriteLine("Group No:");
            string GroupNo = Console.ReadLine();
            Console.WriteLine("Average Point:");
            byte AvgPoint = byte.Parse(Console.ReadLine());



            Student student = new Student(FullName);
            group.AddStudent(student);
            Console.WriteLine("Telebe elave edildi.");
        }
    }
}

