using Caliburn.Micro;

namespace XamarinMVVMTemplate.ViewModels
{    
    public class HomeViewModel : Conductor<object>
    {
        private readonly IEventAggregator _eventAggregator;
        private string _txtName;

        public string txtName
        {
            get { return _txtName; }
            set
            {
                _txtName = value;
                NotifyOfPropertyChange(() => txtName);
            }
        }
        public HomeViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            //_eventAggregator.SubscribeOnPublishedThread(this);
            txtName = "Dicoba dulu yak!!";
        }
    }    
}
