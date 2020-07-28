using System;
using Telerik.Core;

namespace Telerik.UI.Xaml.Controls.Grid
{
    public abstract class GridElement : Element, IGridNode
    {
        public object ContainerType
        {
            get;
            set;
        }

        public object Container
        {
            get;
            set;
        }

        public RadSize DesiredSize
        {
            get;
            set;
        }
    }
}
