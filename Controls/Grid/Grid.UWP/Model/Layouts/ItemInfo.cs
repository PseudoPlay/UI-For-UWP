﻿namespace Telerik.Data.Core.Layouts
{
    public struct ItemInfo
    {
        public object Item;
        public int Id;

        // Keeps the id/slot in the collection.
        public int Slot;
        public int Level;
        public GroupType ItemType;

        // Expand/Collapse state        
        public bool IsCollapsible;
        public bool IsCollapsed;
        public bool IsSummaryVisible;

        public bool IsDisplayed;

        // Layout properties
        public LayoutInfo LayoutInfo;

        public static readonly ItemInfo Invalid = new ItemInfo();
    }
}