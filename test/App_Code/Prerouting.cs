using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using test.Models;

namespace test.App_Code
{
    public class Prerouting
    {
        public PackageModel Route(HTTP.METHOD method, PackageModel package)
        {
            PackageModel _package = new PackageModel();

            package.Method = method;

            return package;
        }
    }
}