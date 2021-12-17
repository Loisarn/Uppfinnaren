using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Inlämning_Uppfinnaren.Models
{
    public interface IArtRepository
    {
        IEnumerable<Art> AllArt { get; }
        IEnumerable<Art> ArtofTheWeek { get; }
        Art GetArtById(int pieId);
    }
}
