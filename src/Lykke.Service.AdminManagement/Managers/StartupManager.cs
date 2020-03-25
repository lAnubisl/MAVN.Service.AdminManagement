using System.Threading.Tasks;
using Lykke.Service.AdminManagement.Domain.Services;
using Lykke.Sdk;
using Lykke.Service.NotificationSystem.SubscriberContract;

namespace Lykke.Service.AdminManagement.Managers
{
    public class StartupManager : IStartupManager
    {
        private readonly IRabbitPublisher<EmailMessageEvent> _emailMessageEventPublisher;

        public StartupManager(IRabbitPublisher<EmailMessageEvent> emailMessageEventPublisher)
        {
            _emailMessageEventPublisher = emailMessageEventPublisher;
        }

        public Task StartAsync()
        {
            _emailMessageEventPublisher.Start();

            return Task.CompletedTask;
        }
    }
}