using System;
using System.Collections.Generic;
using System.Text;
using Tahaluf.MyChannel.core.data;
using Tahaluf.MyChannel.Core.DTO;
using Tahaluf.MyChannel.Core.Repository;

namespace Tahaluf.MyChannel.Infra.Repository
{
    public class NotificationRepository : INotificationRepository
    {
        public bool CREATENOTIFICATION(Notification_ notification_)
        {
            throw new NotImplementedException();
        }

        public bool DELETENOTIFICATION(int notificationId)
        {
            throw new NotImplementedException();
        }

        public List<Notification_> GETALLNOTIFICATION()
        {
            throw new NotImplementedException();
        }

        public List<BadReportTextDTO> GetBadReportTextOnChannel(int notificationId)
        {
            throw new NotImplementedException();
        }

        public bool UPDATENOTIFICATION(Notification_ notification_)
        {
            throw new NotImplementedException();
        }
    }
}
