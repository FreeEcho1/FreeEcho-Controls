namespace FreeEcho.FEControls;

/// <summary>
/// イメージボタン
/// </summary>
public partial class ImageButton : System.Windows.Controls.Button
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
    public static readonly System.Windows.DependencyProperty BackgroundBrushProperty = System.Windows.DependencyProperty.Register("BackgroundBrush", typeof(System.Windows.Media.Brush), typeof(ImageButton), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xFF, 0xFF, 0xFF)), OnBackgroundBrushChanged));
    /// <summary>
    /// 背景のブラシ
    /// </summary>
    [System.ComponentModel.Category("ImageButton Value")]
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
            if (obj is ImageButton item)
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
        Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xAA, 0xAA, 0xAA)),
        Opacity = 0.0
    };
    /// <summary>
    /// 「マウスオーバーとフォーカスのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty MouseOverAndFocusBrushProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusBrush", typeof(System.Windows.Media.Brush), typeof(ImageButton), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xAA, 0xAA, 0xAA)), OnMouseOverAndFocusBrushChanged));
    /// <summary>
    /// マウスオーバーとフォーカスのブラシ
    /// </summary>
    [System.ComponentModel.Category("ImageButton Value")]
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
            if (obj is ImageButton item)
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
    public static readonly System.Windows.DependencyProperty MouseOverAndFocusOpacityProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusOpacity", typeof(double), typeof(ImageButton), new System.Windows.FrameworkPropertyMetadata(0.0, OnMouseOverAndFocusOpacityChanged));
    /// <summary>
    /// マウスオーバーとフォーカスの透明度
    /// </summary>
    [System.ComponentModel.Category("ImageButton Value")]
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
            if (obj is ImageButton item)
            {
                item.RectangleMouseOverAndFocus.Opacity = item.MouseOverAndFocusOpacity;
            }
        }
        catch
        {
        }
    }
    /// <summary>
    /// 画像
    /// </summary>
    private readonly System.Windows.Controls.Image Image = new()
    {
        Margin = new System.Windows.Thickness(5)
    };
    /// <summary>
    /// 「画像」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty ImageSourceProperty = System.Windows.DependencyProperty.Register("ImageSource", typeof(System.Windows.Media.ImageSource), typeof(ImageButton), new System.Windows.FrameworkPropertyMetadata(null, OnImageSourceChanged));
    /// <summary>
    /// 画像
    /// </summary>
    [System.ComponentModel.Category("ImageButton Value")]
    [System.ComponentModel.Description("画像")]
    public System.Windows.Media.ImageSource ImageSource
    {
        set
        {
            SetValue(ImageSourceProperty, value);
        }
        get
        {
            return ((System.Windows.Media.ImageSource)GetValue(ImageSourceProperty));
        }
    }
    /// <summary>
    /// 「画像」が変更されたイベント
    /// </summary>
    /// <param name="obj"></param>
    /// <param name="e"></param>
    private static void OnImageSourceChanged(
        System.Windows.DependencyObject obj,
        System.Windows.DependencyPropertyChangedEventArgs e
        )
    {
        try
        {
            if (obj is ImageButton item)
            {
                item.Image.Source = item.ImageSource;
            }
        }
        catch
        {
        }
    }
    /// <summary>
    /// テキスト
    /// </summary>
    private readonly System.Windows.Controls.Label LabelText = new()
    {
        Visibility = System.Windows.Visibility.Collapsed,
        VerticalAlignment = System.Windows.VerticalAlignment.Center
    };
    /// <summary>
    /// テキスト
    /// </summary>
    [System.ComponentModel.DefaultValue("")]
    [System.ComponentModel.Category("ImageButton Value")]
    [System.ComponentModel.Description("テキスト")]
    public string Text
    {
        set
        {
            LabelText.Content = value;
            if (string.IsNullOrEmpty((string)LabelText.Content))
            {
                LabelText.Visibility = System.Windows.Visibility.Collapsed;
            }
            else
            {
                LabelText.Visibility = System.Windows.Visibility.Visible;
            }
        }
        get
        {
            return ((string)LabelText.Content);
        }
    }
    /// <summary>
    /// 「テキストのブラシ」の依存プロパティ
    /// </summary>
    public static readonly System.Windows.DependencyProperty TextBrushProperty = System.Windows.DependencyProperty.Register("TextBrush", typeof(System.Windows.Media.Brush), typeof(ImageButton), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xAA, 0xAA, 0xAA)), OnTextBrushChanged));
    /// <summary>
    /// テキストのブラシ
    /// </summary>
    [System.ComponentModel.Category("ImageButton Value")]
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
            if (obj is ImageButton item)
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
    public ImageButton()
    {
        try
        {
            FocusVisualStyle = null;
            Padding = new(0);
            BorderThickness = new(0);
            Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(0x00, 0xFF, 0xFF, 0xFF));

            System.Windows.Controls.ColumnDefinition columnDefinition;
            columnDefinition = new()
            {
                Width = new(0, System.Windows.GridUnitType.Auto)
            };
            GridBackground.ColumnDefinitions.Add(columnDefinition);
            columnDefinition = new()
            {
                Width = new(1, System.Windows.GridUnitType.Star)
            };
            GridBackground.ColumnDefinitions.Add(columnDefinition);
            System.Windows.Controls.Grid.SetColumnSpan(RectangleMouseOverAndFocus, 2);
            System.Windows.Controls.Grid.SetColumn(Image, 0);
            System.Windows.Controls.Grid.SetColumn(LabelText, 1);

            GridBackground.Children.Add(RectangleMouseOverAndFocus);
            GridBackground.Children.Add(Image);
            GridBackground.Children.Add(LabelText);
            AddChild(GridBackground);

            SizeChanged += ImageButton_SizeChanged;
        }
        catch
        {
        }
    }

    /// <summary>
    /// サイズが変更された
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void ImageButton_SizeChanged(
        object sender,
        System.Windows.SizeChangedEventArgs e
        )
    {
        try
        {
            GridBackground.Width = ActualWidth;
            GridBackground.Height = ActualHeight;
        }
        catch
        {
        }
    }
}
