﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MalignantTumorSystem.Model.Entities
{
    public partial class Chronic_disease_Comm_Testing_Urine_Add
    {
        public string id { get; set; }
        public string urine_id { get; set; }
        public string name { get; set; }
        public string result { get; set; }
        public string unit { get; set; }
        public string qujian { get; set; }
        public string tishi { get; set; }
        public string beizhu { get; set; }
        public Nullable<System.DateTime> create_time { get; set; }
    }
}
