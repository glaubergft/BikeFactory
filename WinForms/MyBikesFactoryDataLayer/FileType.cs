using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBikesFactoryDataLayer
{
    public enum FileType
    {
        [Description("Text File Type")]
        txt,

        [Description("eXtensible Markup Language File Type")]
        xml,

        [Description("Binary File Type")]
        bin
    }
}
