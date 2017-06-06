using System.Collections.ObjectModel;
using FreshMvvm;
using MvvmHelpers;
using ScrumPoker.Models;
using ScrumPoker.Services;

namespace ScrumPoker.PageModels
{
    public class ScrumPokerPageModel : FreshBasePageModel
    {
        private readonly ObservableRangeCollection<Session> _sessions = new ObservableRangeCollection<Session>();
		public ObservableCollection<Session> Sessions { get { return _sessions; } }

        private Session _selectedSession;
        public Session SelectedSession
		{
			get { return _selectedSession; }
			set
			{
				_selectedSession = value;

				if (_selectedSession == null)
					return;

                CoreMethods.PushPageModel<JoinSessionPageModel>(_selectedSession);

				SelectedSession = null;
			}
		}

        public async override void Init(object initData)
        {
            base.Init(initData);

            var sessions = await ScrumPokerService.Instance.GetSessions();

            _sessions.ReplaceRange(sessions);
        }
    }
}