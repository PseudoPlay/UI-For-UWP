using System;
using System.Linq;

namespace Telerik.Data.Core
{
    public class PlaceholderInfo
    {
        public PlaceholderInfo(PlaceholderInfoType type)
        {
            this.Type = type;
        }

        public PlaceholderInfoType Type { get; private set; }
    }
}