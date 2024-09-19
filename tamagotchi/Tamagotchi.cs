
    public class Tamagotchi
    {
        private int Hunger = 0;
        private int Boredom = 0;
        private List<string> words = new() {"hej"};
        private bool isAlive = true;
        public string Name = "noname";
        

        public void Feed()
        {
            Hunger  -=1;
        }
        public void Hi()
        {
            int i = Random.Shared.Next(words.Count);
            Console.WriteLine(words[i]);
        }
        public void Teach(string word)
        {
            words.Add(word);
            ReduceBoredom();
        }
        public void Tick()
        {
            Hunger +=1;
            Boredom +=1;
            if(Hunger == 10 || Boredom == 10)
            {
                isAlive = false;
            }
        }
        public void PrintStats()
        {
            Console.WriteLine($"Hunger är på {Hunger}");
            Console.WriteLine($"Boredom är på {Boredom}");
            if(isAlive == true)
            {
            Console.WriteLine($"{Name} is alive"); 
            }
            else
            {
                Console.WriteLine($"{Name} is dead");
            }
        }

        public bool GetAlive()
        {
            return isAlive;
        }

        private void ReduceBoredom()
        {
            Boredom -=1;
        }
    }
