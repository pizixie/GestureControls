using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    public class GestureEventArgs : EventArgs
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public GestureId Gesture { get; private set; }


        public GestureEventArgs(int x, int y, GestureId gid)
        {
            this.X = x;
            this.Y = y;
            this.Gesture = gid;
        }
    }

    public enum GestureId
    {
        GID_BEGIN,
        GID_END,
        GID_ZOOM,
        GID_PAN,
        GID_ROTATE,
        GID_TWOFINGERTAP,
        GID_PRESSANDTAP
    }
}
