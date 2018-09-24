using System.Windows.Forms;

namespace EEGPatternizer
{
    class GPanel : Panel
    {
        public GPanel()
        {
            this.DoubleBuffered = true;
            this.ResizeRedraw = true;
        }
    }
}
