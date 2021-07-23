using Lib.Data;
using Lib.Entities;
using Lib.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Services
{
    public class ChessPositionService
    {
        private IUnitOfWork unitOfWork;
        private ChessPositionRepository positionRepository;
        public ChessPositionService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            positionRepository = new ChessPositionRepository(dbContextFactory);
        }
        public void Save()
        {
            unitOfWork.Commit();
        }

        public void SavePosition(ChessPosition chess)
        {
            positionRepository.Add(chess);
            Save();
        }
    }
}
