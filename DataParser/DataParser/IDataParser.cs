using System;
using System.Collections.Generic;

namespace rlt
{        
    public interface IDataParser
    {
        Boolean Parse(Byte[] bytes, out List<List<String>> parsedStrings);
    }
}
