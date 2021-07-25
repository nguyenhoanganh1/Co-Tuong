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
    public class ChatService
    {
        private IUnitOfWork unitOfWork;
        private ChatRepository chatRepository;
        public ChatService()
        {
            var dbContextFactory = new DbContextFactory();
            unitOfWork = new UnitOfWork(dbContextFactory);
            chatRepository = new ChatRepository(dbContextFactory);
        }
        public void Save()
        {
            unitOfWork.Commit();
        }

        public void SaveMessage(Chat chat)
        {
            chatRepository.Add(chat);
            Save();
        }

        public List<Chat> GetAllChatByGroup(Guid group)
        {
            return chatRepository.GetAllChatByGroup(group);
        }
    }
}
