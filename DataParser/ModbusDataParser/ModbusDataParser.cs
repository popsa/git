using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rlt
{
    public class ModbusDataParser : IDataParser
    {
        public bool Parse(byte[] bytes, out List<List<string>> parsedStrings)
        {
            throw new NotImplementedException();
        }
    }
}
