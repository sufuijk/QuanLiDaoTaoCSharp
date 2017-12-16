using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLiDaoTao
{
    class Validate
    {
        private static Validate instance;
        public static Validate Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new Validate();
                }
                return instance;
            }
        }


    }
}
