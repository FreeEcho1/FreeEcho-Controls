namespace FreeEcho
{
    namespace FEControls
    {
        /// <summary>
        /// Check ListBox
        /// </summary>
        public partial class CheckListBox : System.Windows.Controls.ListBox
        {
            /// <summary>
            /// チェック状態変更のイベント
            /// </summary>
            public event System.EventHandler<CheckListBoxItemEventArgs> CheckStateChanged;
            /// <summary>
            /// チェック状態が変更されたイベントを実行
            /// </summary>
            public virtual void DoCheckStateChanged(
                CheckListBoxItem item
                )
            {
                CheckStateChanged?.Invoke(this, new CheckListBoxItemEventArgs(item));
            }

            /// <summary>
            /// 「Selector」の項目が変更されたときに選択されている項目を更新
            /// </summary>
            /// <param name="e"></param>
            protected override void OnItemsChanged(
                System.Collections.Specialized.NotifyCollectionChangedEventArgs e
                )
            {
                try
                {
                    base.OnItemsChanged(e);

                    switch (e.Action)
                    {
                        case System.Collections.Specialized.NotifyCollectionChangedAction.Add:
                            {
                                foreach (CheckListBoxItem nowItem in e.NewItems)
                                {
                                    nowItem.CheckStateChanged += CheckListBox_CheckStateChanged;
                                }
                            }
                            break;
                        case System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
                            {
                                foreach (CheckListBoxItem nowItem in e.OldItems)
                                {
                                    nowItem.CheckStateChanged -= CheckListBox_CheckStateChanged;
                                }
                            }
                            break;
                    }
                }
                catch
                {
                }
            }

            /// <summary>
            /// 項目のチェック状態が変更された時のイベント
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            private void CheckListBox_CheckStateChanged(
                object sender,
                CheckListBoxItemEventArgs e
                )
            {
                try
                {
                    DoCheckStateChanged(e.Item);
                }
                catch
                {
                }
            }
        }
    }
}
