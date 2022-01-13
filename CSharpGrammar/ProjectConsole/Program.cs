using System; //in .net 6 some using statement visible in .net 5 are 
              //already implemented in the project and do not 
              //need to explicity coded

              //there will be times that you still need to code
              //using statements to explicitly reference other namespaces

// See https://aka.ms/new-console-template for more information
DisplayString("Hello, World!");

static void DisplayString(string text) 
{
    Console.WriteLine(text);
}

