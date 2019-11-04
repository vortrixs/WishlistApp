namespace WishlistApp
{
    class Wish
    {
        public string Name { get; set; }
        public int Priority { get; set; }

        public Wish(string name, int priority)
        {
            Name = name;
            Priority = priority;
        }
    }
}
