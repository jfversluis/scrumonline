using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Refit;
using ScrumPoker.Interfaces;
using ScrumPoker.Models;

namespace ScrumPoker.Services
{
    public class ScrumPokerService
    {
        private readonly IScrumPokerService _scrumPokerService;
		private static Lazy<ScrumPokerService> _instance = new Lazy<ScrumPokerService>(() => new ScrumPokerService());
		public static ScrumPokerService Instance => _instance.Value;

        public ScrumPokerService()
        {
			var httpClient = new HttpClient
			{
                BaseAddress = new Uri(Constants.ApiAddress)
			};

            _scrumPokerService = RestService.For<IScrumPokerService>(httpClient);
        }

        public async Task<List<Session>> GetSessions()
        {
            // TODO implement error handling
            return await _scrumPokerService.GetSessions();
        }

		public async Task JoinSession(Session session, string name)
        {
            // TODO implement error handling
            await _scrumPokerService.JoinSession(session.Id, new Member()
            {
                Name = name
            });
		}

        public async Task CreateSession(Session session)
        {
			// TODO implement error handling
			await _scrumPokerService.CreateSession(session);
        }
    }
}