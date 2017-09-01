using System;
namespace HelloWorldApplication
{
   class HelloWorld
   {
      static void Main(string[] args)
      {
         /* my first program in C# */
         Console.WriteLine("Hello World");
         Console.ReadKey();
      }
   }
}


// ANOTHER EX

using System;
namespace RectangleApplication
{
   class Rectangle
   {
      //member variables
      public double length;                                         O\p:
      public double width;                       
                                                                       Length: 5.5
																		Length:5.5
																		Width: 3.5
																		Area: 19.25
	  public double GetArea()
      {
         return length * width;
      }
      public void Display()
      {
         Console.WriteLine("Length: {1}", length,length);   //pick the value of length 1 position (ie) length 2nd value
        
         Console.Write("Length:");
         Console.Write(length);
         Console.WriteLine();
         
         Console.WriteLine("Width: {0}", width);
         Console.WriteLine("Area: {0}", GetArea());
      }
   }//end class Rectangle
   
   class ExecuteRectangle
   {
      static void Main(string[] args)
      {
         Rectangle r = new Rectangle();
         r.length = 4.5;
         r.length = 5.5;
         r.width = 3.5;
         r.Display();
         Console.ReadLine();
      }
   }
}