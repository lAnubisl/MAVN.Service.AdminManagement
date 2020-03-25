using System.Threading.Tasks;

namespace Lykke.Service.AdminManagement.Domain.Services
{
    public interface INotificationsService
    {
        Task NotifyAdminCreatedAsync(string adminUserId, string email, string login, string password, string name);
        Task NotifyAdminPasswordResetAsync(string adminUserId, string email, string login, string password, string name);
    }
}