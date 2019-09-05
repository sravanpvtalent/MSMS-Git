using MSMS.Areas.Admin.IRepository;
using MSMS.Areas.Admin.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MSMS.Areas.Admin.BussinessAccessLayer
{
    public class bal
    {
        IRepos Iobj;
        public bal(Repos Robj)
        {
            Iobj = Robj;
        }
    }
}