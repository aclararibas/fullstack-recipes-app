using Domain.Recepies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_2.Recepies
{
    class RecepieTest : Recepie
    {
        public DateTime TestDate { get; set; } = DateTime.Now;
    }
}
