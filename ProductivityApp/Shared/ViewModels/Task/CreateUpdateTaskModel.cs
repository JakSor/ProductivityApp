﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Common.TaskEnums;

namespace Common.ViewModels.Task
{
    public class CreateUpdateTaskModel
    {
        public string Title { get; set; }
        public DateTime DueDate { get; set; }
        public int TaskState { get; set; } =0;
        public string Description { get; set; }
        public int TaskTypes { get; set; }

    }
}
