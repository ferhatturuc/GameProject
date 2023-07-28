using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameProject.Entities;

namespace GameProject.Abstract
{
    internal interface ISaleService
    {
         void Sale(Gamer gamer, Campaign campaign, Sale sale);
    }
}
