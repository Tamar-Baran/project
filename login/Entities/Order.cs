﻿using System;
using System.Collections.Generic;

namespace Entities;

public partial class Order
{
    public int OrderId { get; set; }

    public DateTime OrderDate { get; set; }

    public int OrderSum { get; set; }

    public int UserId { get; set; }
}
