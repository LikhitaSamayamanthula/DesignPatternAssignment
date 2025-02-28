using System;
using System.Collections.Generic;
using System.Text;
using FluentBuilderforGeneratingSQLQueries;

public class SqlQueryBuilder : ISqlQueryBuilder
{
    private string _table;
    private List<string> _columns = new();
    private List<string> _conditions = new();

    public ISqlQueryBuilder Select(params string[] columns)
    {
        _columns.AddRange(columns);
        return this;
    }

    public ISqlQueryBuilder From(string table)
    {
        _table = table;
        return this;
    }

    public ISqlQueryBuilder Where(string condition)
    {
        _conditions.Add(condition);
        return this;
    }

    public SqlQuery Build()
    {
        if (string.IsNullOrEmpty(_table))
            throw new InvalidOperationException("Table name is required.");

        StringBuilder query = new();
        query.Append("SELECT ");
        query.Append(_columns.Count > 0 ? string.Join(", ", _columns) : "*");
        query.Append($" FROM {_table}");

        if (_conditions.Count > 0)
        {
            query.Append(" WHERE ");
            query.Append(string.Join(" AND ", _conditions));
        }

        return new SqlQuery { QueryText = query.ToString() };
    }
}
