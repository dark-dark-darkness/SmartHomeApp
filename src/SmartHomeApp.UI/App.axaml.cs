using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Threading.Tasks;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Input;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;

using Meadow;
using Meadow.Pinouts;

using ReactiveUI;

using SmartHomeApp.UI.ViewModels;
using SmartHomeApp.UI.Views;
namespace SmartHomeApp.UI;

public partial class App :
#if LINUX
    AvaloniaMeadowApplication<Linux<RaspberryPi>>
#else
    Application
#endif
{

    public override void Initialize()
    {
        AvaloniaXamlLoader.Load(this);
#if LINUX
        LoadMeadowOS();
#endif
    }

#if LINUX
    public override Task InitializeMeadow()
    {
        var r = Resolver.Services.Get<IMeadowDevice>();

        if (r == null)
        {
            Resolver.Log.Info("IMeadowDevice is null");
        }
        else
        {
            Resolver.Log.Info($"IMeadowDevice is {r.GetType().Name}");
        }

        return Task.CompletedTask;

    }
#endif

    public override void OnFrameworkInitializationCompleted()
    {
        var view = new MainView
        {
            DataContext = new MainViewModel()
        };
        if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
        {
            var window = new ReactiveWindow<object> { Content = view };
            window.WhenActivated(_ =>
            {
                Observable
                    .FromEventPattern<PointerPressedEventArgs>(view, nameof(view.PointerPressed))
                    .Where(e => e.EventArgs.Pointer.Type is PointerType.Mouse)
                    .Subscribe(e => window.BeginMoveDrag(e.EventArgs))
                    .DisposeWith(_);
            });
            desktop.MainWindow = window;
        }
        else if (ApplicationLifetime is ISingleViewApplicationLifetime singleViewPlatform)
        {
            singleViewPlatform.MainView = view;
        }

        base.OnFrameworkInitializationCompleted();
    }
}
