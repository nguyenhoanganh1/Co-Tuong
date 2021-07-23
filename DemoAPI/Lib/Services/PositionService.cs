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
    public class PositionService
    {
        private IUnitOfWork unitOfWork;

        PositionRepository positionRepository;
        public PositionService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            positionRepository = new PositionRepository(dbContextFactory);
        }
        public void Save()
        {
            unitOfWork.Commit();
        }
        public void SavePosition(ChessPosition positions)
        {

            positionRepository.Add(positions);
            Save();
        }
    }
}