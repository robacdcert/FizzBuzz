//For the numbers from 1 to 30:
//if the number is evenly divisible by 3, print FIZZ
//if the number is evenly divisible by 5, print BUZZ
//if the number is evenly divisible by BOTH 3 and 5, print FIZZBUZZ

for (int i = 1; i <= 30; i++) {
    if (i % 3 == 0) Console.Write("FIZZ");
    if (i % 5 == 0) Console.Write("BUZZ");
    if (i % 3 != 0 && i % 5 != 0) Console.WriteLine(i);
    if (i % 3 == 0 || i % 5 == 0) Console.WriteLine();
}