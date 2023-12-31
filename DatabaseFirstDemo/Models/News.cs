﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using Microsoft.AspNetCore.Http;

namespace DatabaseFirstDemo.Models;

public partial class News
{
    public int Id { get; set; }

    public int CategoryId { get; set; }

    public string? Title { get; set; }

    public string? Description { get; set; }

    public string? SubjectContent { get; set; }

    [DisplayName("Ngày đăng")]
    public DateTime DateUpdate { get; set; }

    public bool Status { get; set; }

    [DisplayName("Ảnh đại diện")]
    public string Avatar { get; set; }

    public int UserId { get; set; }

    public virtual NewCategory Category { get; set; }

    public virtual User User { get; set; }

    [NotMapped]
    [DisplayName("Upload File")]
    public IFormFile ImageFile { get; set; }
}
