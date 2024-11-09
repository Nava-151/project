using Microsoft.AspNetCore.Mvc;
using rentDresses.Controllers;
using rentDresses.Entities;
using rentDresses.services;
using Xunit.Sdk;

namespace TestController1
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //get
            //משתנה לבדיקה
            //
            DressService dress = new DressService();
            var res=dress.GetList();
            //

            Assert.Equal(1,res.Count());
        }
        [Fact]
        public void Test2()
        {
            //getById
            var t = -1;
            var res=new DressService().GetDressById(t);
            Assert.NotEqual(null,res);

        }
        [Fact]
        public void Test3()
        {

            int t = 2;
            Dress d = new Dress(1, 18, "red", Seazon.Winter, 18, "likra", new DateTime(2020, 10, 05));

            var result = new DressController().Put(t,d);
            Assert.IsType<NotFoundObjectResult>(result);
            //update
            //int id = 1;
            //var res = new DressService().Update(id, d);
            //Dress found = new DressService().GetDressById(id);
            //Assert.Equal(found.Color,d.Color);
            //Assert.Equal(found.Seazons,d.Seazons);
            //Assert.Equal(found.FabricType,d.FabricType);
            //Assert.Equal(found.Size,d.Size);
            //Assert.Equal(found.Amount,d.Amount);
            //Assert.Equal(found.YearOfManufacture,d.YearOfManufacture);

        }
        [Fact]
        public void Test4()
        {
            //post
            Dress d = new Dress(1, 18, "red", Seazon.Winter, 18, "likra", new DateTime(2020, 10, 05));
            var t=new DressService().Add(d);
            Assert.True(t);
          
        }
        [Fact]
        public void test5()
        {
            int id = 1;
            var result = new DressController().Delete(id);
            Assert.IsType<NotFoundResult>(result);
        }
    }
}