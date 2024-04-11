using Model;
using System;
using System.Collections.Generic;

namespace MockData
{
    public class MockDbContext
    {
        private const int _usersCount = 50;
        private const int _placesCount = 10;
        private const int _exportsCount = 3000;

        private readonly Random _random = new Random();

        private IList<Export> _exports;
        private IList<Place> _places;
        private IList<User> _users;

        public MockDbContext() 
        {
            FillUsers();
            FillPlaces();
            FillExports();
        }

        internal IList<Export> Exports => _exports;
        internal IList<Place> Places => _places;
        internal IList<User> Users => _users;

        private void FillUsers()
        {
            _users = new List<User>();
            
            for (int i = 1; i <= _usersCount; i++) 
            { 
                _users.Add(new User(i, $"Użytkownik {i}"));
            }
        }

        private void FillPlaces()
        {
            _places = new List<Place>();
            
            for (int i = 1; i <= _placesCount; i++)
            {
                _places.Add(new Place(i, $"Lokal {i}"));
            }
        }

        private void FillExports()
        {
            _exports = new List<Export>();

            for (int i = 1; i <= _exportsCount; i++)
            {
                var userId = _random.Next(0, _usersCount);
                var placeId = _random.Next(0, _placesCount);

                _exports.Add(new Export(
                    i,
                    $"Export {i}",
                    DateTime.Now.AddHours(-i),
                    _users[userId],
                    _places[placeId]));
            }
        }
    }
}
