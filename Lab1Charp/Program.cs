using System;

namespace Pr{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("\nLab 1");
      
      Console.WriteLine("Choose task: ");
      int s = Convert.ToInt32(Console.ReadLine());

  switch(s){
    case 1: { task1();  break;}
    case 2: { task2();  break;}
    case 3: { task3();  break;}
    case 4: { task4();  break;}
    case 5: { task5();  break;}
    case 6: { task6();  break;}
  }
      
    }


static void task1()
{
    Console.WriteLine("\nTask1");
    Console.Write("s: ");
    string? str = Console.ReadLine();
    float s = 0; 
    if (str != null) s = float.Parse(str);

    double p = 6 * s * s;
    Console.WriteLine("P: " + p);

}
static void task2()
{
    Console.WriteLine("\nTask2");
    e:
    Console.Write("Number (1-99): ");
    string? str = Console.ReadLine();
    int s = 0, s1, s2, sum=0; 
    
    if (str != null ) s = int.Parse(str);
    if ((0<=s) && (s>=100)) goto e;

    s1 = s / 10; 
    s2 = s % 10;

    sum=s1+s2;

    Console.WriteLine("S1: "+s1+"   S2: "+s2+"   Sum: "+sum+"   A: "+(sum % 2));

    if((sum % 2) == 0) {Console.WriteLine("Result: " + s1+" "+s2+" - Yes\n");}
    else  {Console.WriteLine("Result: " + s1+" "+s2+" - No\n");}


}
static void task3()
{
    Console.WriteLine("\nTask3");

    Console.Write("X: ");
    string? str = Console.ReadLine();
    Console.Write("Y: ");
    string? str1 = Console.ReadLine();
    int x = 0, y=0; 
    
    if (str != null ) x = int.Parse(str);
    if (str1 != null ) y = int.Parse(str1);
    
    
    if(((x-12)*(0-12)-(y-12)*(0-12)) > 0 && y< 12) Console.WriteLine("Inside ");
    else if(((x-12)*(0-12)-(y-12)*(0-12)) < 0 || y> 12) Console.WriteLine("Outside ");
    else Console.WriteLine("Border");

}
static void task4()
{
    Console.WriteLine("\nTask4");

e:
    Console.Write("M (>0): ");
    string? str = Console.ReadLine();
    int m=0, n=0; 
    
    if (str != null ) m = int.Parse(str);
    if(m<0)goto e;

    n=-m;

    if(n<0) n*=-1;
    
    while (n>11) {n-=12;}

    switch(n){
      case 1: {Console.WriteLine("January\n"); break;}
      case 0: {Console.WriteLine("February\n"); break;}
      case 11: {Console.WriteLine("March\n"); break;}
      case 10: {Console.WriteLine("April\n"); break;}
      case 9: {Console.WriteLine("May\n"); break;}
      case 8: {Console.WriteLine("June\n"); break;}
      case 7: {Console.WriteLine("July\n"); break;}
      case 6: {Console.WriteLine("August\n"); break;}
      case 5: {Console.WriteLine("September\n"); break;}
      case 4: {Console.WriteLine("October\n"); break;}
      case 3: {Console.WriteLine("November\n"); break;}
      case 2: {Console.WriteLine("December\n"); break;}  
    }

}
static void task5()
{

    Console.WriteLine("\nTask5");
    Console.Write("X: ");
    string? str = Console.ReadLine();
    int x = 0; 
    
    if (str != null ) x = int.Parse(str);


  Console.WriteLine("X: " + pow(x,2));
    
    

}
static int pow (int x, int n){
  if (n == 0)
    {
        return 1;
    }

  else if (n == 1)
    {
        return x;
    }


else if(n>0){
    while(n!=1){
      x*=x;
      n-=1;
    }
    return x;
    }


    else{
       while(n!=1){
      x*=x;
      n-=1;
    }
    return 1/x;
    }
  }
static void task6()
{
    Console.WriteLine("Task6");

    Console.Write("X: ");
    string? str = Console.ReadLine();
    
    e:
    Console.Write("Y: ");
    string? str1 = Console.ReadLine();
    float x = 0, y=0, z=0;
    
    if((y*y+1)==0) {Console.WriteLine("Error (y*y+1)!=0 "); goto e;}

    if (str != null ) x = float.Parse(str);
    if (str1 != null ) y = float.Parse(str1);

    z=(x*y)*(x*y) - ((5*x+y*y)/(y*y+1));
    Console.WriteLine("Z: " + z);

}

  }

}