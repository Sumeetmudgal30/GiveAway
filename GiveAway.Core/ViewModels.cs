using System;
using MvvmCross.Core.ViewModels;
using MvvmCross.FieldBinding;
using GiveAway.Core.Services;
namespace GiveAway.Core.ViewModels
{

	public class LogInPageViewModel : MvxViewModel
	{
        IAuthenticateService _AuthenticateService;

        public LogInPageViewModel( IAuthenticateService auth)
        {
            _AuthenticateService = auth;
        }

		public override void Start()
		{
            _UserName.Value = "";
            _Password.Value = "";
            _Authenticated.Value = false;
			base.Start();
		}


		public readonly INC<string> _UserName = new NC<string>();
		public readonly INC<string> _Password = new NC<string>();
        public readonly INC<bool> _Authenticated = new NC<bool>();

        public bool AuthenticateUser()
        {
            return  _AuthenticateService.AuthenticateUser(_UserName.Value, _Password.Value);

        }

	}

	public class ProfilePageViewModel : MvxViewModel
	{
        //How to add an image Property

        public ProfilePageViewModel()
        {

        }

		public override void Start()
		{
			base.Start();
		}

        public readonly INC<string> _UserName = new NC<string>();
		public readonly INC<string> _Location = new NC<string>();
		public readonly INC<string> _Email = new NC<string>();
        public readonly INC<string> _PaymentOption = new NC<string>();

	}


    public class HomePageViewModel:MvxViewModel
    {
        public HomePageViewModel()
        {



        }

		public override void Start()
		{
			base.Start();
		}

		MvxObservableCollection<ContestCardViewModel> ContestCards = new MvxObservableCollection<ContestCardViewModel>();

	}

	public class ContestCardConstructionPageViewModel : ContestCardViewModel
	{
        public ContestCardConstructionPageViewModel()
        {

        }

		public override void Start()
		{
			base.Start();
		}
        //how to add an image Property
        public readonly INC<int> _EstLikes = new NC<int>();
		public readonly INC<int> _EstFollowers = new NC<int>();
		public readonly INC<int> _EstShares = new NC<int>();
		public readonly INC<int> _EstComments = new NC<int>();
		public readonly INC<int> _CriteriaLikes = new NC<int>();
		public readonly INC<int> _CriteriaFollowers = new NC<int>();
		public readonly INC<int> _CriteriaShares = new NC<int>();
		public readonly INC<int> _CriteriaComments = new NC<int>();
        public readonly INC<bool> _FormGroups = new NC<bool>();


        MvxObservableCollection<MemberViewModel> Owners = new MvxObservableCollection<MemberViewModel>();
        MvxObservableCollection<MemberViewModel> Members = new MvxObservableCollection<MemberViewModel>();


	}

	public class ContestCardViewModel : MvxViewModel
	{

        public ContestCardViewModel()
        {

        }

		public override void Start()
		{
			base.Start();
		}
        //How to add an image Property
        public readonly INC<ContestCategoryByLifeCycle> _LifeCycleStat = new NC<ContestCategoryByLifeCycle>();
		public readonly INC<string> _ContestID = new NC<string>();
		public readonly INC<string> _ContestName = new NC<string>();
		public readonly INC<string> _Description = new NC<string>();
		public readonly INC<int> _ReceivedLikes = new NC<int>();
		public readonly INC<int> _ReceivedFollowers = new NC<int>();
		public readonly INC<int> _ReceivedShares = new NC<int>();
		public readonly INC<int> _ReceivedComments = new NC<int>();

		private System.DateTime _EndTime;

		public System.DateTime EndingTime
		{
			get { return _EndTime; }
			set
			{
				_EndTime = value;
				RaisePropertyChanged(() => _EndTime);
			}
		}


		private System.DateTime _StartTime;

		public System.DateTime StartingTime
		{
			get { return _StartTime; }
			set
			{
				_StartTime = value;
				RaisePropertyChanged(() => _StartTime);
			}
		}
	}

	public class ChatPageViewModel : MvxViewModel
	{

        public ChatPageViewModel()
        {

        }

		public override void Start()
		{
			base.Start();
		}
        //How to add an image Property
        public readonly INC<string> _UserName = new NC<string>();
		public readonly INC<string> _Message = new NC<string>();
        MvxObservableCollection<ChatViewModel> Owners = new MvxObservableCollection<ChatViewModel>();

	}

	public class ChatViewModel : MvxViewModel
	{
		public ChatViewModel()
        {

        }

		public override void Start()
		{
			base.Start();
		}
        //How to add an image Property
		public readonly INC<string> _UserName = new NC<string>();
		public readonly INC<string> _Message = new NC<string>();

	}


	public class MemberViewModel : MvxViewModel
	{
		public MemberViewModel()
        {

        }

		public override void Start()
		{
			base.Start();
		}
        //How to add an image Property
		public readonly INC<string> _UserName = new NC<string>();
        public readonly INC<string> _Location = new NC<string>();

	}

    public enum ContestCategoryByLifeCycle
    {
        Construction,
        Advertize,
        Active,
        Completed

    }


	public enum ContestCategoryByAcceptance
	{
		Closed,
		Open,
        InviteOnly

	}

	public enum ContestCategoryByRequirement
	{
		Monetary,
		FollowerCount,
        Location
	}

}
