using System;
using System.Collections.Generic;

namespace Task_Management_API.Models;

public partial class TaskStatusHistory
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string OldStatus { get; set; } = null!;

    public string NewStatus { get; set; } = null!;

    public int ChangedBy { get; set; }

    public DateTime? ChangedAt { get; set; }

    public virtual User ChangedByNavigation { get; set; } = null!;

    public virtual Task Task { get; set; } = null!;
}
