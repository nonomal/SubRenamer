using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.DependencyInjection;
using CommunityToolkit.Mvvm.Input;
using SubRenamer.Services;
using Microsoft.Extensions.DependencyInjection;
using SubRenamer.Helper;
using SubRenamer.Model;

namespace SubRenamer.ViewModels;

public partial class SettingsViewModel : ViewModelBase
{
    private bool _backupEnabled = Config.Backup;
    private bool _updateCheckEnabled = Config.UpdateCheck;
    private string _videoExtAppend = Config.VideoExtAppend;
    private string _subtitleExtAppend = Config.SubtitleExtAppend;

    public bool BackupEnabled
    {
        get => _backupEnabled;
        set
        {
            Config.Backup = value;
            SetProperty(ref _backupEnabled, value);
        }
    }
    
    public bool UpdateCheckEnabled
    {
        get => _updateCheckEnabled;
        set
        {
            Config.UpdateCheck = value;
            SetProperty(ref _updateCheckEnabled, value);
        }
    }

    public string VideoExtAppend
    {
        get => _videoExtAppend;
        set
        {
            Config.VideoExtAppend = value;
            SetProperty(ref _videoExtAppend, value);
        }
    }
    
    public string SubtitleExtAppend
    {
        get => _subtitleExtAppend;
        set
        {
            Config.SubtitleExtAppend = value;
            SetProperty(ref _subtitleExtAppend, value);
        }
    }
    
    [RelayCommand]
    private void OpenLink(string url) => BrowserHelper.OpenBrowserAsync(url);
}