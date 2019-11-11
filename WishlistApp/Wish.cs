namespace WishlistApp
{
    class Wish
    {
        public readonly string Name;

        private int priority;

        public int Priority {
            get { return priority; } 
            private set { priority = 0 >= value ? 1 : value; }
        }

        public Wish(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
    }
}
