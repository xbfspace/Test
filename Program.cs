using Arch.Data.Test.Entity;
using Arch.Data.Test.OtherTest;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Arch.Data.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //BaseDao dao = BaseDaoFactory.CreateBaseDao("DalTest");
            //var result = dao.SelectDataTable("select 1");
            //Console.Read();

            var dao = DALFactory.PersonGenDao;
            var person = new PersonGen();
            //person.ID = 1;
            person.ContryId = 1;
            person.CityId = 1;
            person.Remark = "用户1";
            dao.InsertPersonGen(person);

            var person2 = new PersonGen();
           // person2.ID = 2;
            person2.ContryId = 2;
            person2.CityId = 2;
            person2.Remark = "用户2";
            dao.InsertPersonGen(person2);

            //var allUsers = dao.GetAll();

            var list = new List<int> { 1,2,3,4,5};
            list.RemoveAll(c => c == 1 || c == 2);
            Console.WriteLine("result:");
            foreach (var i in list) {
                Console.WriteLine($"{i}");
            }
            RightManagerInvoker.AddRight();

            Console.ReadLine();
        }
    }
}