using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Uppfinnaren.Models
{
    public class ArtRepository : IArtRepository
    {
        private readonly AppDbContext _appDbContext;

        public ArtRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Art> AllArt
        {
            get
            {
                return _appDbContext.Arts.Include(c => c.Category);
            }
        }

        public IEnumerable<Art> ArtofTheWeek
        {
            get
            {
                return _appDbContext.Arts.Include(c => c.Category).Where(p => p.ArtofTheWeek);
            }
        }

        public Art GetArtById(int artId)
        {
            return _appDbContext.Arts.FirstOrDefault(p => p.ArtId == artId);
        }
    }
}
