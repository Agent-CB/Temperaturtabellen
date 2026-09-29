namespace Temperaturtabellen
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] Månader = new int[3, 3];

            Månader[0, 0] = 23;
            Månader[0, 1] = 18;
            Månader[0, 2] = 12;

            Månader[1, 0] = 19;
            Månader[1, 1] = 22;
            Månader[1, 2] = 11;

            Månader[2, 0] = 21;
            Månader[2, 1] = 18;
            Månader[2, 2] = 10;

            string[] städer = { "Eskilstuna", "Stockholm", "Nyköping" };
            string[] månader = { "Juni", "Juli", "Augusti" };

            for (int j = 0; j < 3; j++)
            {
                Console.Write(månader[j] + " ");
            }

            Console.WriteLine();

            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(städer[i] + " ");

                for (int j = 0; j < 3; j++)
                {
                    Console.Write(Månader[i, j] + " ");
                }

                Console.WriteLine();
            }

        }
    }
}
