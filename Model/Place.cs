namespace Model
{
    public class Place
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Place() { }

        public Place(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString() => Name;
    }
}
