using System;
using System.Windows;
using System.Windows.Input;
using WpfApp1.Infrastructure.Commands;
using WpfApp1.ViewModels.Base;
using static System.Windows.Application;

namespace WpfApp1.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    #region Window Title
        /// <summary>
        /// Window Title
        /// </summary>
    private string _title = "zalupa";
    public string Title
    {
        get => _title;
        set => SetField(ref _title, value);
    }

    #endregion

    #region StatusBar

    private string _status = "Downloading";

    public string Status
    {
        get => _status;
        set => SetField(ref _status, value);
    }

    #endregion

    #region Commands

    #region ExitCommand

    

    public ICommand Exit
    {
        get;
    }

    private void OnExitExecuted(object p)
    {
       Application.Current.Shutdown();
    }

    private bool CanExitExecuted(object p) => true;
    #endregion
    #endregion
    
    public MainWindowViewModel()
    {
        #region Commands

        Exit = new LambdaCommand(OnExitExecuted, CanExitExecuted);

        #endregion
    }
}
