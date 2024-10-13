namespace andra_saken
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("the forrest");
            List<Animal> forrest = new List<Animal>();
            forrest.Add(new Owl(3500, true, 94));
            forrest.Add(new Horse(1200, false, 30));
            forrest.Add(new Dolphin(100000, false, 3750));

            bool day = true;

            while (true)

            {
                string key = Console.ReadKey().Key.ToString();

                Console.Clear();

                // Console.WriteLine(key);
                switch (key)
                {
                    case "D":
                        day = true;
                        Console.WriteLine("Nu är det dag!");
                        break;
                    case "N":
                        day = false;
                        Console.WriteLine("Nu är det natt!");
                        break;

                }

                foreach (Animal animal in forrest)
                {
                    Console.Write("vikt: " + animal.Weight + " Noctural " + animal.Noctural);

                    if (animal is Owl)
                    {
                        Console.WriteLine("wingspan:  " + ((Owl)animal).Wingspan);
                    }
                    if (animal is Horse)
                    {
                        Console.WriteLine("hay per day: " + ((Horse)animal).HayPerDay);
                    }
                    if (animal is Dolphin)
                    {
                        Dolphin dolphin = (Dolphin)animal;
                        Console.WriteLine("distance per day: " + dolphin.DistancePerDay);
                    }
                }

              


            // List<Owl> OwlsInForrest = new List<Owl>();

            // OwlsInForrest.Add(new Owl(3500, true, 94));
            }

        }
    } 
}
