using EES.Core.Mvvm;
using Prism.Regions;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Reactive.Disposables;

namespace EES.Modules.ViewModels.Header
{
    public class HeaderViewModel : RegionViewModelBase, IDisposable
    {
        private CompositeDisposable disposables = new CompositeDisposable();

        public HeaderViewModel(IRegionManager regionManager) : base(regionManager)
        {
            this.Title = new ReactivePropertySlim<string>("Employee Evaluation System");

            this.CloseWindowCommand = IsActiveWIndowCloseCommand.ToReactiveCommand().AddTo(this.disposables);
            this.CloseWindowCommand.Subscribe(s => OnClickCloseWindowCommand()).AddTo(this.disposables);
        }

        public ReactivePropertySlim<string> Title { get; }

        public ReactiveCommand CloseWindowCommand { get; } = new ReactiveCommand();

        public ReactiveProperty<bool> IsActiveWIndowCloseCommand = new ReactiveProperty<bool>(true);

        public void OnClickCloseWindowCommand()
        {
            App.Current.MainWindow.Close();
        }

        public void Dispose() => this.disposables.Dispose();
    }
}
