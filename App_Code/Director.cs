﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Linq.Mapping;

/// <summary>
/// Summary description for Director
/// </summary>
[Table]
public class director
{
    [Column(IsPrimaryKey = true, IsDbGenerated = true)]
    public int Id { get; set; }

    [Column]
    public string name { get; set; }
}