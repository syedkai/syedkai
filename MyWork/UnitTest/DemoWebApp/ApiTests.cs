using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoWebApp
{
    [TestClass]
    public class ApiTests
    {
        [TestMethod]
        public void GetTest()
        {
            var controller = new WeatherForecastController();
            var result = controller.GetHashCode();
            Assert.IsNotNull(result);


        }
    }

    
    }