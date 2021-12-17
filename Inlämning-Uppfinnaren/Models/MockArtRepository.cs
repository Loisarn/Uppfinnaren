using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämning_Uppfinnaren.Models
{
    public class MockArtRepository: IArtRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Art> AllArt =>
            new List<Art>
            {
                new Art {ArtId = 1, Name="Monkey Statue", Price=200.00M, Description="Monkey statue made of Wood", ImageUrl="/Images/apa.jpg"},
                new Art {ArtId = 2, Name="Slinky", Price=40.00M, Description="Colorful toy", ImageUrl="/Images/slinky.jpg"},
                new Art {ArtId = 3, Name="Tamagotchi", Price=99.00M, Description="A small pet", ImageUrl="/Images/Tamagotchi.jpg"}
            };

        public IEnumerable<Art> ArtofTheWeek { get; }
        public Art GetArtById(int artId)
        {
            return AllArt.FirstOrDefault(p => p.ArtId == artId);
        }
    }
}
