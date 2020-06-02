using NotSimpleGame.DL.Abstraction.Repositories;
using NotSimpleGame.Entities;
using System.Collections.Generic;
using System.Linq;

namespace NotSimpleGame.DL.Implementation.Repositories
{
    public class CharactersRepository : GenericRepository<CharacterEntity, int>, ICharactersRepository
    {
        public CharactersRepository(NotSimpleGameDBContext dbContext) : base(dbContext)
        {

        }
    }
}
