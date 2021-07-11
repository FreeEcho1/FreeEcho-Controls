namespace FreeEcho
{
    namespace FEControls
    {
        /// <summary>
        /// NumericUpDown
        /// </summary>
        public partial class NumericUpDown : System.Windows.Controls.UserControl
        {
            /// <summary>
            /// 最小値
            /// </summary>
            private decimal PrivateMinimumValue = decimal.MinValue;
            /// <summary>
            /// 最小値
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("最小値")]
            public decimal MinimumValue
            {
                get
                {
                    return (PrivateMinimumValue);
                }
                set
                {
                    PrivateMinimumValue = value;
                    Value = PrivateValue;
                }
            }
            /// <summary>
            /// 最大値
            /// </summary>
            private decimal PrivateMaximumValue = decimal.MaxValue;
            /// <summary>
            /// 最大値
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("最大値")]
            public decimal MaximumValue
            {
                get
                {
                    return (PrivateMaximumValue);
                }
                set
                {
                    PrivateMaximumValue = value;
                    Value = PrivateValue;
                }
            }
            /// <summary>
            /// 値
            /// </summary>
            private decimal PrivateValue = 0;
            /// <summary>
            /// 値
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("値")]
            public decimal Value
            {
                get
                {
                    return (PrivateValue);
                }
                set
                {
                    try
                    {
                        if (IsUseDecimal)
                        {
                            PrivateValue = System.Math.Round(value, NumberOfDecimalPlaces);
                            if (PrivateValue < MinimumValue)
                            {
                                PrivateValue = MinimumValue;
                            }
                            else if (MaximumValue < PrivateValue)
                            {
                                PrivateValue = MaximumValue;
                            }
                            NumberTextBox.Text = string.Format("{0:f" + NumberOfDecimalPlaces + "}", PrivateValue);
                        }
                        else
                        {
                            PrivateValue = System.Math.Round(value);
                            if (PrivateValue < MinimumValue)
                            {
                                PrivateValue = MinimumValue;
                            }
                            else if (MaximumValue < PrivateValue)
                            {
                                PrivateValue = MaximumValue;
                            }
                            NumberTextBox.Text = PrivateValue.ToString();
                        }
                    }
                    catch
                    {
                    }
                }
            }
            /// <summary>
            /// 値 (int)
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("値")]
            public int ValueInt
            {
                get
                {
                    return ((int)Value);
                }
                set
                {
                    Value = value;
                }
            }
            /// <summary>
            /// 少数を使用する
            /// </summary>
            private bool PrivateIsUseDecimal = false;
            /// <summary>
            /// 少数を使用する
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("少数を使用する")]
            public bool IsUseDecimal
            {
                get
                {
                    return (PrivateIsUseDecimal);
                }
                set
                {
                    PrivateIsUseDecimal = value;
                    Regex = PrivateIsUseDecimal ? new("^[0-9-.]*$") : new("^[0-9-]*$");
                    Value = PrivateValue;
                }
            }
            /// <summary>
            /// 小数点以下の桁数
            /// </summary>
            private int PrivateNumberOfDecimalPlaces = 1;
            /// <summary>
            /// 小数点以下の桁数
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("小数点以下の桁数")]
            public int NumberOfDecimalPlaces
            {
                get
                {
                    return (PrivateNumberOfDecimalPlaces);
                }
                set
                {
                    PrivateNumberOfDecimalPlaces = value;
                    Value = PrivateValue;
                }
            }
            /// <summary>
            /// 整数の増減値
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("整数の増減値")]
            public int IntegerIncrementDecrement
            {
                get;
                set;
            } = 1;
            /// <summary>
            /// 少数の増減値
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("少数の増減値")]
            public decimal DecimalIncrementDecrement
            {
                get;
                set;
            } = 0.1m;
            /// <summary>
            /// 正規表現
            /// </summary>
            private System.Text.RegularExpressions.Regex Regex = new("^[0-9-]*$");
            /// <summary>
            /// 値が変更されたイベント
            /// </summary>
            public event System.EventHandler<NumericUpDownChangeValueArgs> ChangeValue;
            /// <summary>
            /// 値が変更されたイベントを実行
            /// </summary>
            public virtual void DoChangeValue()
            {
                ChangeValue?.Invoke(this, new());
            }
            /// <summary>
            /// 「TextBoxの背景のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty TextBoxBackgroundBrushProperty = System.Windows.DependencyProperty.Register("TextBoxBackgroundBrush", typeof(System.Windows.Media.Brush), typeof(NumericUpDown), new System.Windows.FrameworkPropertyMetadata(OnTextBoxBackgroundBrushChanged));
            /// <summary>
            /// TextBoxの背景のブラシ
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("TextBoxの背景のブラシ")]
            public System.Windows.Media.Brush TextBoxBackgroundBrush
            {
                set
                {
                    SetValue(TextBoxBackgroundBrushProperty, value);
                }
                get
                {
                    return ((System.Windows.Media.Brush)GetValue(TextBoxBackgroundBrushProperty));
                }
            }
            /// <summary>
            /// 「TextBoxの背景のブラシ」が変更されたイベント
            /// </summary>
            /// <param name="obj"></param>
            /// <param name="e"></param>
            private static void OnTextBoxBackgroundBrushChanged(
                System.Windows.DependencyObject obj,
                System.Windows.DependencyPropertyChangedEventArgs e
                )
            {
                try
                {
                    if (obj is NumericUpDown item)
                    {
                        item.NumberTextBox.Background = item.TextBoxBackgroundBrush;
                    }
                }
                catch
                {
                }
            }
            /// <summary>
            /// 「TextBoxの前景のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty TextBoxForegroundBrushProperty = System.Windows.DependencyProperty.Register("TextBoxForegroundBrush", typeof(System.Windows.Media.Brush), typeof(NumericUpDown), new System.Windows.FrameworkPropertyMetadata(OnTextBoxForegroundBrushChanged));
            /// <summary>
            /// TextBoxの前景のブラシ
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("TextBoxの前景のブラシ")]
            public System.Windows.Media.Brush TextBoxForegroundBrush
            {
                set
                {
                    SetValue(TextBoxForegroundBrushProperty, value);
                }
                get
                {
                    return ((System.Windows.Media.Brush)GetValue(TextBoxForegroundBrushProperty));
                }
            }
            /// <summary>
            /// 「TextBoxの前景のブラシ」が変更されたイベント
            /// </summary>
            /// <param name="obj"></param>
            /// <param name="e"></param>
            private static void OnTextBoxForegroundBrushChanged(
                System.Windows.DependencyObject obj,
                System.Windows.DependencyPropertyChangedEventArgs e
                )
            {
                try
                {
                    if (obj is NumericUpDown item)
                    {
                        item.NumberTextBox.Foreground = item.TextBoxForegroundBrush;
                    }
                }
                catch
                {
                }
            }
            /// <summary>
            /// 「TextBoxの枠線のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty TextBoxBorderBrushProperty = System.Windows.DependencyProperty.Register("TextBoxBorderBrush", typeof(System.Windows.Media.Brush), typeof(NumericUpDown));
            /// <summary>
            /// TextBoxの枠線のブラシ
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("TextBoxの枠線のブラシ")]
            public System.Windows.Media.Brush TextBoxBorderBrush
            {
                set
                {
                    SetValue(TextBoxBorderBrushProperty, value);
                }
                get
                {
                    return ((System.Windows.Media.Brush)GetValue(TextBoxBorderBrushProperty));
                }
            }
            /// <summary>
            /// 「アップダウンボタンの背景のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty UpDownButtonBackgroundBrushProperty = System.Windows.DependencyProperty.Register("UpDownButtonBackgroundBrush", typeof(System.Windows.Media.Brush), typeof(NumericUpDown));
            /// <summary>
            /// アップダウンボタンの背景のブラシ
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("アップダウンボタンの背景のブラシ")]
            public System.Windows.Media.Brush UpDownButtonBackgroundBrush
            {
                set
                {
                    SetValue(UpDownButtonBackgroundBrushProperty, value);
                }
                get
                {
                    return ((System.Windows.Media.Brush)GetValue(UpDownButtonBackgroundBrushProperty));
                }
            }
            /// <summary>
            /// 「アップダウンボタンの枠線のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty UpDownButtonBorderBrushProperty = System.Windows.DependencyProperty.Register("UpDownButtonBorderBrush", typeof(System.Windows.Media.Brush), typeof(NumericUpDown));
            /// <summary>
            /// アップダウンボタンの枠線のブラシ
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("アップダウンボタンの枠線のブラシ")]
            public System.Windows.Media.Brush UpDownButtonBorderBrush
            {
                set
                {
                    SetValue(UpDownButtonBorderBrushProperty, value);
                }
                get
                {
                    return ((System.Windows.Media.Brush)GetValue(UpDownButtonBorderBrushProperty));
                }
            }
            /// <summary>
            /// 「アップダウンボタンの矢印のブラシ」の依存プロパティ
            /// </summary>
            public static readonly System.Windows.DependencyProperty UpDownButtonArrowBrushProperty = System.Windows.DependencyProperty.Register("UpDownButtonArrowBrush", typeof(System.Windows.Media.Brush), typeof(NumericUpDown));
            /// <summary>
            /// アップダウンボタンの矢印のブラシ
            /// </summary>
            [System.ComponentModel.Category("NumericUpDown Value")]
            [System.ComponentModel.Description("アップダウンボタンの矢印のブラシ")]
            public System.Windows.Media.Brush UpDownButtonArrowBrush
            {
                set
                {
                    SetValue(UpDownButtonArrowBrushProperty, value);
                }
                get
                {
                    return ((System.Windows.Media.Brush)GetValue(UpDownButtonArrowBrushProperty));
                }
            }

            /// <summary>
            /// コンストラクタ
            /// </summary>
            public NumericUpDown()
            {
                InitializeComponent();

                System.Windows.Input.InputMethod.SetIsInputMethodSuspended(NumberTextBox, true);
                NumberTextBox.Text = IsUseDecimal ? string.Format("{0:f" + NumberOfDecimalPlaces + "}", Value) : Value.ToString();

                NumberTextBox.PreviewTextInput += NumberTextBox_PreviewTextInput;
                NumberTextBox.PreviewKeyDown += NumberTextBox_PreviewKeyDown;
                NumberTextBox.TextChanged += NumberTextBox_TextChanged;
                UpButton.Click += UpButton_Click;
                DownButton.Click += DownButton_Click;
            }

            /// <summary>
            /// 「数値」TextBoxの「PreviewTextInput」イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void NumberTextBox_PreviewTextInput(
                object sender,
                System.Windows.Input.TextCompositionEventArgs e
                )
            {
                try
                {
                    // 入力許可以外の文字が入力された
                    if (Regex.IsMatch(e.Text) == false)
                    {
                        e.Handled = true;
                    }
                    // 「-」が入力された
                    else if (e.Text == "-")
                    {
                        if (0 <= MinimumValue)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            Value = -Value;
                            e.Handled = true;
                        }
                    }
                    // 「.」が入力された
                    else if (e.Text == ".")
                    {
                        if ((IsUseDecimal == false) || NumberTextBox.Text.Contains(e.Text))
                        {
                            e.Handled = true;
                        }
                    }
                    // それ以外
                    else
                    {
                        int maxNumberOfDigits = string.Format($"{decimal.MaxValue}").Length;     // 最大桁数

                        if (maxNumberOfDigits < NumberTextBox.Text.Length)
                        {
                            e.Handled = true;
                        }
                        else
                        {
                            if (IsUseDecimal)
                            {
                                // 少数点以下の桁数を制限
                                bool checkDecimal = false;     // 小数点の確認
                                int count = 0;      // カウント

                                for (count = 0; count < NumberTextBox.Text.Length; count++)
                                {
                                    if (NumberTextBox.Text[count] == '.')
                                    {
                                        checkDecimal = true;
                                        break;
                                    }
                                }
                                if (checkDecimal && (count < NumberTextBox.SelectionStart) && (NumberTextBox.SelectionLength == 0))
                                {
                                    int numberOfDecimalPlaces = 0;       // 小数点以下の桁数

                                    for (; count < NumberTextBox.Text.Length; count++, numberOfDecimalPlaces++)
                                    {
                                    }
                                    if (NumberOfDecimalPlaces < numberOfDecimalPlaces)
                                    {
                                        e.Handled = true;
                                    }
                                }
                            }
                        }
                    }
                }
                catch
                {
                }
            }

            /// <summary>
            /// 「数値」TextBoxの「PreviewKeyDown」イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void NumberTextBox_PreviewKeyDown(
                object sender,
                System.Windows.Input.KeyEventArgs e
                )
            {
                try
                {
                    switch (e.Key)
                    {
                        // 「上」キー
                        case System.Windows.Input.Key.Up:
                            ValuePlus();
                            break;
                        // 「下」キー
                        case System.Windows.Input.Key.Down:
                            ValueMinus();
                            break;
                        // 「Space」キー
                        case System.Windows.Input.Key.Space:
                            e.Handled = true;       // 「Space」キーを無効にするために必要
                            break;
                    }
                }
                catch
                {
                }
            }

            /// <summary>
            /// 「数値」TextBoxの「TextChanged」イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void NumberTextBox_TextChanged(
                object sender,
                System.Windows.Controls.TextChangedEventArgs e
                )
            {
                try
                {
                    if (string.IsNullOrEmpty(NumberTextBox.Text))
                    {
                        if ((MinimumValue <= 0) && (0 < MaximumValue))
                        {
                            Value = 0;
                        }
                        else
                        {
                            Value = MinimumValue;
                        }
                    }
                    else
                    {
                        decimal textBoxValue = decimal.Parse(NumberTextBox.Text);    // テキストボックスの値
                        int cursorPosition = NumberTextBox.SelectionStart;    // カーソル位置

                        if (textBoxValue < MinimumValue)
                        {
                            Value = MinimumValue;
                            NumberTextBox.SelectionStart = cursorPosition;
                        }
                        else if (MaximumValue < textBoxValue)
                        {
                            Value = MaximumValue;
                            NumberTextBox.SelectionStart = cursorPosition;
                        }
                        else
                        {
                            PrivateValue = textBoxValue;
                        }
                    }

                    DoChangeValue();
                }
                catch
                {
                }
            }

            /// <summary>
            /// 「アップ」Buttonの「Click」イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void UpButton_Click(
                object sender,
                System.Windows.RoutedEventArgs e
                )
            {
                try
                {
                    ValuePlus();
                }
                catch
                {
                }
            }

            /// <summary>
            /// 「ダウン」Buttonの「Click」イベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void DownButton_Click(
                object sender,
                System.Windows.RoutedEventArgs e
                )
            {
                try
                {
                    ValueMinus();
                }
                catch
                {
                }
            }

            /// <summary>
            /// 少数の位置にカーソルがあるか確認
            /// </summary>
            /// <returns>カーソルが少数の位置にあるかの値 (いいえ「false」/はい「true」)</returns>
            private bool CheckIfTheCursorIsInASmallNumberOfPosition()
            {
                bool checkCursorPositionDecimal = false;     // カーソルが少数の位置にあるかの値

                if (IsUseDecimal)
                {
                    for (int count = 0; count < NumberTextBox.Text.Length; count++)
                    {
                        if (NumberTextBox.Text[count] == '.')
                        {
                            if (count < NumberTextBox.SelectionStart)
                            {
                                checkCursorPositionDecimal = true;
                            }
                            break;
                        }
                    }
                }

                return (checkCursorPositionDecimal);
            }

            /// <summary>
            /// 整数の桁数を取得
            /// </summary>
            /// <returns>整数の桁数</returns>
            private int GetTheNumberOfDigitsInAnInteger()
            {
                int count;      // カウント

                for (count = 0; count < NumberTextBox.Text.Length; count++)
                {
                    if (NumberTextBox.Text[count] == '.')
                    {
                        break;
                    }
                }

                return (count);
            }

            /// <summary>
            /// 値を足す
            /// </summary>
            private void ValuePlus()
            {
                if (Value < MaximumValue)
                {
                    bool checkCursorPositionDecimal = CheckIfTheCursorIsInASmallNumberOfPosition();      // カーソルが少数の位置にあるかの値

                    Value += checkCursorPositionDecimal ? DecimalIncrementDecrement : IntegerIncrementDecrement;
                    if (IsUseDecimal)
                    {
                        NumberTextBox.SelectionStart = checkCursorPositionDecimal ? (GetTheNumberOfDigitsInAnInteger() + 1) : 0;
                    }
                }
            }

            /// <summary>
            /// 値を引く
            /// </summary>
            private void ValueMinus()
            {
                if (MinimumValue < Value)
                {
                    bool checkCursorPositionDecimal = CheckIfTheCursorIsInASmallNumberOfPosition();      // カーソルが少数の位置にあるかの値

                    Value -= checkCursorPositionDecimal ? DecimalIncrementDecrement : IntegerIncrementDecrement;
                    if (IsUseDecimal)
                    {
                        NumberTextBox.SelectionStart = checkCursorPositionDecimal ? (GetTheNumberOfDigitsInAnInteger() + 1) : 0;
                    }
                }
            }
        }
    }
}
