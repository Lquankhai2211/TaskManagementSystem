using System;
using System.Collections.Generic;

namespace Task_Management_API.Models;

public partial class Attachment
{
    public int Id { get; set; }

    public int TaskId { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public DateTime? UploadedAt { get; set; }

    public virtual Task Task { get; set; } = null!;
}
