using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace auto
{
    class date: DateTimePicker
    {

        public date()
        {
            this.MinDate = DateTime.Today; ;
          

        }
       
    }
}
