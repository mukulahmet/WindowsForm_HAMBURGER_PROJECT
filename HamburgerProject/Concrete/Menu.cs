using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HamburgerProject.Abstract;

namespace HamburgerProject.Concrete
{
    public class Menu:Urun
    {
        public override string ToString()
        {
            return this.Ad + " Menu";
        }
    }
}
