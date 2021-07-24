using Lib.Data;
using Lib.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib.Repositories
{
    public interface IChatRepository : IRepository<Chat>
    {
        List<Chat> GetAllChatByGroup(Guid group);
    }
    public class ChatRepository : RepositoryBase<Chat>, IChatRepository
    {
        public ChatRepository(DbContextFactory factory)
           : base(factory)
        {

        }

        public List<Chat> GetAllChatByGroup(Guid group)
        {
            var query = dataContext.Chat.Where(x => x.GroupName == group);
            return query.ToList();
        }

    }
}
