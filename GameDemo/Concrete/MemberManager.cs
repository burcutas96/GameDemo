using GameDemo.Abstract;
using GameDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameDemo.Concrete
{
    internal class MemberManager : IMemberService
    {
        IMemberCheckService _memberCheckService;
        public MemberManager(IMemberCheckService memberCheckService)
        {
            _memberCheckService = memberCheckService;
        }

        public void Add(Member member)
        {
            if (_memberCheckService.MemberCheckIfReal(member))
            {
                Console.WriteLine(member.FirstName + " isimli yeni üye eklendi.");
            }
            else
            {
                throw new Exception("Gerçek bir kişi değilsin!");
            }
        }

        public void Delete(Member member)
        {
            if (_memberCheckService.MemberCheckIfReal(member))
            {
                Console.WriteLine(member.FirstName + " isimli üye silindi.");
            }
            else
            {
                throw new Exception("Gerçek bir kişi değilsin!");
            }
        }

        public void Update(Member member)
        {
            if (_memberCheckService.MemberCheckIfReal(member))
            {
                Console.WriteLine(member.FirstName + " isimli üye güncellendi.");
            }
            else
            {
                throw new Exception("Gerçek bir kişi değilsin!");
            }
        }
    }
}
