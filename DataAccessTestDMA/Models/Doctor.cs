using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace DataAccessTestDMA.Models;

public partial class Doctor
{
    public int DoctorId { get; set; }

    public string DoctorName { get; set; } = null!;

    public int? Age { get; set; }

    public string? Address { get; set; }

    public int? SpecialtyId { get; set; }
    [JsonIgnore]
    public virtual Specialty? Specialty { get; set; }
}
