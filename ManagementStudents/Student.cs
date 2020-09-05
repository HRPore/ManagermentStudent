using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementStudents
{
    class Student : Situation
    {
        string specialize, code;
        public string Code
        {
            get { return code; }
            set { code = value; }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Name cannot be blank");
                }
                name = value;
            }
        }
        public string Specialize
        {
            get { return specialize; }
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new Exception("Specialized cannot be blank");
                }
                specialize = value;
            }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value <= 0)
                {
                    throw new Exception("Age cannot be less than 0");
                }
                age = value;
            }
        }
        public string Classs
        {
            get { return classs; }
            set
            {
                classs = Console.ReadLine();
            }
        }
        public Student(string code, string name, string specialize, int age, string classs)
        {
            this.code = code;
            this.name = name;
            this.specialize = specialize;
            this.age = age;
            this.classs = classs;
        }
        public override void ShowInFo()
        {
            Console.WriteLine("Code: {0}", code);
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Specialize: {0}", specialize);
            Console.WriteLine("Age: {0}\tClass: {1}", age, classs);
        }
    }
}
