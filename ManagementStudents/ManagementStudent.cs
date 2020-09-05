using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagementStudents
{
    class ManagementStudent
    {
        Student objST;
        List<Student> stList;
        string type, code;
        bool check = false;


        public ManagementStudent()
        {
            stList = new List<Student>();

        }
        #region Student
        public void AddStudent()
        {
            objST = new Student(null, null, null, 0, null);
            type = "M[0-9]{2}\\-[0-9]{2}";

        EnterCode:
            Console.Write("Enter a Code: ");
            code = Console.ReadLine();
            if (!Regex.IsMatch(code, type))
            {
                Console.WriteLine("Code must be format Mxx-xx with x is digit");
                goto EnterCode;
            }
            for (int i = 0; i < stList.Count; i++)
            {
                if (stList[i].Code.Equals(code))
                {
                    Console.WriteLine("Code is existed. Ple re-enter");
                    goto EnterCode;
                }
            }
            objST.Code = code;

        EnterStudentName:
            try
            {
                Console.Write("Enter a name: ");
                objST.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto EnterStudentName;
            }

        EnterSpecialize:
            try
            {
                Console.Write("Enter a Specialize: ");
                objST.Specialize = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto EnterSpecialize;
            }

        EnterAge:
            try
            {
                Console.Write("Enter a Age: ");
                objST.Age = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Age must number");
                goto EnterAge;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto EnterAge;
            }

        EnterClass:
            try
            {
                Console.Write("Enter a class: ");
                objST.Classs = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto EnterClass;
            }
            stList.Add(objST);
            Console.WriteLine("Add new student successfully");
        }
        public void SearchStudent(string model)
        {
            check = false;
            for (int i = 0; i < stList.Count; i++)
            {
                if (stList[i].Code.Equals(model))
                {
                    check = true;
                    stList[i].ShowInFo();
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find student with this code");
            }
        }
        public void DisplayAllStudent()
        {
            if (stList.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            for (int i = 0; i < stList.Count; i++)
            {
                stList[i].ShowInFo();
                Console.WriteLine();
            }
        }
        public void UpdateStudent(string model)
        {
            check = false;
            for (int i = 0; i < stList.Count; i++)
            {
                if (stList[i].Code.Equals(model))
                {
                    check = true;
                    Console.WriteLine("Old Age is {0} and Class is {1}", stList[i].Age, stList[i].Classs);

                EnterAge:
                    try
                    {
                        Console.Write("Enter a new age: ");
                        stList[i].Age = int.Parse(Console.ReadLine());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Age must be number");
                        goto EnterAge;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        goto EnterAge;
                    }

                EnterClass:
                    try
                    {
                        Console.Write("Enter a new class: ");
                        stList[i].Classs = Console.ReadLine();
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Class must be number");
                        goto EnterClass;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        goto EnterClass;
                    }
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find student for update");
            }
        }
        public void DeleteStudent(string code)
        {
            check = false;
            for (int i = 0; i < stList.Count; i++)
            {
                if (stList[i].Code.Equals(code))
                {
                    stList.RemoveAt(i);
                    check = true;
                    Console.WriteLine("Deteled a student with code {0} successfull", code);
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find student for delete ");
            }
        }
        public void DisplayBySpecializeStudent(string specialize)
        {
            check = false;
            for (int i = 0; i < stList.Count; i++)
            {
                if (stList[i].Specialize.Equals(specialize))
                {
                    check = true;
                    stList[i].ShowInFo();
                    Console.WriteLine();
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find student with this specialized");
            }
        }

        public void DisplayByClass(string Class)
        {
            check = false;
            for (int i = 0; i < stList.Count; i++)
            {
                if (stList[i].Specialize.Equals(Class))
                {
                    check = true;
                    stList[i].ShowInFo();
                    Console.WriteLine();
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find student with this specialized");
            }
        }
        #endregion
    }
}
