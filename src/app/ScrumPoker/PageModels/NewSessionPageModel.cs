using System;
using System.Collections.Generic;
using System.Windows.Input;
using FreshMvvm;
using ScrumPoker.Models;
using ScrumPoker.Services;
using Xamarin.Forms;

namespace ScrumPoker.PageModels
{
    public class NewSessionPageModel : FreshBasePageModel
    {
        private string[][] _availableCardSets;

        public Session NewSession { get; } = new Session();

        private ICommand _createSessionsCommand;
		public ICommand CreateSessionCommand
		{
			get
			{
				return _createSessionsCommand ??
					(_createSessionsCommand = new Command(ExecuteCreateSessionCommand));
			}
		}

        public async override void Init(object initData)
        {
            base.Init(initData);

            _availableCardSets = await ScrumPokerService.Instance.GetAvailableCardSets();
        }

        private async void ExecuteCreateSessionCommand()
        {
            // TODO validate
            var createdSession = await ScrumPokerService.Instance.CreateSession(NewSession);

            // TODO enter session
        }
    }
}