using System;
class SelectionStatement
{
    static void Main1()
    {
        SelectionStatement a = new SelectionStatement();
        a.LearnIfElse();
        a.LearnSwitch();
    }
 void LearnIfElse()
 {   Console.Write("enter an number: ");
      string input = Console.ReadLine();
    byte x = byte.Parse(input);
    if(x==34)
    {
    Console.WriteLine("inside if statement");
    }
    else
        {
            Console.WriteLine("inside else statement");
        }
 }
void LearnSwitch()
{
    char option = 'y';
    switch(option)
    {
        case 'n':
        case 'x':
        Console.WriteLine("you opted  for NO.");
        break;

        case 'y':
        case 'z':
        Console.WriteLine("you opted  for YES.");
        break;

       default:
        Console.WriteLine("no cases matched");
        break;
    }
}

}