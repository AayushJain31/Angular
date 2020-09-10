using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using MVCTraining1.Controllers;
using PatientLibrary;
using Microsoft.Extensions.Configuration;
using HospitalRepository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using AutoMapper;

namespace UnitTestingExample
{
    [TestClass]
    public class UnitTestExample
    {
        public static IConfiguration InitConfiguration()
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            return config;
        }
        public static HospitalDbContext CreateDbContext()
        {
            var config = InitConfiguration();
            var connectionString = config.GetConnectionString("DefaultConnection");

            var optionsBuilder = new DbContextOptionsBuilder<HospitalDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            var hosdbcontext = new HospitalDbContext(optionsBuilder.Options);
            return hosdbcontext;
        }
       
        [TestMethod]
        public void TestCustomerAdd()
        {
            Customer x = new Customer();
            Mock<IDataLayer> mockdatalayer = new Mock<IDataLayer>();

            mockdatalayer.Setup(x => x.Add()).Callback(() =>
            {
                // Do not do anything
                var x = 100;
            });
            //mockdatalayer.Setup(x => x.Add(It.IsAny<string>()))
            //    .Returns(true);
            x.db = mockdatalayer.Object;
            x.name = "Aayush";
           
            var isadded = x.Add();
            
            Assert.AreEqual(true, isadded); 
        }

        [TestMethod]
        public void TestAPIPost()
        {
            Mock<HttpContext> httpmock = new Mock<HttpContext>();
            Mock<ISession> sessionmock = new Mock<ISession>();
            Mock<IMapper> mappermock = new Mock<IMapper>();
            sessionmock.Setup(x => x.Set(It.IsAny<string>(), It.IsAny<byte[]>()))
                            .Callback<string, byte[]>((s, b) =>
                            {
                                // do nothing
                                var x = 0;
                            }
                            );
            httpmock.Setup(s => s.Session).
                Returns(sessionmock.Object);

            //mappermock.Setup(m => m.Map<PatientDTO, Patient>(It.IsAny<Patient>())).Returns(new PatientDTO());
            //mappermock.Setup(m => m.Map<Patient, PatientDTO>(It.IsAny<Patient>())).Returns(new PatientDTO());

            List<PatientDTO> pdtos = new List<PatientDTO>();
            pdtos.Add(new PatientDTO() { name = "Aayush Jain", address = "Mumbai", email = "shiv@yahoo.com" , number = "9876543210" });
            //pdtos.Add(new PatientDTO() { name = "", address = "Mumbai1", email = "shiv@yahoo.com" , number = "9876543210" });
            //pdtos.Add(new PatientDTO() { name = "ddd", address = "Mumbai1", email = "shiv1yahoo.com" , number = "9876543210" });

            var mockMapper = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapping());
            });
            var mapper = mockMapper.CreateMapper();

            PatientAPIController pobjApi = new PatientAPIController(
                CreateDbContext() , mapper
                );

           

            pobjApi.ControllerContext.HttpContext = httpmock.Object;
            var ar = pobjApi.Post(pdtos);
            var or = ar as OkObjectResult;
            Assert.AreEqual(200, or.StatusCode);
            Assert.AreNotEqual(0, ((List<Patient>)or.Value).Count);

        }
    }

    public class Customer
    {
        public string name { get; set; }
        public IDataLayer db = new DataLayer();
        public bool Add()
        {

            if (name.Length == 0)
            {
                return false;
            }
            //if (db.Add(""))
            //{
            //    name = "Welcome " + name; // code will never
            //}
            db.Add();
            return true;
        }

    }
    public interface IDataLayer
    {
        //bool Add(string connection);
        void Add();
    }
    public class DataLayer : IDataLayer
    {
        //public bool Add(string connection)
        //{
        //    throw new Exception("Sql Server is not running");

        //    // Data acces
        //}
        public void Add()
        {
            throw new Exception("Name Exception!");
        }
    }

}
