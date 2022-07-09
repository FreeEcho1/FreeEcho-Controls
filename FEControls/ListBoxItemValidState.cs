namespace FreeEcho.FEControls;

/// <summary>
/// 有効状態付きのListBoxItem
/// </summary>
public partial class ListBoxItemValidState : System.Windows.Controls.ListBoxItem
{
    /// <summary>
    /// 背景
    /// </summary>
    private readonly System.Windows.Controls.Grid GridBackground = new()
    {
        Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xFF, 0xFF, 0xFF))
    };
    /// <summary>
    /// 「背景のブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty BackgroundBrushProperty = System.Windows.DependencyProperty.Register("BackgroundBrush", typeof(System.Windows.Media.Brush), typeof(ListBoxItemValidState), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xFF, 0xFF, 0xFF)), OnBackgroundBrushChanged));
    /// <summary>
    /// 背景のブラシ
    /// </summary>
    [System.ComponentModel.Category("ListBoxItemValidState Value")]
    [System.ComponentModel.Description("背景のブラシ")]
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
    /// 「背景のブラシ」が変更されたイベント
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    private static void OnBackgroundBrushChanged(
        System.Windows.DependencyObject obj,
        System.Windows.DependencyPropertyChangedEventArgs e
        )
    {
        try
        {
            if (obj is ListBoxItemValidState item)
            {
                item.GridBackground.Background = item.BackgroundBrush;
            }
        }
        catch
        {
        }
    }
    /// <summary>
    /// マウスオーバーとフォーカスのRectangle
    /// </summary>
    private readonly System.Windows.Shapes.Rectangle RectangleMouseOverAndFocus = new()
    {
        Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xDD, 0xDD, 0xDD)),
        Opacity = 0.0
    };
    /// <summary>
    /// 「マウスオーバーとフォーカスのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty MouseOverAndFocusBrushProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusBrush", typeof(System.Windows.Media.Brush), typeof(ListBoxItemValidState), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xDD, 0xDD, 0xDD)), OnMouseOverAndFocusBrushChanged));
    /// <summary>
    /// マウスオーバーとフォーカスのブラシ
    /// </summary>
    [System.ComponentModel.Category("ListBoxItemValidState Value")]
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
    /// 「マウスオーバーとフォーカスのブラシ」が変更されたイベント
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    private static void OnMouseOverAndFocusBrushChanged(
        System.Windows.DependencyObject obj,
        System.Windows.DependencyPropertyChangedEventArgs e
        )
    {
        try
        {
            if (obj is ListBoxItemValidState item)
            {
                item.RectangleMouseOverAndFocus.Fill = item.MouseOverAndFocusBrush;
            }
        }
        catch
        {
        }
    }
    /// <summary>
    /// 「マウスオーバーとフォーカスの透明度」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty MouseOverAndFocusOpacityProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusOpacity", typeof(double), typeof(ListBoxItemValidState), new System.Windows.FrameworkPropertyMetadata(0.0, OnMouseOverAndFocusOpacityChanged));
    /// <summary>
    /// マウスオーバーとフォーカスの透明度
    /// </summary>
    [System.ComponentModel.Category("ListBoxItemValidState Value")]
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
    /// 「マウスオーバーとフォーカスの透明度」が変更されたイベント
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    private static void OnMouseOverAndFocusOpacityChanged(
        System.Windows.DependencyObject obj,
        System.Windows.DependencyPropertyChangedEventArgs e
        )
    {
        try
        {
            if (obj is ListBoxItemValidState item)
            {
                item.RectangleMouseOverAndFocus.Opacity = item.MouseOverAndFocusOpacity;
            }
        }
        catch
        {
        }
    }
    /// <summary>
    /// 「有効状態」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty IsValidStateProperty = System.Windows.DependencyProperty.Register("IsValidState", typeof(bool), typeof(ListBoxItemValidState), new System.Windows.PropertyMetadata(true));
    /// <summary>
    /// 有効状態
    /// </summary>
    [System.ComponentModel.Category("ListBoxItemValidState Value")]
    [System.ComponentModel.Description("有効状態")]
    public bool IsValidState
    {
        set
        {
            SetValue(IsValidStateProperty, value);
        }
        get
        {
            return ((bool)GetValue(IsValidStateProperty));
        }
    }
    /// <summary>
    /// テキスト
    /// </summary>
    private readonly System.Windows.Controls.Label LabelText = new()
    {
        VerticalAlignment = System.Windows.VerticalAlignment.Center,
        Margin = new(5, 0, 0, 0),
        Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0x00, 0x00, 0x00))
    };
    /// <summary>
    /// テキスト
    /// </summary>
    [System.ComponentModel.Category("ListBoxItemValidState Value")]
    [System.ComponentModel.Description("テキスト")]
    public string Text
    {
        set
        {
            LabelText.Content = value;
        }
        get
        {
            return ((string)LabelText.Content);
        }
    }
    /// <summary>
    /// 「テキストのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty TextBrushProperty = System.Windows.DependencyProperty.Register("TextBrush", typeof(System.Windows.Media.Brush), typeof(ListBoxItemValidState), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0x00, 0x00, 0x00)), OnTextBrushChanged));
    /// <summary>
    /// テキストのブラシ
    /// </summary>
    [System.ComponentModel.Category("ListBoxItemValidState Value")]
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
    /// 「テキストのブラシ」が変更されたイベント
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    private static void OnTextBrushChanged(
        System.Windows.DependencyObject obj,
        System.Windows.DependencyPropertyChangedEventArgs e
        )
    {
        try
        {
            if (obj is ListBoxItemValidState item)
            {
                item.LabelText.Foreground = item.TextBrush;
            }
        }
        catch
        {
        }
    }

    /// <summary>
    /// コンストラクタ
    /// </summary>
    public ListBoxItemValidState()
    {
        FocusVisualStyle = null;
        HorizontalContentAlignment = System.Windows.HorizontalAlignment.Stretch;
        VerticalContentAlignment = System.Windows.VerticalAlignment.Stretch;
        Padding = new(0);
        BorderThickness = new(0);
        Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(0x00, 0xFF, 0xFF, 0xFF));

        GridBackground.Children.Add(RectangleMouseOverAndFocus);
        GridBackground.Children.Add(LabelText);
        AddChild(GridBackground);
    }
}
