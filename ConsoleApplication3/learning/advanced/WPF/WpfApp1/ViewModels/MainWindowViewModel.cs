using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Input;

using WpfApp1.Infrastructure.Commands;
using WpfApp1.ViewModels.Base;
using WpfApp1.Models;
using static System.Windows.Application;
using DataPoint = WpfApp1.Models.DataPoints;

namespace WpfApp1.ViewModels;

internal class MainWindowViewModel : ViewModel
{
    #region TestDataPoints : TYPE - DESC

    private List<DataPoints> _testDataPoints;

    public List<DataPoints> TestDataPoints
    {
        get => _testDataPoints;
        set => SetField(ref _testDataPoints, value);
    }
    

    #endregion
    
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

        #region DataPoints

        var dataPoints = new List<DataPoints>((int) (360 / 0.1));
        for (var x = 0d; x <= 360; x+= 0.1)
        {
            const double toRead = Math.PI;
            var y = Math.Sin(x - toRead);
            dataPoints.Add(new DataPoints{XValue = x, YValue = y});
        }

        TestDataPoints = dataPoints;

        #endregion
    }
}
