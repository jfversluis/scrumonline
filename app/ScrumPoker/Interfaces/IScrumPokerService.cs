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
        Task<Session> CreateSession(Session session);

        [Get("/session/cardsets")]
        Task<string[][]> GetAvailableCardSets();
    }
}