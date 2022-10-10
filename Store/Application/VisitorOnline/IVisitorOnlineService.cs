using System.Collections.Generic;
using System.Text;

namespace Application.Visitors.VisitorOnline
{
    public interface IVisitorOnlineService
    {
        void ConnectUser(string ClientId);
        void DisConnectUser(string ClientId);
        int GetCount();
    }
}
