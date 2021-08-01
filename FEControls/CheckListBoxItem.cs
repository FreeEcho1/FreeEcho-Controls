namespace FreeEcho
{
    namespace FEControls
    {
        /// <summary>
        /// Check ListBox Item
        /// </summary>
        public class CheckListBoxItem : System.Windows.Controls.ListBoxItem
        {
            /// <summary>
            /// 背景
            /// </summary>
            private readonly System.Windows.Controls.Grid BackgroundGrid = new()
            {
                Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xFF, 0xFF, 0xFF))
            };
            /// <summary>
            /// 「背景のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty BackgroundBrushProperty = System.Windows.DependencyProperty.Register("BackgroundBrush", typeof(System.Windows.Media.Brush), typeof(CheckListBoxItem), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xFF, 0xFF, 0xFF)), OnBackgroundBrushChanged));
            /// <summary>
            /// 背景のブラシ
            /// </summary>
            [System.ComponentModel.Category("CheckListBoxItem Value")]
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
                    if (obj is CheckListBoxItem item)
                    {
                        item.BackgroundGrid.Background = item.BackgroundBrush;
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
                Opacity = 0.0,
                IsHitTestVisible = false
            };
            /// <summary>
            /// 「マウスオーバーとフォーカスのブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty MouseOverAndFocusBrushProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusBrush", typeof(System.Windows.Media.Brush), typeof(CheckListBoxItem), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0xAA, 0xAA, 0xAA)), OnMouseOverAndFocusBrushChanged));
            /// <summary>
            /// マウスオーバーとフォーカスのブラシ
            /// </summary>
            [System.ComponentModel.Category("CheckListBoxItem Value")]
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
            /// マウスオーバーとフォーカスのブラシが変更されたイベント
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
                    if (obj is CheckListBoxItem item)
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
            public static readonly System.Windows.DependencyProperty MouseOverAndFocusOpacityProperty = System.Windows.DependencyProperty.Register("MouseOverAndFocusOpacity", typeof(double), typeof(CheckListBoxItem), new System.Windows.FrameworkPropertyMetadata(0.0, OnMouseOverAndFocusOpacityChanged));
            /// <summary>
            /// マウスオーバーとフォーカスの透明度
            /// </summary>
            [System.ComponentModel.Category("CheckListBoxItem Value")]
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
                    if (obj is CheckListBoxItem item)
                    {
                        item.RectangleMouseOverAndFocus.Opacity = item.MouseOverAndFocusOpacity;
                    }
                }
                catch
                {
                }
            }
            /// <summary>
            /// CheckBox
            /// </summary>
            private readonly System.Windows.Controls.CheckBox CheckBox = new()
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Left,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                Margin = new(2, 0, 0, 0)
            };
            /// <summary>
            /// チェック状態変更のイベントハンドラ
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            public delegate void EventHandlerCheckStateChanged(
                object sender,
                CheckListBoxItemEventArgs e
                );
            /// <summary>
            /// チェック状態変更イベント
            /// </summary>
            public event EventHandlerCheckStateChanged CheckStateChanged;
            /// <summary>
            /// チェック状態が変更されたイベントを実行
            /// </summary>
            public virtual void DoCheckStateChanged()
            {
                CheckStateChanged?.Invoke(this, new(this));
            }
            /// <summary>
            /// テキスト
            /// </summary>
            private readonly System.Windows.Controls.Label LabelText = new()
            {
                HorizontalAlignment = System.Windows.HorizontalAlignment.Left,
                VerticalAlignment = System.Windows.VerticalAlignment.Center,
                Margin = new(25, 0, 0, 0),
                Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0x00, 0x00, 0x00))
            };
            /// <summary>
            /// 「テキストのブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty TextBrushProperty = System.Windows.DependencyProperty.Register("TextBrush", typeof(System.Windows.Media.Brush), typeof(CheckListBoxItem), new System.Windows.FrameworkPropertyMetadata(new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromRgb(0x00, 0x00, 0x00)), OnTextBrushChanged));
            /// <summary>
            /// テキストのブラシ
            /// </summary>
            [System.ComponentModel.Category("CheckListBoxItem Value")]
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
                    if (obj is CheckListBoxItem item)
                    {
                        item.LabelText.Foreground = item.TextBrush;
                    }
                }
                catch
                {
                }
            }
            /// <summary>
            /// テキスト
            /// </summary>
            [System.ComponentModel.DefaultValue("")]
            [System.ComponentModel.Category("CheckListBoxItem Value")]
            [System.ComponentModel.Description("テキスト")]
            public object Text
            {
                set
                {
                    LabelText.Content = value;
                }
                get
                {
                    return (LabelText.Content);
                }
            }
            /// <summary>
            /// チェック状態
            /// </summary>
            [System.ComponentModel.DefaultValue(false)]
            [System.ComponentModel.Category("CheckListBoxItem Value")]
            [System.ComponentModel.Description("チェック状態")]
            public bool IsChecked
            {
                set
                {
                    CheckBox.IsChecked = value;
                }
                get
                {
                    return ((bool)CheckBox.IsChecked);
                }
            }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            public CheckListBoxItem()
            {
                FocusVisualStyle = null;
                HorizontalContentAlignment = System.Windows.HorizontalAlignment.Stretch;
                VerticalContentAlignment = System.Windows.VerticalAlignment.Stretch;
                BorderThickness = new(0);
                Padding = new(0);
                Background = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Color.FromArgb(0x00, 0x00, 0x00, 0x00));

                BackgroundGrid.Children.Add(RectangleMouseOverAndFocus);
                BackgroundGrid.Children.Add(CheckBox);
                BackgroundGrid.Children.Add(LabelText);
                AddChild(BackgroundGrid);

                IsEnabledChanged += CheckListBoxItem_IsEnabledChanged;
                CheckBox.Click += CheckBox_Click;
            }

            /// <summary>
            /// 「IsEnabled」イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void CheckListBoxItem_IsEnabledChanged(
                object sender,
                System.Windows.DependencyPropertyChangedEventArgs e
                )
            {
                try
                {
                    CheckBox.IsEnabled = IsEnabled;
                }
                catch
                {
                }
            }

            /// <summary>
            /// チェックボックスがクリックされた
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void CheckBox_Click(
                object sender,
                System.Windows.RoutedEventArgs e
                )
            {
                try
                {
                    DoCheckStateChanged();
                }
                catch
                {
                }
            }
        }
    }
}
