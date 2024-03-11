namespace clubMemberIndexer
{
    internal class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            // constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    Members[i] = string.Empty;
                }
                ClubType = string.Empty;
                ClubLocation = string.Empty;
                MeetingDate = string.Empty;
            }
            //indexer get and set methods
            public string this[int index]
            {
                get
                {
                    return Members[index];
                }
                set
                {
                    Members[index] = value;
                }
            }

        }

        static void Main(string[] args)
        {
            ClubMembers clubMembers = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub = 0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which member would you like to enter? (1-{Size})");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1 and {Size}");
                }
                Console.WriteLine("Enter the name of the member");
                clubMembers[sub - 1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, press q to quit");
                string quit = Console.ReadLine();
                if(quit == "q")
                    end = true;
            }
            Console.WriteLine("What is the club type?");
            clubMembers.ClubType = Console.ReadLine();
            Console.WriteLine("Where is the club located?");
            clubMembers.ClubLocation = Console.ReadLine();
            Console.WriteLine("When is the club meeting date?");
            clubMembers.MeetingDate = Console.ReadLine();

            Console.WriteLine("Club info: ");
            Console.WriteLine("Club members");
            for (int i = 0; i < Size; i++)
            {
                if (clubMembers[i] != string.Empty)
                    Console.WriteLine(clubMembers[i]);
            }
            Console.WriteLine($"Club Type: {clubMembers.ClubType}");
            Console.WriteLine($"Club Location: {clubMembers.ClubLocation}");
            Console.WriteLine($"Meeting Date: {clubMembers.MeetingDate}");
        }
    }
}
