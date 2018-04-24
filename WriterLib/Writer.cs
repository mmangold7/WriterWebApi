using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriterLib
{
    //base writer class
    public class Writer
    {
        public string message = "Hello World!";

        public virtual void write()
        {
            //outputs to output window in visual studio
            System.Diagnostics.Debug.WriteLine(message);
        }
    }

    //inherits hello world message and must override write method
    public class DbWriter : Writer
    {
        public override void write()
        {
            //retrieve a db context
            //add new message entity to context
            //save context
        }
    }

    public class ProcessWriter : Writer
    {
        public override void write()
        {
            //define a filename of an executable process
            //use System.Diagnostics.Process.Start with message as param
        }
    }
}
