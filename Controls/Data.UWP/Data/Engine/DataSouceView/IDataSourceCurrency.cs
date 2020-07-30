using System;

namespace Telerik.Data.Core
{
    public interface IDataSourceCurrency
    {
        event EventHandler<object> CurrentChanged;
        void ChangeCurrentItem(object item);
    }
}
