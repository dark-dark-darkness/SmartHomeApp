using System.Windows.Input;

using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace SmartHomeApp.UI.Controls;
public partial class Card : UserControl
{
    public Card()
    {
        InitializeComponent();
    }

    #region Title

    public static readonly StyledProperty<string> TitleProperty = AvaloniaProperty.Register<Card, string>(nameof(Title), string.Empty, false);

    public string Title { get => GetValue(TitleProperty); set => SetValue(TitleProperty, value); }

    #endregion

    #region IsChecked

    public static readonly StyledProperty<bool> IsCheckedProperty = AvaloniaProperty.Register<Card, bool>(nameof(IsChecked), false, false);

    public bool IsChecked { get => GetValue(IsCheckedProperty); set => SetValue(IsCheckedProperty, value); }

    #endregion

    #region IsHorizontal

    public static readonly StyledProperty<bool> IsHorizontalProperty = AvaloniaProperty.Register<Card, bool>(nameof(IsHorizontal), false, false);

    public bool IsHorizontal { get => GetValue(IsHorizontalProperty); set => SetValue(IsHorizontalProperty, value); }

    #endregion

    #region ImageOn

    public static readonly StyledProperty<IImage?> ImageOnProperty = AvaloniaProperty.Register<Card, IImage?>(nameof(ImageOn), null, false);

    public IImage? ImageOn { get => GetValue(ImageOnProperty); set => SetValue(ImageOnProperty, value); }

    #endregion

    #region ImageOff

    public static readonly StyledProperty<IImage?> ImageOffProperty = AvaloniaProperty.Register<Card, IImage?>(nameof(ImageOff), null, false);

    public IImage? ImageOff { get => GetValue(ImageOffProperty); set => SetValue(ImageOffProperty, value); }

    #endregion

    #region Command

    public static readonly StyledProperty<ICommand?> CommandProperty = AvaloniaProperty.Register<Card, ICommand?>(nameof(Command), null, false);

    public ICommand? Command { get => GetValue(CommandProperty); set => SetValue(CommandProperty, value); }

    #endregion

    #region CommandParameter

    public static readonly StyledProperty<object?> CommandParameterProperty = AvaloniaProperty.Register<Card, object?>(nameof(CommandParameter), null, false);

    public object? CommandParameter { get => GetValue(CommandParameterProperty); set => SetValue(CommandParameterProperty, value); }

    #endregion

}
