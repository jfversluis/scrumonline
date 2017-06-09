using System.Windows.Input;
using FreshMvvm;
using ScrumPoker.Models;
using ScrumPoker.Services;
using Xamarin.Forms;

namespace ScrumPoker.PageModels
{
    public class JoinSessionPageModel : FreshBasePageModel
    {
        public Session CurrentSession { get; private set; }
        public string MyName { get; set; }

        private ICommand _joinSessionCommand;
		public ICommand JoinSessionCommand
		{
			get
			{
				return _joinSessionCommand ??
					(_joinSessionCommand = new Command(ExecuteJoinSessionCommand));
			}
		}

        public override void Init(object initData)
        {
            base.Init(initData);

            var session = initData as Session;

            if (session == null)
                return; // TODO inform user

            CurrentSession = session;
        }

        private async void ExecuteJoinSessionCommand()
        {
            // TODO validation and error handling
            await ScrumPokerService.Instance.JoinSession(CurrentSession, MyName);
        }
    }
}