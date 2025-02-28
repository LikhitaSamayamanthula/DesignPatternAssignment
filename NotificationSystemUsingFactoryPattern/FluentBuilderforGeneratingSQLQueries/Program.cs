namespace FluentBuilderforGeneratingSQLQueries
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var queryBuilder = new SqlQueryBuilder();

            SqlQuery query = queryBuilder
                .Select("Id", "Name", "Age")
                .From("Users")
                .Where("Age > 18")
                .Build();

            Console.WriteLine("Generated SQL Query:");
            Console.WriteLine(query);
        }
    }
}
