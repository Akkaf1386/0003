//Tamrin03.MohammadparsaAkkaf

Console.WriteLine("Enter the number");

do
{
    String input = Console.ReadLine();

    int n = int.Parse(input);

    for (int p = 2; p < n - 1; p++)
    {
        int m = n - p;

        bool x = true;
        bool y = true;


        for (int k = p - 1; k > 1; k--)
        {
            if (p % k == 0)
            {
                x = false;
                break;
            }
        }


        for (int k = m - 1; k > 1; k--)
        {
            if (m % k == 0)
            {
                y = false;
                break;
            }
        }

        if (x == true && y == true)
        {
            Console.WriteLine(p + "," + m);
        }
    }




    Console.WriteLine("........................");
    Console.WriteLine("Now enter another number");
}
while (true);
