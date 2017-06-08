using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;
using ScrumPoker.Models;

namespace ScrumPoker.Interfaces
{
    public interface IScrumPokerService
    {
        [Get("/session/list")]
        Task<List<Session>> GetSessions();

        [Put("/session/member/{sessionId}")]
        Task JoinSession(int sessionId, [Body]Member member);

        [Post("/session/create")]
        Task<ScrumPokerResult<object>> CreateSession(Session session);
    }
}