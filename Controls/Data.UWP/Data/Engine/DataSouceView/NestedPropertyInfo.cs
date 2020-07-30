using System.Collections.Generic;

namespace Telerik.Data.Core
{
    public class NestedPropertyInfo
    {
        public readonly HashSet<object> rootItems;
        public readonly string nestedPropertyPath;

        public NestedPropertyInfo(HashSet<object> rootItems, string nestedPropertyPath)
        {
            this.rootItems = rootItems;
            this.nestedPropertyPath = nestedPropertyPath;
        }
    }
}