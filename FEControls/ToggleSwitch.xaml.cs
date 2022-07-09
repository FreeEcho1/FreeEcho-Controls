namespace FreeEcho.FEControls;

/// <summary>
/// ToggleSwitch
/// </summary>
public partial class ToggleSwitch : System.Windows.Controls.UserControl
{
    /// <summary>
    /// 「IsOn」変更イベントハンドラ
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate void IsOnChangeEventHandler(
        object sender,
        ToggleSwitchEventArgs e
        );
    /// <summary>
    /// 「IsOn」変更イベント
    /// </summary>
    public event IsOnChangeEventHandler IsOnChange;
    /// <summary>
    /// 「IsOnChange」イベントを実行
    /// </summary>
    public virtual void DoIsOnChange()
    {
        IsOnChange?.Invoke(this, new());
    }
    /// <summary>
    /// 「有効状態」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty IsOnProperty = System.Windows.DependencyProperty.Register("IsOn", typeof(bool), typeof(ToggleSwitch), new System.Windows.FrameworkPropertyMetadata(false, IsOnChanged));
    /// <summary>
    /// On/Off
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("On/Off")]
    public bool IsOn
    {
        set
        {
            SetValue(IsOnProperty, value);
            DoIsOnChange();
        }
        get
        {
            return ((bool)GetValue(IsOnProperty));
        }
    }
    /// <summary>
    /// 「On/Off」が変更されたイベント
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    private static void IsOnChanged(
        System.Windows.DependencyObject obj,
        System.Windows.DependencyPropertyChangedEventArgs e
        )
    {
        try
        {
            if (obj is ToggleSwitch item)
            {
                item.SwitchFrontRectangle.Margin = item.IsOn ? new(23, 0, 0, 0) : new(1, 0, 0, 0);
            }
        }
        catch
        {
        }
    }
    /// <summary>
    /// On/Off (イベントを発生させない)
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("On/Off (イベントを発生させない)")]
    public bool IsOnDoNotEvent
    {
        set
        {
            SetValue(IsOnProperty, value);
        }
        get
        {
            return ((bool)GetValue(IsOnProperty));
        }
    }
    /// <summary>
    /// 「トグルスイッチの背景のブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty BackgroundBrushProperty = System.Windows.DependencyProperty.Register("BackgroundBrush", typeof(System.Windows.Media.Brush), typeof(ToggleSwitch), new System.Windows.PropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xCC, 0xCC, 0xCC))));
    /// <summary>
    /// トグルスイッチの背景のブラシ
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("トグルスイッチの背景のブラシ")]
    public System.Windows.Media.Brush BackgroundBrush
    {
        set
        {
            SetValue(BackgroundBrushProperty, value);
        }
        get
        {
            return ((System.Windows.Media.Brush)GetValue(BackgroundBrushProperty));
        }
    }
    /// <summary>
    /// 「トグルスイッチのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty ToggleSwitchBrushProperty = System.Windows.DependencyProperty.Register("ToggleSwitchBrush", typeof(System.Windows.Media.Brush), typeof(ToggleSwitch), new System.Windows.PropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xAA, 0xAA, 0xAA))));
    /// <summary>
    /// トグルスイッチのブラシ
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("トグルスイッチのブラシ")]
    public System.Windows.Media.Brush ToggleSwitchBrush
    {
        set
        {
            SetValue(ToggleSwitchBrushProperty, value);
        }
        get
        {
            return ((System.Windows.Media.Brush)GetValue(ToggleSwitchBrushProperty));
        }
    }
    /// <summary>
    /// テキスト
    /// </summary>
    [System.ComponentModel.DefaultValue("")]
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("テキスト")]
    public object Text
    {
        get
        {
            return (TextLabel.Content);
        }
        set
        {
            TextLabel.Content = value;
            TextLabel.Visibility = string.IsNullOrEmpty(TextLabel.Content as string) ? System.Windows.Visibility.Collapsed : System.Windows.Visibility.Visible;
        }
    }
    /// <summary>
    /// 「テキストのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty TextBrushProperty = System.Windows.DependencyProperty.Register("TextBrush", typeof(System.Windows.Media.Brush), typeof(ToggleSwitch), new System.Windows.PropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0x00, 0x00, 0x00))));
    /// <summary>
    /// テキストのブラシ
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("テキストのブラシ")]
    public System.Windows.Media.Brush TextBrush
    {
        set
        {
            SetValue(TextBrushProperty, value);
        }
        get
        {
            return ((System.Windows.Media.Brush)GetValue(TextBrushProperty));
        }
    }
    /// <summary>
    /// 「マウスオーバーとフォーカスのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty MouseOverAndFocusBrushProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusBrush", typeof(System.Windows.Media.Brush), typeof(ToggleSwitch));
    /// <summary>
    /// マウスオーバーとフォーカスのブラシ
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("マウスオーバーとフォーカスのブラシ")]
    public System.Windows.Media.Brush MouseOverAndFocusBrush
    {
        set
        {
            SetValue(MouseOverAndFocusBrushProperty, value);
        }
        get
        {
            return ((System.Windows.Media.Brush)GetValue(MouseOverAndFocusBrushProperty));
        }
    }
    /// <summary>
    /// 「マウスオーバーとフォーカスの透明度」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty MouseOverAndFocusOpacityProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusOpacity", typeof(double), typeof(ToggleSwitch));
    /// <summary>
    /// マウスオーバーとフォーカスの透明度
    /// </summary>
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("マウスオーバーとフォーカスの透明度")]
    public double MouseOverAndFocusOpacity
    {
        set
        {
            SetValue(MouseOverAndFocusOpacityProperty, value);
        }
        get
        {
            return ((double)GetValue(MouseOverAndFocusOpacityProperty));
        }
    }
    /// <summary>
    /// 「トグルスイッチにマウスカーソルが触れているかの値」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty IsTheMouseCursorInTheSwitchProperty = System.Windows.DependencyProperty.Register("IsTheMouseCursorInTheSwitch", typeof(bool), typeof(ToggleSwitch));
    /// <summary>
    /// トグルスイッチにマウスカーソルが触れているかの値
    /// </summary>
    [System.ComponentModel.DefaultValue(false)]
    [System.ComponentModel.Category("ToggleSwitch Value")]
    [System.ComponentModel.Description("トグルスイッチにマウスカーソルが触れているかの値")]
    public bool IsTheMouseCursorInTheSwitch
    {
        set
        {
            SetValue(IsTheMouseCursorInTheSwitchProperty, value);
        }
        get
        {
            return ((bool)GetValue(IsTheMouseCursorInTheSwitchProperty));
        }
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ToggleSwitch()
    {
        InitializeComponent();

        ToggleSwitchButton.Click += ButtonSwitch_Click;
        ToggleSwitchButton.MouseEnter += ButtonSwitch_MouseEnter;
        ToggleSwitchButton.MouseLeave += ButtonSwitch_MouseLeave;
    }

    /// <summary>
    /// 「Click」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonSwitch_Click(
        object sender,
        System.Windows.RoutedEventArgs e
        )
    {
        try
        {
            IsOn = !IsOn;
            Focus();
        }
        catch
        {
        }
    }

    /// <summary>
    /// 「MouseEnter」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonSwitch_MouseEnter(
        object sender,
        System.Windows.Input.MouseEventArgs e
        )
    {
        try
        {
            IsTheMouseCursorInTheSwitch = true;
        }
        catch
        {
        }
    }

    /// <summary>
    /// 「MouseLeave」イベント
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ButtonSwitch_MouseLeave(
        object sender,
        System.Windows.Input.MouseEventArgs e
        )
    {
        try
        {
            IsTheMouseCursorInTheSwitch = false;
        }
        catch
        {
        }
    }

    /// <summary>
    /// キーが離された
    /// </summary>
    /// <param name="e"></param>
    protected override void OnKeyUp(
        System.Windows.Input.KeyEventArgs e
        )
    {
        try
        {
            base.OnKeyUp(e);
            if (e.Key == System.Windows.Input.Key.Space)
            {
                IsOn = !IsOn;
            }
        }
        catch
        {
        }
    }
}
