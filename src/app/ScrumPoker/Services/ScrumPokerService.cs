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
            var result = await _scrumPokerService.GetSessions();

            if (result.Success)
                return result.Result;

            return null;
        }

		public async Task JoinSession(Session session, string name)
		{
            var joinMessage = new JoinSessionMessage
            {
                Id = session.Id,
                Name = name
            };

            // TODO implement error handling
            var result = await _scrumPokerService.JoinSession(joinMessage);

			if (result.Success)
            {
                // TODO implement further
            }
		}

        public async Task CreateSession(Session session)
        {
            var result = await _scrumPokerService.CreateSession(session);

            if (result.Success)
            {
                // TODO implement further
            }
        }
    }
}