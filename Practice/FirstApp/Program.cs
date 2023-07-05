// System.Console.Write("Enter your name :");
// string? name=Console.ReadLine();

// System.Console.Write("How ald are you? :");
// int age =Convert.ToInt32(Console.ReadLine());

// System.Console.Write("Your height :");
// double height=Convert.ToDouble(Console.ReadLine());

// System.Console.Write("Your salary :");
// decimal salary=Convert.ToDecimal(Console.ReadLine());

// System.Console.WriteLine($"Name:{name} Age:{age} Height:{height} Salary:{salary}");

////////////////////////////////////////////////////////////////////////////////////


// int n=Convert.ToInt32(Console.ReadLine());

// int h= n / 3600 % 24;
// int m= n / 60 % 60;
// int s= n % 60 ;
// Console.Write(h);
// if (m<10)
// {
//   Console.Write($":0{m}:");
// }
// else
// {
//     Console.Write($":{m}:");
// }
// if (s<10)
// {
//   Console.Write($"0{s}");
// }
// else
// {
//     Console.Write($"{s}");
// }

// int s=Convert.ToInt32(Console.ReadLine());
// int d=Convert.ToInt32(Console.ReadLine());
// int ss=Convert.ToInt32(Console.ReadLine());
// int dd=Convert.ToInt32(Console.ReadLine());
// int somoni1=(s*100)+d;
// int somoni2=(ss*100)+dd;
// Console.Write($"s:{somoni1/100-somoni2/100} d:{somoni1%100-somoni2%100}");

// int y=Convert.ToInt32(Console.ReadLine());
// double salary=Convert.ToDouble(Console.ReadLine());
// if (y>=5)
// {
// System.Console.WriteLine(salary+salary*0.05);
// }
// else{
// System.Console.WriteLine(salary);
// }

// int Factorial(int n ){
//  int sum=1;
//  for(int i=1;i<=n;i++){
//     sum*=i;
//  }
//  return sum;
// }
// int sum=0;
// int n,k;
// n=Convert.ToInt32(Console.ReadLine());
// k=Convert.ToInt32(Console.ReadLine());
// sum=Factorial(n)/(Factorial(k)*Factorial(n-k));
// Console.WriteLine(sum);

// double SumOfFactorial(int n){
//     double sum=0;
//     for (int i = 0; i <= n; i++)
//     {
//         sum+=1/Factorial(i);
//     }
// return sum;
// }
// Console.WriteLine(SumOfFactorial(5));

int n=12345;
void EventCount(int n){
int count=0;
  for (int i = n; i > 0; i /= 10)
  {
    if ((i % 10) % 2 == 0)
    {
       
        count++;
    }
  }
  Console.WriteLine($"Even:{count}");
}
void OddCount(int n){
int count=0;

  for (int i = n; i > 0; i /= 10)
  {
    if ((i%10) % 2 != 0)
    {
        count++;
    }
  }
  Console.WriteLine($"Odd:{count}");
}

void DigitCount(int n){
int count=0;
for (int i = n; i > 0 ; i /=10)
{
    count++;
}
Console.WriteLine($"Digit:{count}");
}

void SumDigit(int n){
    int sum=0;
  for (int i = n; i > 0; i /= 10)
  {
    sum+=n % 10;
  }
  Console.WriteLine(sum);
}
EventCount(n);
OddCount(n);
DigitCount(n);
SumDigit(n);