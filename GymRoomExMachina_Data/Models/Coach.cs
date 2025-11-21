using System;
using System.Collections.Generic;

namespace GymRoomExMachina_Data.Models;

public partial class Coach
{
    public int IdCoach { get; set; }

    public string NameCoach { get; set; } = null!;

    public bool Active { get; set; }

    public string LogInCoach { get; set; } = null!;

    public string PasswordCoach { get; set; } = null!;

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
