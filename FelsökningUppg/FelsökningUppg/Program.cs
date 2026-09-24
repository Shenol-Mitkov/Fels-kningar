namespace FelsökningUppg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Case 1
            //            int number = 2;

            //            if (number > 3)
            //            {                                              // fanns ingen ";"
            //                Console.WriteLine("Talet är större än tre");
            //            }
            // Det stod elseif (måste ha mellanrum)
            //            else if(number < 3)
            //{                                                          // fanns ingen ";"
            //                Console.WriteLine("Talet är mindre än tre");
            //            }

            // Case 2
            // Det stod 100 här, den skriver bara ut till 99 då
            //for (int i = 1; i < 101; i++)
            //{
            //    Console.WriteLine(i);
            //}

            // Case 3               
            // fanns ingen ++
            //for (int i = 1; i <= 5; i ++)
            //{                             // fanns ingen ++
            //    for (int j = 1; j <= i; j ++)
            //    {
            //        Console.Write(j + " ");
            //    }
            //    Console.WriteLine();
            //}


            // Case 4

            //int i = 1;
            //while (i <= 5)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //                    // fanns inget i paranterserna, det stod  Console.Write() 
            //        Console.Write(j);
            //    }

            //    Console.WriteLine();
            //    i++;
            //}

            // Case 5

            //int i = 1;

            //switch (i)
            //{
            //    // Det fanns ingen break; i case 1, därför fortsatte koden
            //    case 1:
            //        break;

            //    case 2:
            //        Console.WriteLine("Two");
            //        break;
            //    default:
            //        Console.WriteLine("Other");
            //        break;
            //}

            // Case 6

            // det stod i = 10, eftersom 10 är större än 5 kommer if satsen aldrig gälla
            //int i = 5;
            //// Det stod bara "=", måste vara "==" för att koden ska kunna jämföra variabeln 
            //if (i == 5)
            //{
            //    Console.WriteLine("i är 5");
            //}



            Console.ReadKey();
        }
    }
}
