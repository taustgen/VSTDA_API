﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using VSTDA.API.Models;

namespace VSTDA.API.Data
{
    public class VSTDADataContext : DbContext
    {
        //Constructer
        public VSTDADataContext() : base("VSTDA")
        {
                
        }
        //DbSets (Tables)
        public IDbSet<TodoItem> TodoItems { get; set; }
    }
}