using System;

namespace Model
{
    public class Export
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int PlaceId { get; set; }
        public string PlaceName { get; set; }

        public Export() { }

        public Export(int id, string name, DateTime date, User user, Place place)
        {
            Id = id;
            Name = name;
            Date = date;
            UserId = user.Id;
            UserName = user.Name;
            PlaceId = place.Id;
            PlaceName = place.Name;
        }

        public Export(string name, DateTime date, string userName, string placeName)
        {
            Name = name;
            Date = date;
            UserName = userName;
            PlaceName = placeName;
        }
    }
}
