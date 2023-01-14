using Perseus.Models;

namespace Perseus.Mvvm
{
    /// <summary>
    /// The base class for all ViewModels
    /// </summary>
    public abstract class ViewModel : NotificationObject, IInitializable
    {
        /// <summary>
        /// Initialize a new instance of the <see cref="ViewModel"/> class
        /// </summary>
        protected ViewModel()
        {
        }


        private bool isBusy;

        /// <summary>
        /// Whether the ViewModel is busy
        /// </summary>
        public bool IsBusy
        {
            get => isBusy;
            protected set => Set(ref isBusy, value);
        }


        #region Initialize

        private bool isInitialized;

        /// <inheritdoc/>
        public bool IsInitialized
        {
            get => isInitialized;
            protected set => Set(ref isInitialized, value);
        }

        /// <summary>
        /// Initialize the ViewModel
        /// </summary>
        protected virtual void Initialize()
        {
            IsInitialized = true;
        }

        /// <summary>
        /// Initialize the ViewModel asynchronously
        /// </summary>
        /// <returns></returns>
        protected virtual Task InitializeAsync()
        {
            return Task.Run(Initialize);
        }

        void IInitializable.Initialize()
        {
            Initialize();
        }

        #endregion

    }
}
