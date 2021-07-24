using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using MSAYearbook.Data;
using MSAYearbook.Models;

namespace MSAYearbook.GraphQL.Students
{
    [ExtendObjectType(name: "Query")]
    public class StudentQueries
    {
        public IQueryable<Student> GetStudents([ScopedService] AppDbContext context)
        {
            return context.Students;
        }
    }
}