using System;

namespace Telerik.Core.Data
{
    public class BatchLoadingEventArgs : EventArgs
    {
        public BatchLoadingEventArgs(BatchLoadingStatus status)
            : base()
        {
            this.Status = status;
        }

        public BatchLoadingStatus Status { get; private set; }
    }
}
