/******************************************************************************

Welcome to GDB Online.
GDB online is an online compiler and debugger tool for C, C++, Python, Java, PHP, Ruby, Perl,
C#, OCaml, VB, Swift, Pascal, Fortran, Haskell, Objective-C, Assembly, HTML, CSS, JS, SQLite, Prolog.
Code, Compile, Run and Debug online from anywhere in world.

Alex Olhovskiy

*******************************************************************************/
using System;
class HelloWorld {
  static void Main() {
      /////////////compare two numbers////////////////
      Console.WriteLine("Enter first number");
      int firstNum=Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter second number");
      int secondNum=Convert.ToInt32(Console.ReadLine());
      
      //ternary operator
      //string str= firstNum>secondNum ? "max= "+firstNum+" min= "+secondNum : "max= "+secondNum+" min= "+firstNum; 
      //Console.WriteLine(str);
      
      //if else
      if(firstNum>secondNum)
      {
          Console.WriteLine("max= "+firstNum+" min= "+secondNum);
      }
      else
      {
          Console.WriteLine("max= "+secondNum+" min= "+firstNum);
      }
      
      /////////////max of three numbers////////////////
      Console.WriteLine("Enter first number");
      firstNum=Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter second number");
      secondNum=Convert.ToInt32(Console.ReadLine());
      
      Console.WriteLine("Enter third number");
      int thirdNum=Convert.ToInt32(Console.ReadLine());
      int max=0;
      //long way
      /*if(firstNum>secondNum)
      {
          if(firstNum>thirdNum)
          {
              max=firstNum;
          }
          else
          {
              max=thirdNum;
          }
      }
      else
      {
          if(secondNum>thirdNum)
          {
              max=secondNum;
          }
          else
          {
              max=thirdNum;
          }
      }*/
      //shoter way
      max= firstNum>secondNum ? firstNum : secondNum;
      max= max>thirdNum ? max : thirdNum;
      
      Console.WriteLine("max= "+max);
  
      /////////////Is number even////////////////
      Console.WriteLine("Enter number");
      firstNum=Convert.ToInt32(Console.ReadLine());
      if((firstNum%2)!=0)
      {
          Console.WriteLine("No, "+firstNum+" is odd");
      }
      else
      {
          Console.WriteLine("Yes, "+firstNum+" is even");
      }
      
      
      /////////////Return all even numbers////////////////
      Console.WriteLine("Enter number");
      firstNum=Convert.ToInt32(Console.ReadLine());
      
      int last= (firstNum%2)==0 ? last=firstNum : last=firstNum-1; 

      for(int i=0;i<=firstNum;i++)
      {
          if((i%2)==0)
          {
              Console.Write(i);
              if(i<last)
              {
                  Console.Write(",");
              }
          }
      }
    }
}