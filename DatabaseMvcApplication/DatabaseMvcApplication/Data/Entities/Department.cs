using System;
using System.Collections.Generic;

namespace DatabaseMvcApplication.Data.Entities;

public partial class Department
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
}
