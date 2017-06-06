using System;
using System.Windows.Input;
using FreshMvvm;
using ScrumPoker.Models;
using ScrumPoker.Services;
using Xamarin.Forms;

namespace ScrumPoker.PageModels
{
    public class NewSessionPageModel : FreshBasePageModel
    {
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

        private void ExecuteCreateSessionCommand()
        {
            // TODO validate
            ScrumPokerService.Instance.CreateSession(NewSession);

            // TODO enter session
        }
    }
}