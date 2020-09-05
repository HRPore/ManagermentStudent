using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ManagementStudents
{
    class ManagementTeacher
    {
        Teacher objT;
        List<Teacher> tList;
        string type, code;
        bool check = false;

       
        public ManagementTeacher()
        {
            tList = new List<Teacher>();
       
        }
        #region Teacher
        public void AddTeach()
        {
            objT = new Teacher(null, null, null, 0, null);
            type = "M[0-9]{2}\\-[0-9]{2}";

        EnterCode:
            Console.Write("Enter a Code: ");
            code = Console.ReadLine();
            if (!Regex.IsMatch(code, type))
            {
                Console.WriteLine("Code must be format Mxx-xx with x is digit");
                goto EnterCode;
            }
            //Kiem trung model
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i].Code.Equals(code))
                {
                    Console.WriteLine("Code is existed. Ple re-enter");
                    goto EnterCode;
                }
            }
            objT.Code = code;

        EnterTeachName:
            try
            {
                Console.Write("Enter a name: ");
                objT.Name = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto EnterTeachName;
            }

        EnterSpecialize:
            try
            {
                Console.Write("Enter a Specialize: ");
                objT.Specialize = Console.ReadLine();
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
                objT.Age = int.Parse(Console.ReadLine());
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
                objT.Classs = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                goto EnterClass;
            }
            //Dua objM vao List
            tList.Add(objT);
            Console.WriteLine("Add new Teacher successfully");
        }
        public void SearchTeacher(string model)
        {
            check = false;
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i].Code.Equals(model))
                {
                    check = true;
                    tList[i].ShowInFo();
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find teacher with this code");
            }
        }
        public void DisplayAllTeacher()
        {
            if (tList.Count == 0)
            {
                Console.WriteLine("List is empty");
                return;
            }
            for (int i = 0; i < tList.Count; i++)
            {
                tList[i].ShowInFo();
                Console.WriteLine();
            }
        }
        public void UpdateTeacher(string model)
        {
            check = false;
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i].Code.Equals(model))
                {
                    check = true;
                    Console.WriteLine("Old Age is {0} and Class is {1}", tList[i].Age, tList[i].Classs);

                EnterAge:
                    try
                    {
                        Console.Write("Enter a new age: ");
                        tList[i].Age = int.Parse(Console.ReadLine());
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
                        tList[i].Classs = Console.ReadLine();
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
                Console.WriteLine("Cannot find Teacher for update");
            }
        }
        public void DeleteTeacher(string model)
        {
            check = false;
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i].Code.Equals(model))
                {
                    tList.RemoveAt(i);
                    check = true;
                    Console.WriteLine("Deteled a teacher with Code {0} successfull", model);
                    break;
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find Teacher for delete ");
            }
        }
        public void DisplayBySpecializeTeacher(string specialize)
        {
            check = false;
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i].Specialize.Equals(specialize))
                {
                    check = true;
                    tList[i].ShowInFo();
                    Console.WriteLine();
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find Teacher with this branch");
            }
        }

        public void DisplayByClass(string Class)
        {
            check = false;
            for (int i = 0; i < tList.Count; i++)
            {
                if (tList[i].Specialize.Equals(Class))
                {
                    check = true;
                    tList[i].ShowInFo();
                    Console.WriteLine();
                }
            }
            if (check == false)
            {
                Console.WriteLine("Cannot find Teacher with this branch");
            }
        }
        #endregion

       


    }
}
