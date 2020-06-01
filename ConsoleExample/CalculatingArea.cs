namespace Intro {
  using System;
  class CalculatingArea {
    static void Main() {
      Console.WriteLine("This program calculates "
                        + "the area of a rectangle or a triangle");
      Console.WriteLine("Enter a and b (for rectangle) "
                        + "or a and h (for triangle): ");
      int a = int.Parse(Console.ReadLine());
      int b = int.Parse(Console.ReadLine());
      Console.WriteLine("Enter 1 for a rectangle or " + "2 for a triangle: ");
      int choice = int.Parse(Console.ReadLine());
      double area = (double)(a * b) / choice;
      Console.WriteLine("The area of your figure is " + area);
    }
  }
}
