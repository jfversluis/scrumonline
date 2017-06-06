using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using ScrumPoker.Models;

namespace ScrumPoker.Interfaces
{
    public interface IScrumPokerService
    {
        [Get("/session/list")]
        Task<ScrumPokerResult<List<Session>>> GetSessions();

        [Post("/session/join")]
        Task<ScrumPokerResult<object>> JoinSession(JoinSessionMessage message);
    }
}