using System;
using System.Collections.Generic;

namespace GymRoomExMachina_Data.Models;

public partial class Member
{
    public int IdMember { get; set; }

    public string NameMember { get; set; } = null!;

    public bool Active { get; set; }

    public decimal? Weight { get; set; }

    public decimal? Height { get; set; }

    public string LogInMember { get; set; } = null!;

    public string PasswordMember { get; set; } = null!;

    public DateTime SignUpDate { get; set; }

    public int? IdRoutine { get; set; }

    public int? IdCoach { get; set; }

    public string? Goal { get; set; }

    public string? BodyType { get; set; }

    public int? Age { get; set; }

    public decimal? FatPct { get; set; }

    public decimal? FatKg { get; set; }

    public decimal? MuscleKg { get; set; }

    public decimal? Tricep { get; set; }

    public decimal? Subscapular { get; set; }

    public decimal? Bicep { get; set; }

    public decimal? Iliocrestal { get; set; }

    public decimal? Waist { get; set; }

    public virtual Coach? IdCoachNavigation { get; set; }

    public virtual Routine? IdRoutineNavigation { get; set; }
}
