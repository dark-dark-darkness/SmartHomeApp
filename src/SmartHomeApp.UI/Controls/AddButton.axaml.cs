using System.Windows.Input;

using Avalonia;
using Avalonia.Controls;

namespace SmartHomeApp.UI.Controls;

public partial class AddButton : UserControl
{
    public AddButton()
    {
        InitializeComponent();
    }

    #region Title

    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<AddButton, string>(nameof(Title), string.Empty, false);

    public string Title { get => GetValue(TitleProperty); set => SetValue(TitleProperty, value); }

    #endregion

    #region Command

    public static readonly StyledProperty<ICommand?> CommandProperty = AvaloniaProperty.Register<AddButton, ICommand?>(nameof(Command), null, false);

    public ICommand? Command { get => GetValue(CommandProperty); set => SetValue(CommandProperty, value); }

    #endregion

    #region CommandParameter

    public static readonly StyledProperty<object?> CommandParameterProperty = AvaloniaProperty.Register<AddButton, object?>(nameof(CommandParameter), null, false);

    public object? CommandParameter { get => GetValue(CommandParameterProperty); set => SetValue(CommandParameterProperty, value); }

    #endregion

}