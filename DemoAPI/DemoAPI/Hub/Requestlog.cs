using DemoAPI.Models;
using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DemoAPI
{
    public class Requestlog : Hub
    {
        public static void PostToClient(string data)
        {
            try
            {
                var chat = GlobalHost.ConnectionManager.GetHubContext("Requestlog");
                if (chat != null)
                    chat.Clients.All.postToClient(data);
            }
            catch
            {
            }
        }

        public void JoinGroup(ChatGroupModel model)
        {
            Groups.Add(Context.ConnectionId, model.GroupName);
            Clients.Group(model.GroupName).messageGroup(model.UserName, model.Message);
        }

        public void LeaveGroup(ChatGroupModel model)
        {
            Groups.Remove(Context.ConnectionId, model.GroupName);
            Clients.Group(model.GroupName).messageGroup(model.UserName, model.Message);
        }
    }
}