using Neo4j.Driver;
using System;
using System.Threading.Tasks;

namespace MyLibrary.MyNeo4j
{
    public class Neo4jProgram
    {

        public static async Task Main()
        {
            var driver = GraphDatabase.Driver("bolt://54.167.164.211:7687",
                            AuthTokens.Basic("neo4j", "prompts-churns-navies"));

            var cypherQuery =
              @"
      MATCH (dc:DataCenter {location: $location})-[:CONTAINS]->(r:Router)-[:ROUTES]->(i:Interface)
      RETURN i.ip as ip
      ";

            var session = driver.AsyncSession(o => o.WithDatabase("neo4j"));
            var result = await session.ReadTransactionAsync(async tx =>
            {
                var r = await tx.RunAsync(cypherQuery,
                        new { location = "Iceland" });
                return await r.ToListAsync();
            });

            await session?.CloseAsync();
            foreach (var row in result)
                Console.WriteLine(row["ip"].As<string>());

        }

    }
}
