namespace FreeEcho.FEControls;

/// <summary>
/// MessageBoxのウィンドウ
/// </summary>
public partial class MessageBoxWindow : System.Windows.Window
{
    /// <summary>
    /// 「OK」ボタンの文字列
    /// </summary>
    public static string Ok
    {
        get;
        set;
    } = "OK";
    /// <summary>
    /// 「Yes」ボタンの文字列
    /// </summary>
    public static string Yes
    {
        get;
        set;
    } = "Yes";
    /// <summary>
    /// 「No」ボタンの文字列
    /// </summary>
    public static string No
    {
        get;
        set;
    } = "No";
    /// <summary>
    /// 「Cancel」ボタンの文字列
    /// </summary>
    public static string Cancel
    {
        get;
        set;
    } = "Cancel";
    /// <summary>
    /// 使用するスタイル
    /// </summary>
    public static System.Uri UseStyle
    {
        get;
        set;
    }
    /// <summary>
    /// 使用するスタイルのURI
    /// </summary>
    public static string UseStyleUri
    {
        get;
        set;
    }
    /// <summary>
    /// 押されたボタン
    /// </summary>
    public MessageBoxResult Result
    {
        get;
        set;
    } = MessageBoxResult.Cancel;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public MessageBoxWindow()
    {
        InitializeComponent();
        Initialize("", "", MessageBoxButton.None, null);
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="title">タイトル</param>
    /// <param name="message">メッセージ</param>
    /// <param name="button">表示するボタン</param>
    /// <param name="parentWindow">親ウィンドウ</param>
    public MessageBoxWindow(
        string title,
        string message,
        MessageBoxButton button,
        System.Windows.Window parentWindow
        )
    {
        InitializeComponent();

        Initialize(title, message, button, parentWindow);
    }

    /// <summary>
    /// 初期化
    /// </summary>
    /// <param name="title">タイトル</param>
    /// <param name="message">メッセージ</param>
    /// <param name="button">表示するボタン</param>
    /// <param name="parentWindow">親ウィンドウ</param>
    private void Initialize(
        string title,
        string message,
        MessageBoxButton button,
        System.Windows.Window parentWindow
        )
    {
        try
        {
            if (parentWindow == null)
            {
                WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            }
            else
            {
                Owner = parentWindow;
            }
        }
        catch
        {
        }
        try
        {
            if (UseStyle != null)
            {
                SkinResourceDictionary.Source = UseStyle;
            }
            else if (UseStyleUri != null)
            {
                SkinResourceDictionary.Source = new(UseStyleUri);
            }
        }
        catch
        {
        }
        Title = title;
        MessageTextBlock.Text = message;
        switch (button)
        {
            case MessageBoxButton.None:
                OkButton.Visibility = System.Windows.Visibility.Collapsed;
                YesButton.Visibility = System.Windows.Visibility.Collapsed;
                NoButton.Visibility = System.Windows.Visibility.Collapsed;
                CancelButton.Visibility = System.Windows.Visibility.Collapsed;
                break;
            case MessageBoxButton.Ok:
                OkButton.Visibility = System.Windows.Visibility.Visible;
                OkButton.Focus();
                YesButton.Visibility = System.Windows.Visibility.Collapsed;
                NoButton.Visibility = System.Windows.Visibility.Collapsed;
                CancelButton.Visibility = System.Windows.Visibility.Collapsed;
                break;
            case MessageBoxButton.YesNo:
                OkButton.Visibility = System.Windows.Visibility.Collapsed;
                YesButton.Visibility = System.Windows.Visibility.Visible;
                YesButton.Focus();
                NoButton.Visibility = System.Windows.Visibility.Visible;
                CancelButton.Visibility = System.Windows.Visibility.Collapsed;
                break;
            case MessageBoxButton.YesCancel:
                OkButton.Visibility = System.Windows.Visibility.Collapsed;
                YesButton.Visibility = System.Windows.Visibility.Visible;
                YesButton.Focus();
                NoButton.Visibility = System.Windows.Visibility.Collapsed;
                CancelButton.Visibility = System.Windows.Visibility.Visible;
                break;
            case MessageBoxButton.YesNoCancel:
                OkButton.Visibility = System.Windows.Visibility.Collapsed;
                YesButton.Visibility = System.Windows.Visibility.Visible;
                YesButton.Focus();
                NoButton.Visibility = System.Windows.Visibility.Visible;
                CancelButton.Visibility = System.Windows.Visibility.Visible;
                break;
        }
        OkButton.Content = Ok;
        YesButton.Content = Yes;
        NoButton.Content = No;
        CancelButton.Content = Cancel;

        System.Windows.Media.FormattedText formattedText = new(title, System.Globalization.CultureInfo.CurrentUICulture, System.Windows.FlowDirection.LeftToRight, new System.Windows.Media.Typeface(FontFamily, FontStyle, FontWeight, FontStretch), FontSize, System.Windows.Media.Brushes.Black, System.Windows.Media.VisualTreeHelper.GetDpi(this).PixelsPerDip);
        MinWidth = formattedText.Width + 80;
        MaxWidth = System.Windows.SystemParameters.WorkArea.Width - 80;

        Loaded += MessageBoxWindow_Loaded;
        OkButton.Click += OkButton_Click;
        YesButton.Click += YesButton_Click;
        NoButton.Click += NoButton_Click;
        CancelButton.Click += CancelButton_Click;
    }

    /// <summary>
    /// ウィンドウの「Loaded」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void MessageBoxWindow_Loaded(
        object sender,
        System.Windows.RoutedEventArgs e
        )
    {
        try
        {
            Activate();
        }
        catch
        {
        }
    }

    /// <summary>
    /// 「OK」Buttonの「Click」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OkButton_Click(
        object sender,
        System.Windows.RoutedEventArgs e
        )
    {
        try
        {
            Result = MessageBoxResult.Ok;
            Close();
        }
        catch
        {
        }
    }

    /// <summary>
    /// 「Yes」Buttonの「Click」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void YesButton_Click(
        object sender,
        System.Windows.RoutedEventArgs e
        )
    {
        try
        {
            Result = MessageBoxResult.Yes;
            Close();
        }
        catch
        {
        }
    }

    /// <summary>
    /// 「No」Buttonの「Click」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void NoButton_Click(
        object sender,
        System.Windows.RoutedEventArgs e
        )
    {
        try
        {
            Result = MessageBoxResult.No;
            Close();
        }
        catch
        {
        }
    }

    /// <summary>
    /// 「Cancel」Buttonの「Click」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void CancelButton_Click(
        object sender,
        System.Windows.RoutedEventArgs e
        )
    {
        try
        {
            Result = MessageBoxResult.Cancel;
            Close();
        }
        catch
        {
        }
    }
}
