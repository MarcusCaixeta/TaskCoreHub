﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskCoreHub.Core.Entitites
{
    public class Team : BaseEntity
    {
        public Team(string title, string description)
        {
            Title = title;
            Description = description;
        }
        public Team() { }

        public string Title { get; private set; }
        public string Description { get; private set; }
    }
}
