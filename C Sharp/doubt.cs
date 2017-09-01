using System;
namespace StringApplication
{
   class Program
   {
      static void Main(string[] args)
      {
         //from string literal and string concatenation
         string fname, lname;
         fname = "Rowan";
         lname = "Atkinson";
         
         string fullname = fname + lname;
         Console.WriteLine("Full Name: {0}"+"\n", fullname);
         
         //by using string constructor
         char[] letters = { 'H', 'e', 'l', 'l','o' };
         string greetings = new string(letters);
         Console.WriteLine("Greetings: {0}"+"\n", greetings);
         
       
       
         //methods returning string
         string[] hint = { "Hello", "From", "Tutorials", "Point" };
         string finalst="";
         for(int i=0;i<=hint.Length-1;i++)
         {
              finalst=finalst+hint[i]+" ";
             
         }
         Console.WriteLine(finalst);
         Console.WriteLine("\n");
		 
         
		 
		 // another methods returning string
         
         string message = String.Join(" ", hint);
         Console.WriteLine("Message: {0}"+"\n", message);
         
         //formatting method to convert a value
         DateTime waiting = new DateTime(2012, 10, 10, 17, 58, 1);
         string chat = String.Format("Message sent at {0:t} on {0:D}", waiting);
         Console.WriteLine("Message: {0}", chat);
      }
   }
}