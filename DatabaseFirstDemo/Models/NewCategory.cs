using System;
using System.Collections.Generic;

namespace DatabaseFirstDemo.Models;

public partial class NewCategory
{
    public int Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public virtual ICollection<News> News { get; set; } = new List<News>();
}
