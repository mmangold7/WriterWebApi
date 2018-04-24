using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Configuration;
using System.Web.Http;
using WriterLib;

namespace WebApi.Controllers
{
    public class WriteController : ApiController
    {
        //read configuration setting from Web.config to determine destination to write to
        public string writeMode;

        //instance of the "program logic" that fulfills business requirement
        public Writer writer;

        public WriteController()
        {
            //instantiates correct derived writer object
            var setting = WebConfigurationManager.AppSettings["writeDestination"];
            writeMode = setting;
            switch (writeMode)
            {
                case "output":
                    writer = new Writer();
                    break;
                case "db":
                    writer = new DbWriter();
                    break;
                case "process":
                    writer = new ProcessWriter();
                    break;
            }
        }

        //accessible api method available to any http capable program
        public string Get()
        {
            //executes business logic
            writer.write();
            //sends to remote api user (accessed via uri /api/write)
            return "Hello World!";
        }
    }
}
