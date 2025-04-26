Console.WriteLine("1.Verilmis 3 reqemli ededin reqemlerinin hasilini tapan alqoritm. Misalcun alqoritme 231 ededini daxil etdikde 231 in neticesini vermelidir.\n");
Console.WriteLine("2. Supermarketde bele bir aksiya kecirilir: 3 mehsul aldiqda en ucuz mehsul pulsuz olur. Misalcun 40, 50 ve 20 manatliq mehsullar alsam umumilikde 40+50 manat odenilir. 3 mehsulun qiymeti verildikde musterinin ne qeder odemeli oldugunu tapin alqoritm. \n");
Console.WriteLine("3. a ededi 3-e bolunen cut ededdirse 3-e bolunur cutdur, 3-e bolunen tek ededdirse 3-e bolunur tekdir, eks halda 3-e bolunmur sozunu ekranda cap edin.\n");
Console.WriteLine("4. Verilmis n tam ededinin sade veya murekkeb eded oldugunu tapin.\n");
Console.WriteLine("5. X, Y, Z ededleri verilib. Bu ededlerin en kiciyini tapan alqoritm qurun.\n");
Console.WriteLine("6. Verilmis N ededinin 3-e ve 7-e bolunub bolunmediyini tapan alqoritm qurun.\n");
Console.WriteLine("7. Verilmis 3 ededden musbet olanlarin sayini tapan alqoritm.\n");
Console.WriteLine("8. Verilmis M ededinden verilmis N ededinedek olan ededlerin cemini tapan alqoritm.\n");
Console.WriteLine("9. 1-den M-edek ededler icerisinde 15-e bolunen ededlerin sayini tapan alqoritm.\n");
Console.WriteLine("10. 1-den M-edek ededler icerisinde 21-e bolunen ededlerin ededi ortasini tapan alqoritm.\n");
Console.WriteLine("11. Verilmis N ededinin reqemlerinin cemini tapan alqoritm. (eded 3 veya daha cox reqemden ibaret ola biler)\n");

