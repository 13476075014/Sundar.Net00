﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sundar.Repository.Domain;

namespace Sundar.BLL
{
    public class ModuleManagerBLL : BaseApp<Sys_Module>
    {
        public string Get(string account)
        {
            return Repository.FindSingle(u => u.Id == account).Id;
        }
    }
}
