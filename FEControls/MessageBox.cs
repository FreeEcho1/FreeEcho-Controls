namespace FreeEcho.FEControls;

/// <summary>
/// MessageBox
/// </summary>
public static class MessageBox
{
    /// <summary>
    /// 表示
    /// </summary>
    /// <returns></returns>
    public static MessageBoxResult Show()
    {
        MessageBoxWindow messageBox = new();
        messageBox.ShowDialog();
        return (messageBox.Result);
    }

    /// <summary>
    /// 表示
    /// </summary>
    /// <param name="title">タイトル</param>
    /// <param name="message">メッセージ</param>
    /// <param name="button">表示するボタン</param>
    /// <param name="parentWindow">親ウィンドウ</param>
    /// <returns>押されたボタン</returns>
    public static MessageBoxResult Show(
        string title,
        string message,
        MessageBoxButton button = MessageBoxButton.None,
        System.Windows.Window parentWindow = null
        )
    {
        MessageBoxWindow messageBox = new(title, message, button, parentWindow);
        messageBox.ShowDialog();
        return (messageBox.Result);
    }
}
