using OOP_Session03.BuiltiIterface;
using OOP_Session03.InterfaceEx1;
using OOP_Session03.InterfaceEx2;

namespace OOP_Session03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Interface
            // Interface: Code Contruct Between Developer Who Write it And Developer Who Use it
            // I can't Make Object From Any Interface
            // I can't Make Attributes in Interface
            // Default Accsess Modifier is Public
            // IMyType myType = new IMyType(); Invalid
            // Solve it: Create Class Which Implemented this Interface 
            #endregion
            #region Interface Ex1
            // Interface Ex01:
            MyType myType = new MyType() { Salary = 12000 };
            Console.WriteLine(myType.Salary);
            myType.MyFun();
            // I Can Create Reference Of Inteface -> Object from Class Who Implemented this interface
            IMyType myType1 = new MyType() { Salary = 15000 };
            Console.WriteLine(myType1.Salary);
            myType1.MyFun();
            myType1.Print();
            #endregion
            #region Interface Ex2
            // Interface Ex02:
            SeriousByTwo seriousByTwo = new SeriousByTwo();
            SeriousByThree seriousByThree = new SeriousByThree();
            #endregion
            #region Shallow Copy VS Deep Copy
            // Shallow Copy VS Deep Copy:
            // Object Consist of: Identity(Address), Object State(Data)

            // EX01:
            // Shallow Copy(Copy Identity)
            int[] Arr01 = { 1, 2, 3 };
            int[] Arr02 = { 4, 5, 6 };
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            Arr02 = Arr01;
            Console.WriteLine();
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            Arr01[0] = 5;
            Console.WriteLine(Arr02[0]);
            Console.WriteLine();
            // Deep Copy(Copy Object State(Data):
            // Clone Method: Copy Object State(Data) of Caller(Arr01)
            // Assign New Object to Arr02 + Generate New Identity(Address)
            Arr02 = (int[])Arr01.Clone();
            Console.WriteLine($"Arr01: {Arr01.GetHashCode()}");
            Console.WriteLine($"Arr02: {Arr02.GetHashCode()}");
            Arr01[0] = 5; ;
            Console.WriteLine(Arr02[0]);

            // EX02:
            string[] Arr1 = { "Ahmed", "Rawan", "Sara" };
            string[] Arr2 = { "Mohamed", "Ayman", "Omnia" };
            Console.WriteLine($"Arr1: {Arr1.GetHashCode()}");
            Console.WriteLine($"Arr2: {Arr2.GetHashCode()}");
            // Shallow Copy(Copy Id}; -> UnReachable Objectentity)
            Arr2 = Arr1;
            Console.WriteLine();
            Console.WriteLine($"Arr1: {Arr1.GetHashCode()}");
            Console.WriteLine($"Arr2: {Arr2.GetHashCode()}");
            Arr1[0] = "Mariam";
            Console.WriteLine(Arr2[0]);
            Console.WriteLine();
            // Deep Copy(Copy Object State(Data):
            // Clone Method: Copy Object State(Data) of Caller(Arr01)
            // Assign New Object to Arr02 + Generate New Identity(Address)
            Arr2 = (string[])Arr1.Clone();
            Console.WriteLine($"Arr1: {Arr1.GetHashCode()}");
            Console.WriteLine($"Arr2: {Arr2.GetHashCode()}");
            Arr1[1] = "Moha";
            Console.WriteLine(Arr2[0]);
            #endregion
            #region Built in Interface - ICloneable
            // Built in Interface - ICloneable:
            // To Use Clone Method if this calss not have Clone Method
            Employee employee01 = new Employee() { Id = 1, Name = "Rawan", Age = 22, Salary = 12000 };
            Employee employee02 = new Employee() { Id = 2, Name = "Mona", Age = 22, Salary = 12000 };
            employee02 = employee01; // Shallow Copy
            Console.WriteLine(employee01.GetHashCode());
            Console.WriteLine(employee02.GetHashCode());
            employee02 = (Employee)employee01.Clone();
            //employee02 = new Employee(employee01); 
            Console.WriteLine(employee01.GetHashCode());
            Console.WriteLine(employee02.GetHashCode());
            Console.WriteLine(employee01);
            Console.WriteLine(employee02);
            #endregion
            #region Built in Interface - ICompareable
            // Built in Interface - ICompareable
            Employee[] employees = new Employee[3]
            {
   new Employee(){Id = 1, Name = "Rawan", Age = 22, Salary = 12000},
   new Employee(){Id = 2, Name = "Mona", Age = 26, Salary = 18000},
   new Employee(){Id = 3, Name = "Fawzya", Age = 29, Salary = 20000},
            };
            Array.Sort(employees);
            foreach (Employee employee in employees)
            {
                Console.WriteLine(employee);
            }
            #endregion
            #region Built in Interface - IComparer
            Employee[] employees01 = new Employee[3]
            {
   new Employee(){Id = 1, Name = "Rawan", Age = 22, Salary = 12000},
   new Employee(){Id = 2, Name = "Mona", Age = 26, Salary = 40000},
   new Employee(){Id = 3, Name = "Fawzya", Age = 29, Salary = 20000},
            };
            Array.Sort(employees01, new Employee());
            foreach (Employee employee in employees01)
            {
                Console.WriteLine(employee);
            }
            #endregion
        }
    }
}
