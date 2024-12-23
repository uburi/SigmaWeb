using Radzen;

namespace SigmaWeb.Util
{
    public static class MessageScreen
    {
        public static void ShowMessage(NotificationService _notificationService, string title, string subTitle, NotificationSeverity severity, double duration = 4000, int maxNotifications = 3)
        {
            if (duration < 2000)
            {
                duration = 2000;
            }

            var message = new NotificationMessage();
            message.Duration = duration;
            //message.Style = "top: 90px !important;position: fixed;";
            message.Style = "animation-name: animate-notification-in; " +
                "animation-direction: normal; " +
                $"animation-duration: {duration}ms; " +
                "animation-fill-mode: both; " +
                "animation-timing-function: ease-out; ";
            message.Summary = title;
            message.Detail = subTitle;
            message.Severity = severity;

            if (_notificationService.Messages.Count < maxNotifications)
            {
                _notificationService.Notify(message);
            }


            #region Inserir estas linhas no site.css para animar a notificação
            //@keyframes animate-notification -in {0 % {transform: translateX(350px);opacity: 0.2;}5 % {transform: translateX(0px);opacity: 1;}95 % {transform: translateX(0px);opacity: 1;}100 % {transform: translateX(350px);opacity: 0.2;}}
            #endregion
        }
    }
}
