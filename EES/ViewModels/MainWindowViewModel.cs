using Prism.Mvvm;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using System;
using System.Reactive.Disposables;

namespace EES.ViewModels
{
    internal class MainWindowViewModel : BindableBase, IDisposable
    {
        private CompositeDisposable disposable = new CompositeDisposable();

        public MainWindowViewModel()
        {
            this.CloseWindowCommand = IsActiveCloseWIndowCommand.ToReactiveCommand().AddTo(this.disposable);
            this.CloseWindowCommand.Subscribe(s => OnClickCloseWindowCommand()).AddTo(this.disposable);
        }

        public ReactivePropertySlim<string> Title { get; } = new ReactivePropertySlim<string>("Employee Evaluation System");

        public ReactiveCommand CloseWindowCommand { get; } = new ReactiveCommand();

        public ReactiveProperty<bool> IsActiveCloseWIndowCommand = new ReactiveProperty<bool>(true);

        public void OnClickCloseWindowCommand()
            => App.Current.MainWindow.Close();

        public void Dispose()
            => this.disposable.Dispose();
    }
}