while (true)
{
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.Write("================================================== Enter task number:\n================================================== If you want exit you can enter 0:  ");
    string input = Console.ReadLine();
    Console.ResetColor();

    if(input == "0")
    {
        Console.ForegroundColor= ConsoleColor.DarkYellow;
        Console.WriteLine("\n\n============================================= Exiting the program. Goodbye! ============================================\n");
        Console.ResetColor();
        break;
    }

    int task = Convert.ToInt32(input);

    switch (task)
    {
        case 1:
            {
                #region task1
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("1. Verilmis 3 reqemli ededin reqemlerinin hasilini tapan alqoritm. Misal ucun alqoritme 231 ededini daxil etdikdə 2*3*1 in neticesini vermelidir.");
                Console.ResetColor();

                int number;
                int digit;
                int multiplyOfDigits = 1;

                do
                {
                    Console.Write("Please enter number: ");
                    number = Convert.ToInt32(Console.ReadLine());
                    if (number <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your number cannot be 0 or less than zero");
                        Console.ResetColor();
                    }
                    else if (number < 100 || number > 999)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your number is not a 3-digit number.");
                        Console.ResetColor();
                    }
                }
                while (number <= 0 || number < 100 || number > 999);

                for (int i = number; i > 0; i /= 10)
                {
                    digit = i % 10;
                    multiplyOfDigits *= digit;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your number's digit multiply is: " + multiplyOfDigits);
                Console.ResetColor();

                #endregion
            }
            break;

        case 2:
            {
                #region task2
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("2. Supermarketde bele bir aksiya kecirilir: 3 mehsul aldiqda en ucuz mehsul pulsuz olur. Misalcun 40, 50 ve 20 manatliq mehsullar alsam umumilikde 40+50 manat odenilir. 3 Mehsulun qiymeti verildikde musterinin ne qeder odemeli oldugunu tapan alqoritm.");
                Console.ResetColor();

                int sum;
                int price1;
                int price2;
                int price3;

                do
                {
                    Console.Write("Please enter first price: ");
                    price1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter second price: ");
                    price2 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter third price: ");
                    price3 = Convert.ToInt32(Console.ReadLine());

                    if (price1 < 0 || price2 < 0 || price3 < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your price not be less than 0");
                        Console.ResetColor();
                    }
                }
                while (price1 < 0 || price2 < 0 || price3 < 0);

                if (price1 <= price2 && price1 <= price3)
                {
                    sum = price2 + price3;
                }

                else if (price2 <= price1 && price2 <= price3)
                {
                    sum = price1 + price3;
                }

                else
                {
                    sum = price1 + price2;
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("You should pay " + sum + "$");
                Console.ResetColor();
                #endregion
            }
            break;

        case 3:
            {
                #region task3
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("3. a ededi 3-e bolunen cut ededdirse 3 - e bolunur cutdur, 3-e bolunen tek ededdirse, 3 - e bolunur tekdir eks halda 3 - e bolunmur sozunu ekranda cap edin.");
                Console.ResetColor();

                int givenNumber; 

                do
                {
                    Console.Write("Please enter a number: ");
                    givenNumber = Convert.ToInt32(Console.ReadLine());
                    
                    if (givenNumber<=0)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("You cannot enter 0 or less than 0.");
                        Console.ResetColor();
                    }
                } while (givenNumber <= 0);

                if (givenNumber % 3 == 0 && givenNumber % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your number is an even number that is divisible by 3.");
                    Console.ResetColor();
                }
                else if (givenNumber % 3 == 0 && givenNumber % 2 == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your number is an odd number that is divisible by 3.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your number is not divisible by 3.");
                    Console.ResetColor();
                }
                #endregion
            }
            break;

        case 4:
            {
                #region task4
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("4. Verilmis n tam ededinin sade ve ya murekkeib eded oldugunu tapin.");
                Console.ResetColor();

                Console.Write("Please enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());

                bool isPrime = true;

                if (num <= 1)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Your number is neither prime nor composite.");
                    Console.ResetColor();
                }
                else
                {
                    for (int i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            isPrime = false;
                            break;
                        }
                    }

                    if (isPrime)
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Your number is a prime number.");
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Your number is a composite number.");
                        Console.ResetColor();
                    }
                }
                #endregion
            }
            break;

        case 5:
            {
                #region task5
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("5. X, Y, Z ededleri verilib. Bu ededlerin en kichiyini tapan alqoritm qurun.");
                Console.ResetColor();

                int smallestNum = 0;
                int xYz;

                for (int i = 1; i <= 3; i++)
                {
                    Console.Write("Please enter number " + i + ": ");
                    xYz = Convert.ToInt32(Console.ReadLine());

                    if (i == 1)
                    {
                        smallestNum = xYz;
                    }
                    else if (xYz < smallestNum)
                    {
                        smallestNum = xYz;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your smallest num is: " + smallestNum);
                Console.ResetColor();
                #endregion
            }
            break;

        case 6:
            {
                #region task6
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("6. Verilmis N ededinin 3-e ve 7-e bolunub bolunmediyini tapan alqoritm qurun.");
                Console.ResetColor();

                Console.Write("Please enter a number: ");
                int n = Convert.ToInt32(Console.ReadLine());

                if (n % 21 == 0 && n != 0)
                {
                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("Your number is divisible by 3 and 7.");
                    Console.ResetColor();
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Your number is not divisible by 3 and 7.");
                    Console.ResetColor();
                }
                #endregion
            }
            break;

        case 7:
            {
                #region task7
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("7. Verilmis 3 ededden musbet olanlarin sayini tapan alqoritm.");
                Console.ResetColor();

                Console.Write("Enter a first number: ");
                int a = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int b = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a third number: ");
                int c = Convert.ToInt32(Console.ReadLine());

                int count = 0;

                if (a > 0) count++;
                if (b > 0) count++;
                if (c > 0) count++;

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Your positive number count is: " + count);
                Console.ResetColor();

                #endregion
            }
            break;

        case 8:
            {
                #region task8
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("8. Verilmis M ededinden verilmis N ededinedek olan ededlerin cemini tapan alqoritm.");
                Console.ResetColor();

                Console.Write("Enter a first number: ");
                int n1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int m1 = Convert.ToInt32(Console.ReadLine());

                int sumOfNum = 0;

                if (n1 < m1)
                {
                    for (int i = n1; i <= m1; i++)
                    {
                        sumOfNum += i;
                    }
                }
                else
                {
                    for (int i = n1; i >= m1; i--)
                    {
                        sumOfNum += i;
                    }
                }

                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The sum of the numbers from the given number M to the given number N is: " + sumOfNum);
                Console.ResetColor();

                #endregion
            }
            break;

        case 9:
            {
                #region task9
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("9. 1-den M-edek ededler icherinde 15-e bolunen ededlerin sayini tapan alqoritm.");
                Console.ResetColor();

                int numbers;

                do
                {
                    Console.Write("Enter a number: ");
                    numbers = Convert.ToInt32(Console.ReadLine());
                    if (numbers <= 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please enter a natural number.");
                        Console.ResetColor();
                    }

                } while (numbers <= 0);

                int countOfNumber = 0;

                if (numbers < 15) 
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("There is no number divisible by 15 up to the number you entered."); 
                    Console.ResetColor();
                }

                else
                {
                    for (int i = 1; i <= numbers; i++)
                    {
                        if (i % 15 == 0) countOfNumber++;

                    }

                    Console.ForegroundColor= ConsoleColor.Blue;
                    Console.WriteLine("Count of numbers divisible by 15: " + countOfNumber);
                    Console.ResetColor();
                }

                #endregion
            }
            break;

        case 10:
            {
                #region task10
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("10. 1-den M-edek ededler icherisinde 21-e bolunen ededlerin ededi ortasini tapan alqoritm.");
                Console.ResetColor();

                int m;

                do
                {
                    Console.Write("Please enter a number: ");
                    m = Convert.ToInt32(Console.ReadLine());

                    if (m == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Your number cannot be zero: ");
                        Console.ResetColor();
                    }
                }
                while (m == 0);

                int countOfAverageNumbers = 0;
                int sumOfAverageNumbers = 0;
                decimal average = 0;

                if (m < 0)
                {
                    for (int i = -1; i >= m; i--)
                    {
                        if (i % 21 == 0) { countOfAverageNumbers++; sumOfAverageNumbers += i; }
                    }
                }

                else
                {
                    for (int i = 1; i <= m; i++)
                    {
                        if (i % 21 == 0) { countOfAverageNumbers++; sumOfAverageNumbers += i; }
                    }
                }

                if (countOfAverageNumbers > 0)
                {
                    average = (decimal)sumOfAverageNumbers / countOfAverageNumbers;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("The average of the numbers from 1 to your given number is: " + average);
                    Console.ResetColor();
                }

                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("There are no numbers divisible by 21 up to your given number.");
                    Console.ResetColor();
                }
                #endregion
            }
            break;

        case 11:
            {
                #region task11
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("11. Verilmis N ededinin reqemlerinin cemini tapan alqoritm. (eded 3 ve ya daha cox reqemden ibaret ola biler.");
                Console.ResetColor();

                int givenNum;
                int digitOfNumbers;
                int sumOfNumbers = 0;

                do
                {
                    Console.Write("Please enter a positive number: ");
                    givenNum = Convert.ToInt32(Console.ReadLine());

                    if (givenNum <= 0)
                    {
                        Console.ForegroundColor= ConsoleColor.Red;
                        Console.WriteLine("Your number must be positive and not zero.");
                        Console.ResetColor();
                    }
                }
                while (givenNum <= 0);

                for (int i = givenNum; i > 0; i /= 10)
                {
                    digitOfNumbers = i % 10;
                    sumOfNumbers += digitOfNumbers;
                }
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("The sum of digits is: " + sumOfNumbers);
                Console.ResetColor();

                #endregion
            }
            break;
    }
}





















