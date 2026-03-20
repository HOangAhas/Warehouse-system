using System;
using System.Collections.Generic;

namespace MyApp.Models;

public partial class LkpZoneType
{
    public byte TypeId { get; set; }

    public string TypeCode { get; set; } = null!;

    public string TypeName { get; set; } = null!;

    public virtual ICollection<WarehouseZone> WarehouseZones { get; set; } = new List<WarehouseZone>();
}
