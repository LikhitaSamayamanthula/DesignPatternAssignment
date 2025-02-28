using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentBuilderforGeneratingSQLQueries
{
    public interface ISqlQueryBuilder
    {
        ISqlQueryBuilder Select(params string[] columns);
        ISqlQueryBuilder From(string table);
        ISqlQueryBuilder Where(string condition);
        SqlQuery Build();
    }

}
