namespace OPersei.Mvvm
{
    public abstract class ViewModel : NotificationObject
    {
        protected ViewModel()
        {
        }

        private bool _isInitialized;
        private bool _isBusy;

        public bool IsInitialized
        {
            get => _isInitialized;
            protected set => Set(ref _isInitialized, value);
        }

        public bool IsBusy
        {
            get => _isBusy;
            protected set => Set(ref _isBusy, value);
        }

        protected virtual void Initialize()
        {
            IsInitialized = true;
        }

        protected virtual Task InitializeAsync()
        {
            return Task.Run(Initialize);
        }
    }
}
