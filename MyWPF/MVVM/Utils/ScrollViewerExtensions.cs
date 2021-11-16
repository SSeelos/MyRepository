using System.Windows.Controls;
using System.Windows.Input;

namespace MyWPF.MVVM.Utils
{
    public static class ScrollViewerExt
    {
        public static void EnableMouseWheelScroll(this ScrollViewer scrollViewer, MouseWheelEventArgs e)
        {
            scrollViewer.VerticalScrollBarVisibility = ScrollBarVisibility.Visible;

            if (e.Delta > 0)
            {
                scrollViewer.LineUp();
            }
            else
            {
                scrollViewer.LineDown();
            }
            e.Handled = true;
        }
    }
}
