using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IPositiontRepository : IRepository<ChessPosition>
    {

    }
    public class PositionRepository : RepositoryBase<ChessPosition>, IPositiontRepository
    {
        public PositionRepository(DbContextFactory factory)
           : base(factory)
        {

        }

    }
}
