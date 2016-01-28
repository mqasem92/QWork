using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QWork.Core.Enum.Request
{
    public enum ProcessStatus
    {
        Draft,
        Started,
        Pending,
        Waiting,
        InProgress,
        Completed,
        CompletedWithError,
        Finished,
        FinishedWithError,
        Canceled,
        Aborted,
        Faild,
        FaildWithError,
        Unknown
    }
}
