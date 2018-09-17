﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace POC_WebApplication.ViewModel
{
    public class XMLModel
    {
        public string NodeName { get; set; }

        public List<Attribute> Attributes { get; set; }

        public int NodeId { get; set; }
        public int ParentId { get; set; }
        
        public string NodeValue { get; set; }

       
    }
    public class Attribute
    {
        public string Name { get; set; }
        public string Value { get; set; }
    }

}