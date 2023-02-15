using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace KD
{
    public class main
    {
        static void Main(string[] args)
        {
            bool choice = true;
           string ch;

            while (choice) 
            {
                Console.WriteLine("Press 1 to Abstration"); 
                Console.WriteLine("Press 2 to AccessModifier"); 
                Console.WriteLine("Press 3 to AddTwoNumber"); 
                Console.WriteLine("Press 4 to array"); 
                Console.WriteLine("Press 5 to breakandcontinue"); 
                Console.WriteLine("Press 6 to Calculator"); 
                Console.WriteLine("Press 7 to ClassObject"); 
                Console.WriteLine("Press 8 to Constructor"); 
                Console.WriteLine("Press 9 to datatype"); 
                Console.WriteLine("Press 10 to Encapsiation"); 
                Console.WriteLine("Press 11 to Enum"); 
                Console.WriteLine("Press 12 to factorialFindUsingRecursion"); 
                Console.WriteLine("Press 13 to File"); 
                Console.WriteLine("Press 14 to foreachloop"); 
                Console.WriteLine("Press 15 to forloop"); 
                Console.WriteLine("Press 16 to ifelse"); 
                Console.WriteLine("Press 17 to inheritance"); 
                Console.WriteLine("Press 18 to interfacee"); 
                Console.WriteLine("Press 19 to method"); 
                Console.WriteLine("Press 20 to MethodOverriding"); 
                Console.WriteLine("Press 21 to MultipleInterface"); 
                Console.WriteLine("Press 22 to multipleObject"); 
                Console.WriteLine("Press 23 to operator"); 
                Console.WriteLine("Press 24 to Overloading"); 
                Console.WriteLine("Press 25 to print"); 
                Console.WriteLine("Press 26 to Recursion"); 
                Console.WriteLine("Press 27 to switchcase"); 
                Console.WriteLine("Press 28 to typecasting"); 
                Console.WriteLine("Press 29 to userInput"); 
                Console.WriteLine("Press 30 to variables"); 
                Console.WriteLine("Press 31 to whileloop");

                Console.WriteLine("Press 32 to Patterns");
                




                int key=Convert.ToInt32(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        Abstraction.dog();
                        break;
                    case 2:
                        AccessModifier.vehicle();
                        break;
                    case 3:
                        AddTwoNumber.add();
                        break;
                    case 4:
                        array.vehicle();
                        break;
                    case 5:
                        breakandcontinue.stop();
                        break;
                    case 6:
                        Calculator.calc();
                        break;
                    case 7:
                        Classobject.obj();
                        break;
                    case 8:
                        Constructor.cons();
                        break;
                    case 9:
                        datatype.data();
                        break;
                    case 10:
                        Account.combine();
                        break;
                    case 11:
                        Program.enum1();
                        break;
                    case 12:
                        factorialFindUsingRecursion.fac1();
                        break;
                    case 13:
                        Program1.pro1();
                        break;
                    case 14:
                        foreachloop.loop();
                        break;
                    case 15:
                        forloop.for1(); 
                        break;
                    case 16:
                        ifelse.if1();
                        break;
                    case 17:
                        Maruti.in1();
                        break;
                    case 18:
                        Program2.interface1();
                        break;
                    case 19:
                        method.method1();
                        break;
                    case 20:
                        Dog.over();
                        break;
                    case 21:
                        Program3.multiinterface();
                        break;
                    case 22:
                        multipleObject.multiobj();
                        break;
                    case 23:
                        @operator.ope(); 
                        break;
                    case 24:
                        Overloading.overload();
                        break;
                    case 25:
                        print.print1();
                        break;
                    case 26:
                        Recursion.recur();
                        break;
                    case 27:
                        switchcase.switch1();
                        break;
                    case 28:
                        typecasting.type();
                        break;
                    case 29:
                        userInput.input();
                        break;
                    case 30:
                        variables.var();
                        break;
                    case 31:
                        whileloop.while1 ();
                        break;
                    case 32:
                        Patterns.pattern();
                        break;
                }
                Console.WriteLine("Would you like to continue (Y/N)");

                ch= Console.ReadLine();

                Console.WriteLine("PRESS ENTER TO CONTINUE");
                ch = ch.ToUpper();

                if (ch == "Y")
                {
                    choice= true;
                }
                else
                {
                    choice= false;
                    Console.WriteLine("Thank you visit again");
                }
                Console.ReadKey();
             }
        }

    }
}
