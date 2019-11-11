namespace WishlistApp
{
    class Wish
    {
        public readonly string Name;

        private int priority;

        public int Priority {
            get { return priority; } 
            private set {
                if (0 >= value)
                {
                    value = 1;
                }

                priority = value;
            }
        }

        public Wish(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
    }
}
