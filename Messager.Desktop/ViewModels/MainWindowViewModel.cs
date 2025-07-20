using ReactiveUI;

namespace Messager.Desktop.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private ViewModelBase _contentViewModel;

    public MainWindowViewModel()
    {
        Login = new LoginViewModel();
        _contentViewModel = Login;
    } 
    public LoginViewModel Login { get; }
    public ViewModelBase ContentViewModel
    {
        get => _contentViewModel;
        private set => this.RaiseAndSetIfChanged(ref _contentViewModel, value);
    }
    public void BackToLoginPageButton()
    {
        ContentViewModel = new LoginViewModel();
    }

    public void RegistrationButton()
    {
        ContentViewModel = new RegistrationViewModel();
    }
}