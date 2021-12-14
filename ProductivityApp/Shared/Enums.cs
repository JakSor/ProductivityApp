using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class TaskEnums
    {
        public enum TaskTypes
        {
            Do = 0,
            Schedule = 1,
            Delegate = 2,
            Eliminate = 3
        }

        public enum TaskStates
        {
            New = 0,
            Planned=1,
            InProgress =2,
            Completed =3,
            Canceled =4,
            Eliminated=5
        }
    }
}