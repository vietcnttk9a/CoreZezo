using System.Threading.Tasks;

namespace PMS.Identity
{
    public interface ISmsSender
    {
        Task SendAsync(string number, string message);
    }
}