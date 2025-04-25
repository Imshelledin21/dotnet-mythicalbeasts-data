using mythicalbeasts_data.DataModels;

namespace mythicalbeasts_data.Global
{
    public static class MythicalBeasts
    {
        public static List<MythicalBeast> Current { get; set; }

        static Random rand = new Random();

        static List<string> names = new List<string> {
        "Zarok", "Thalindra", "Grobnar", "Elaris", "Karn", "Myrrh", "Zephra", "Drakon", "Nyx", "Vorin",
        "Isolde", "Ragnar", "Balthor", "Selene", "Kael", "Lyra", "Mordekai", "Fenra", "Syrin", "Talon",
        "Orin", "Vaelis", "Kira", "Thorne", "Aeris"
        };

        static List<string> types = new List<string> {
        "Dragon", "Phoenix", "Griffin", "Unicorn", "Basilisk", "Chimera", "Hydra", "Minotaur", "Centaur", "Kraken"
        };

        static List<string> jobs = new List<string> {
        "Guardian", "Seer", "Warrior", "Healer", "Messenger", "Hunter", "Scribe", "Enchanter", "Scout", "Protector"
        };

        static string GenerateDescription(string name, string type, string job)
        {
            return $"{name} is a {type} known for their skills as a {job}.";
        }

        public static List<MythicalBeast> GenerateMythicalBeasts()
        {
            var beasts = new List<MythicalBeast>();

            for (int i = 0; i < 25; i++)
            {
                string name = names[i % names.Count]; // Ensures unique-ish names
                string type = types[rand.Next(types.Count)];
                string job = jobs[rand.Next(jobs.Count)];

                beasts.Add(new MythicalBeast
                {
                    Id = i + 1,
                    Name = name,
                    Type = type,
                    Job = job,
                    Description = GenerateDescription(name, type, job)
                });
            }
            return beasts;
        }
    }
}
