//int grade;
//int count = 0;
//int sum = 0;
//int highest = 0;
//int lowest = 0;
//while (true)
//{
//    Console.Write("Enter grades: ");
//    grade = Convert.ToInt32(Console.ReadLine());
//    if (grade == -1)
//    {
//        break;
//    }
//    if (count == 0)
//    {
//        highest = grade;
//        lowest = grade;
//    }
//    else
//    {
//        if (grade > highest)
//        {
//            highest = grade;
//        }
//        if (grade < lowest)
//        {
//            lowest = grade;
//        }
//    }
//    sum += grade;
//    count++;
//}
//if (count > 0)
//{
//    double average = (double)sum / count;
//    Console.WriteLine("count: ", count);
//    Console.WriteLine("Sum: ", sum);
//    Console.WriteLine("Average: {0:F2}", average);
//    Console.WriteLine("Highest: {0}", highest);
//    Console.WriteLine("Lowest: {0}", lowest);
//}
//else
//{
//    Console.WriteLine("No grades  entered.");
//}








//Console.Write("enter a number(1-10: ");
//int number = Convert.ToInt32(Console.ReadLine());
//if (number >= 1 && number <= 10)
//{
//    for (int i = 1; i <= 10; i++)
//    {
//        Console.WriteLine(number + " x " + i + " = " + (number * i));
//    }
//}
//else
//{
//    Console.WriteLine("Enter numbers between 1 and 10! ");
//}