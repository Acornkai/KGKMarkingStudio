using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Input;
using Avalonia.Controls;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace KGKMarkingStudio.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    private bool _isExpand = true;
    private int _minLeftMenuWidth = 58;
    private int _maxLeftMenuWidth = 200;
    private int _step = 10;
    private int _interval = 20;
    private DispatcherTimer _timer = null;
    private Control _leftMenu = null;
    
    
     //private string _greeting = "Welcome to Avalonia!";

    [AutoNotify] private ViewModelBase _currentPage;

    public RelayCommand<object> HamburgerMenuCommand { get; set; }
    public ICommand DashboardCommand { get; set; }
    public ICommand DesignerCommand { get; set;}
    public ICommand MaterialCommand { get; set;}
    public ICommand SettingsCommand { get; set;}
    public ICommand UsersCommand { get; set;}

    private void InitTimer()
    {
        if (_timer == null)
        {
            _timer = new DispatcherTimer();
            _timer.Interval = new TimeSpan(0, 0, 0, 0, _interval);
            _timer.Tick += (sender, args) =>
            {
                //现在是展开状态
                if (_isExpand && _leftMenu != null)
                {
                    _leftMenu.Width -= _step;
                    if (_leftMenu.Width <= _minLeftMenuWidth)
                    {
                        _leftMenu.Width = _minLeftMenuWidth;
                        _timer.Stop();
                        _isExpand = false;
                    }
                }
                else if(_leftMenu != null)
                {
                    _leftMenu.Width += _step;
                    if (_leftMenu.Width >= _maxLeftMenuWidth)
                    {
                        _leftMenu.Width = _maxLeftMenuWidth;
                        _timer.Stop();
                        _isExpand = true;
                    }
                }
            };
        } 
    }

    public MainViewModel() : base(null)
    {
        //CurrentPage = new DesignerViewModel(null, null, null);
        InitTimer();

        HamburgerMenuCommand = new RelayCommand<object>((param) =>
        {
            _leftMenu = param as Control;
            _timer.Start();
        });
        DashboardCommand = new RelayCommand(() =>
        {
            CurrentPage = new DashboardViewModel();
            
            Trace.WriteLine("=========== Dashboard ============");
            
        });
        DesignerCommand = new RelayCommand(() =>
        {
            CurrentPage = new DesignerViewModel(null, null, null);
            
            Trace.WriteLine("=========== Designer ============");
            
        });
        MaterialCommand = new RelayCommand(() =>
        {
            CurrentPage = new MaterialViewModel(null);
            
            Trace.WriteLine("=========== Material ============");
            
        });
        SettingsCommand = new RelayCommand(() =>
        {
            CurrentPage = new SettingsViewModel(null);
            
            Trace.WriteLine("=========== Settings ============");
            
        });
        UsersCommand = new RelayCommand(() =>
        {
            CurrentPage = new UsersViewModel(null);
            
            Trace.WriteLine("=========== Users ============");
            
        });
    }


    public override object Copy(IDictionary<object, object>? source)
    {
        throw new NotImplementedException();
    }
}