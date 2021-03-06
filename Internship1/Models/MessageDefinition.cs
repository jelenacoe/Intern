﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Internship1.Models
{
    public class MessageDefinition
    {
        public int Number { get; set; }
        public string Title { get; set; }
        public string ComponentType { get; set; }
        public string Class { get; set; }
        public string Level { get; set; }
        public string AckMode { get; set; }
        public string SystemReactionMode { get; set; }
        public DisplayTitle DisplayTitle { get; set; }
        public DisplayDetails DisplayDetails { get; set; }
        public Param Param1 { get; set; }
        public Param Param2 { get; set; }
        public Param Param3 { get; set; }

    }
}