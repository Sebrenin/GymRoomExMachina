using System;
using System.Collections.Generic;

namespace GymRoomExMachina_Data.Models;

public partial class Routine
{
    public int IdRoutine { get; set; }

    public string NameRoutine { get; set; } = null!;

    public string? DescriptionRoutine { get; set; }

    public virtual ICollection<Member> Members { get; set; } = new List<Member>();
}
