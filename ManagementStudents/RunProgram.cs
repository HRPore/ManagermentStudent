using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStudents
{
    class RunProgram
    {
        static void Main(string[] args)
        {
            ManagementStudent objMST = new ManagementStudent();
            ManagementTeacher objMT = new ManagementTeacher();
            ManagermentClass objC = new ManagermentClass();

            string code, specialized;
            int opt, choose;
            while (true)
            {
                Menu:
                Console.WriteLine("1. Student");
                Console.WriteLine("2. Teacher");
                Console.WriteLine("3. Class");
                Console.WriteLine("4. Course");
                Console.WriteLine("5. Exit");
                choose = int.Parse(Console.ReadLine());
                switch(choose)
                {
                    case 1:
                        Console.WriteLine("1. Add new Student");
                        Console.WriteLine("2. Search Student by code");
                        Console.WriteLine("3. Display all Student");
                        Console.WriteLine("4. Display Student by Specialized");
                        Console.WriteLine("5. Update Student by code");
                        Console.WriteLine("6. Delete Student by code");
                        Console.WriteLine("7. Exit");
                        Console.WriteLine();
                        Console.Write("Enter an opt: ");
                        opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                objMST.AddStudent();
                                break;
                            case 2:
                                Console.Write("Enter a code for search: ");
                                code = Console.ReadLine();
                                objMST.SearchStudent(code);
                                break;
                            case 3:
                                objMST.DisplayAllStudent();
                                break;
                            case 4:
                                Console.Write("Enter a specialized: ");
                                specialized = Console.ReadLine();
                                objMST.DisplayBySpecializeStudent(specialized);
                                break;
                            case 5:
                                Console.Write("Enter a code: ");
                                code = Console.ReadLine();
                                objMST.UpdateStudent(code);
                                break;
                            case 6:
                                Console.Write("Enter a code: ");
                                code = Console.ReadLine();
                                objMST.DeleteStudent(code);
                                break;
                            case 7:
                                goto Menu;
                                
                                
                            default:
                                Console.WriteLine("Invalid number");
                                break;
                        }
                        break;

                    case 2:
                        Console.WriteLine("1. Add new Teacher");
                        Console.WriteLine("2. Search Teacher by code");
                        Console.WriteLine("3. Display all Teacher");
                        Console.WriteLine("4. Display Teacher by Specialized");
                        Console.WriteLine("5. Update Teacher by code");
                        Console.WriteLine("6. Delete Teacher by code");
                        Console.WriteLine("7. Exit");
                        Console.WriteLine();
                        Console.Write("Enter an opt: ");
                        opt = int.Parse(Console.ReadLine());
                        switch (opt)
                        {
                            case 1:
                                objMT.AddTeach();
                                break;
                            case 2:
                                Console.Write("Enter a code for search: ");
                                code = Console.ReadLine();
                                objMT.SearchTeacher(code);
                                break;
                            case 3:
                                objMT.DisplayAllTeacher();
                                break;
                            case 4:
                                Console.Write("Enter a specialized: ");
                                specialized = Console.ReadLine();
                                objMT.DisplayBySpecializeTeacher(specialized);
                                break;
                            case 5:
                                Console.Write("Enter a code: ");
                                code = Console.ReadLine();
                                objMT.UpdateTeacher(code);
                                break;
                            case 6:
                                Console.Write("Enter a code: ");
                                code = Console.ReadLine();
                                objMT.DeleteTeacher(code);
                                break;
                            case 7:
                                goto Menu;
                            default:
                                Console.WriteLine("Invalid number");
                                break;
                        }
                        break;
                    case 3:
                        Console.WriteLine("Error");
                        goto Menu;
                    case 4:
                        Console.WriteLine("Error");
                        goto Menu;
                    case 5:
                        Environment.Exit(0);
                        break;
                }

                

            }
        }
    }
}
