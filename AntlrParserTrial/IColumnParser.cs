using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AntlrParserTrial
{
    public interface IColumnParser
    {
        public abstract IEnumerable<string> GetUsedColumns();
    }
}
