﻿using System;
using System.Collections.Generic;

namespace EmployeeAPI.Models;

public partial class Employee
{
    public int Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public int? Age { get; set; }
}
