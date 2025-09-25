using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignemnt
{
    internal class Program
    {
            static List<string> Stu = new List<string>();
            static List<int> Num = new List<int>();
            static List<int> Grade = new List<int>();
            static List<int> StuAllowance = new List<int>();
            static List<string> YN = new List<string>();
        private static string again;

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("********************************* BELGIUM CAMPUS CAFETERIA SYSTEM *********************************");
                Console.WriteLine("Student information");
                Console.WriteLine("1. Add new student\n2. View all students\n3. Edit student \n4. Check for Qaulification \n5. Delete student\n6. Close");

                Console.Write("Enter your choice: ");
                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddNewStu(Stu, Num, Grade, StuAllowance, YN);
                        break;
                    case "2":
                        ViewAllStu();
                        break;
                    case "3":
                        EditStu();
                        break;
                    case "4":
                        CheckQ();
                        break;
                    case "5":
                        DelStu();
                        break;
                    case "6":
                        Console.WriteLine("Exiting the system...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

                Console.WriteLine("\nPress any key to return to the main menu...");
                Console.ReadKey();
            }
        }

        private static void AddNewStu(List<string> Stu, List<int> Num, List<int> Grade, List<int> StuAllowance, List<string> YN)
        {
            
                do
                {
                    Console.Clear();
                    Console.WriteLine("Enter the Student's First Name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the Student's Last Name:");
                    string surname = Console.ReadLine();

                    Console.WriteLine("Enter the Student Number:");
                    int number = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the Student's Allowance:");
                    int allowance = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Does the student stay in res? (Y/N)");
                    string res = Console.ReadLine().ToUpper();

                    Console.WriteLine("Enter the student's PRG161 mark:");
                    int prg161 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the student's PRG261 mark:");
                    int prg261 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the student's WPR261 mark:");
                    int wpr261 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Enter the student's DBD261 mark:");
                    int dbd261 = Convert.ToInt32(Console.ReadLine());

                    
                    Stu.Add(name + " " + surname);
                    Num.Add(number);
                    StuAllowance.Add(allowance);
                    YN.Add(res);
                    Grade.Add(prg161);
                    Grade.Add(prg261);
                    Grade.Add(wpr261);
                    Grade.Add(dbd261);

                    Console.WriteLine("\n Student captured successfully!");
                    Console.WriteLine("Do you still want to capture any more applicants? (Y/N)");
                    again = Console.ReadLine().ToUpper();

                } while (again == "Y");
            }

        static void EditStu()
        {
            if (Stu.Count == 0)
            {
                Console.WriteLine("No students have been added yet.");
                return;
            }

            Console.WriteLine("\n************** All Students **************");

            for (int i = 0; i < Stu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Stu[i]} - {Num[i]}");
            }

            Console.Write("\nEnter the number of the student you want to edit: ");
            if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > Stu.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            choice -= 1;
            int gradeIndex = choice * 4;

            Console.WriteLine("\nCurrent Student Information:");
            Console.WriteLine($"1. Name & Surname: {Stu[choice]}");
            Console.WriteLine($"2. Student Number: {Num[choice]}");
            Console.WriteLine($"3. Allowance: R{StuAllowance[choice]}");
            Console.WriteLine($"4. Residence (Y/N): {YN[choice]}");
            Console.WriteLine($"5. PRG161 Grade: {Grade[gradeIndex]}%");
            Console.WriteLine($"6. PRG261 Grade: {Grade[gradeIndex + 1]}%");
            Console.WriteLine($"7. WPR261 Grade: {Grade[gradeIndex + 2]}%");
            Console.WriteLine($"8. DBD261 Grade: {Grade[gradeIndex + 3]}%");

            Console.Write("\nEnter the number of the field you want to edit (1-8), or 0 to cancel: ");
            if (!int.TryParse(Console.ReadLine(), out int fieldChoice) || fieldChoice < 0 || fieldChoice > 8)
            {
                Console.WriteLine("Invalid input.");
                return;
            }

            if (fieldChoice == 0)
            {
                Console.WriteLine("Edit cancelled.");
                return;
            }

            switch (fieldChoice)
            {
                case 1:
                    Console.Write("Enter new Name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter new Surname: ");
                    string surname = Console.ReadLine();
                    Stu[choice] = $"{name} {surname}";
                    break;

                case 2:
                    Console.Write("Enter new Student Number: ");
                    if (int.TryParse(Console.ReadLine(), out int newNum))
                        Num[choice] = newNum;
                    else
                        Console.WriteLine("Invalid number. No changes made.");
                    break;

                case 3:
                    Console.Write("Enter new Allowance: ");
                    if (int.TryParse(Console.ReadLine(), out int newAllowance))
                        StuAllowance[choice] = newAllowance;
                    else
                        Console.WriteLine("Invalid amount. No changes made.");
                    break;

                case 4:
                    Console.Write("Is the student using Residence (Y/N)? ");
                    string newRes = Console.ReadLine().ToUpper();
                    if (newRes == "Y" || newRes == "N")
                        YN[choice] = newRes;
                    else
                        Console.WriteLine("Invalid input. No changes made.");
                    break;

                case 5:
                    Console.Write("Enter new Grade: ");
                    if (int.TryParse(Console.ReadLine(), out int newGrade))
                        Grade[gradeIndex + (fieldChoice - 5)] = newGrade;
                    else
                        Console.WriteLine("Invalid grade. No changes made.");
                    break;
                case 6:
                    Console.Write("Enter new Grade: ");
                    if (int.TryParse(Console.ReadLine(), out int newGrade2))
                        Grade[gradeIndex + (fieldChoice - 5)] = newGrade2;
                    else
                        Console.WriteLine("Invalid grade. No changes made.");
                    break;
                case 7:
                    Console.Write("Enter new Grade: ");
                    if (int.TryParse(Console.ReadLine(), out int newGrade3))
                        Grade[gradeIndex + (fieldChoice - 5)] = newGrade3;
                    else
                        Console.WriteLine("Invalid grade. No changes made.");
                    break;
                case 8:
                    Console.Write("Enter new Grade: ");
                    if (int.TryParse(Console.ReadLine(), out int newGrade4))
                        Grade[gradeIndex + (fieldChoice - 5)] = newGrade4;
                    else
                        Console.WriteLine("Invalid grade. No changes made.");
                    break;


            }

            Console.WriteLine("\n Student information updated successfully.");
        }
        static void CheckQ()
        {

            if (Stu.Count == 0)
            {
                Console.WriteLine("No students have been added yet.");
                return;
            }

            Console.WriteLine("\n************** Discount Qualification **************");

            for (int i = 0; i < Stu.Count; i++)
            {
                int gradeIndex = i * 4;
                double avg = (Grade[gradeIndex] + Grade[gradeIndex + 1] + Grade[gradeIndex + 2] + Grade[gradeIndex + 3]) / 4.0;

                Console.WriteLine($"\nStudent: {Stu[i]}");
                Console.WriteLine($"Student Number: {Num[i]}");
                Console.WriteLine($"Residence: {YN[i]}");

                Console.Write("How many years has the student stayed on campus? ");
                if (!int.TryParse(Console.ReadLine(), out int yearsStayed))
                {
                    Console.WriteLine("Invalid input for years. Skipping student.");
                    continue;
                }

                Console.WriteLine($"Average Grade: {avg:F2}%");

                if (YN[i] == "Y" && yearsStayed > 1)
                {
                    Console.WriteLine("Residence condition GOOD");
                }
                else
                {
                    Console.WriteLine("Residence condition BAD");
                }

                if (avg > 85)
                {
                    Console.WriteLine("Grade condition GOOD");
                }
                else
                {
                    Console.WriteLine("Grade condition BAD");
                }

                if (YN[i] == "Y" && yearsStayed > 1 && avg > 85)
                {
                    Console.WriteLine("Student qualifies for the cafeteria discount!");
                }
                else
                {
                    Console.WriteLine(" Student does NOT qualify for the cafeteria discount.");
                }
            }

        }
        static void ViewAllStu()
        {
            if (Stu.Count == 0)
            {
                Console.WriteLine("No students have been added yet.");
                return;
            }

            Console.WriteLine("\n************** All Students **************");

            for (int i = 0; i < Stu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Stu[i]} - {Num[i]}");
            }
            Console.Write("\nEnter the number of the student you want to view: ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;  // Adjust for 0-based index

            if (choice < 0 || choice >= Stu.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            int Pick = choice * 4;
            double average = (Grade[Pick] + Grade[Pick + 1] + Grade[Pick + 2] + Grade[Pick + 3]) / 4.0;

            Console.WriteLine("\n************ Student Details ************");
            Console.WriteLine($"Name & Surname: {Stu[choice]}");
            Console.WriteLine($"Student Number: {Num[choice]}");
            Console.WriteLine($"Allowance: R{StuAllowance[choice]}");
            Console.WriteLine($"Residence: {YN[choice]}");
            Console.WriteLine($"PRG161 Grade: {Grade[Pick]}%");
            Console.WriteLine($"PRG261 Grade: {Grade[Pick + 1]}%");
            Console.WriteLine($"WPR261 Grade: {Grade[Pick + 2]}%");
            Console.WriteLine($"DBD261 Grade: {Grade[Pick + 3]}%");
            Console.WriteLine($"Average Grade: {average}%");
        
        }

            static void DelStu()
        {
            if (Stu.Count == 0)
            {
                Console.WriteLine("No students to delete.");
                return;
            }

            Console.WriteLine("\n************** All Students **************");

            for (int i = 0; i < Stu.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Stu[i]} - {Num[i]}");
            }

            Console.Write("\nEnter the number of the student you want to delete: ");
            int choice = Convert.ToInt32(Console.ReadLine()) - 1;

            if (choice < 0 || choice >= Stu.Count)
            {
                Console.WriteLine("Invalid selection.");
                return;
            }

            Console.WriteLine($"\nAre you sure you want to delete {Stu[choice]}? (Y/N): ");
            string confirm = Console.ReadLine().ToUpper();

            if (confirm == "Y")
            {
                Grade.RemoveRange(choice * 4, 4);
                Stu.RemoveAt(choice);
                Num.RemoveAt(choice);
                StuAllowance.RemoveAt(choice);
                YN.RemoveAt(choice);

                Console.WriteLine("Student deleted successfully.");
            }
            else
            {
                Console.WriteLine("Delete cancelled.");
            }
        }

    }
}
