using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Abstract
{
    internal interface IMemberCheckService 
    {
        bool MemberCheckIfReal(Member member);
    }
}
