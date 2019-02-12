using Abp.Notifications;
using PMS.Dto;

namespace PMS.Notifications.Dto
{
    public class GetUserNotificationsInput : PagedInputDto
    {
        public UserNotificationState? State { get; set; }
    }
}