using Dapper;
using Kiosko.Domain.Entities;
using System.Data;

namespace Kiosko.Infrastructure
{
    public class CompanyActivityRepository
    {
        private readonly DapperContext _context;
        public CompanyActivityRepository(DapperContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<CompanyActivity>> GetById(int id) {

            string sql = "SELECT  * FROM Clientes";
            using var connection = _context.CreateConnection();
            var users = await connection.QueryAsync<CompanyActivity>(sql);
            return users.ToList();

        }


        public async Task<CompanyActivity> GetByName(string name) {
            string sqlQuery = "SELECT * FROM Users WHERE Name = @Name";
            using var connection = _context.CreateConnection();
            return await connection.QuerySingleAsync<CompanyActivity>(sqlQuery, new { Name = name });

        }


        public async Task Update(CompanyActivity request, int id) {
            string sqlQuery = "UPDATE [cccol].[company_activity] SET [ActivityName] = @ActivityName, [ActivyDescription] = @ActivyDescription, [CreateDate] = @CreateDate, [UpdateDate] = @UpdateDate, [CreateUser] = @CreateUser [UpdateUser] = @UpdateUser WHERE Id = @Id";
            var parameters = new DynamicParameters();
      //      parameters.Add("Title", updateTodoDTO.Title, DbType.String);


            parameters.Add("Id", id, DbType.Int32);
            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(sqlQuery, parameters);

        }


        public async Task Delete(int id) {
            string query = "DELETE FROM Todos WHERE Id = @Id";

            using var connection = _context.CreateConnection();
            await connection.ExecuteAsync(query, new { Id = id });
        }

        public async Task Insert(CompanyActivity request, Guid userId) {

            string sqlQuery = "INSERT into Todos (UserId, Title, Description, Id, Status) values (@UserId, @Title, @Description, @Id, @Status)";
            var parameters = new DynamicParameters();
      //      parameters.Add("Title", createTodoDTO.Title, DbType.String);


            parameters.Add("Id", Guid.NewGuid(), DbType.Guid);

            using var connection = _context.CreateConnection();
            var r = await connection.ExecuteAsync(sqlQuery, parameters);
            Console.Write(r);

        }


    }
}
