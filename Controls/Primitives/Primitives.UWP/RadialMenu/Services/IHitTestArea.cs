using System;
using System.Linq;

namespace Telerik.UI.Xaml.Controls.Primitives.Menu
{
    public interface IHitTestArea
    {
        bool HitTestVisible { get; set; }

        RadialSegment HitTest(RadPolarPoint point);
    }
}
