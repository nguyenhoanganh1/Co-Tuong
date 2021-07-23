using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{

    public interface IChessPositionRepository : IRepository<ChessPosition>
    {
    }


    public class ChessPositionRepository : RepositoryBase<ChessPosition>, IChessPositionRepository
    {

        public ChessPositionRepository(DbContextFactory factory)
           : base(factory)
        {

        }

    }
}
