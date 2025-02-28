using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderforGeneratingSQLQueries
{
    public class SqlQuery
    {
        public string QueryText { get; set; }

        public override string ToString() => QueryText;
    }

}
