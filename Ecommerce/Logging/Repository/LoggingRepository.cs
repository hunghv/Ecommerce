using System;
using System.Data;
using Dapper;
using E.Shared.Utils;
using Logging.Entities;
using Microsoft.Extensions.Configuration;

namespace Logging.Repository
{
    public class LoggingRepository: ILoggingRepository
    {
        private readonly IConfiguration _config;
        public LoggingRepository(IConfiguration config)
        {
            _config = config;
        }
        public void LogException(string message, Exception ex, LogMessageType type)
        {
            using (IDbConnection con = Connection.GetConnection(Connection.DatabaseName.Logging, _config))
            {
                if (con.State == ConnectionState.Closed)
                    con.Open();
                string sqlQuery =
                    "INSERT INTO Logs(Message,MessageType,Exception,MachineName, Ip, CreatedDate, CreatedBy)" +
                    "VALUES(@Message, @MessageType, @Exception, @MachineName, @Ip, @CreatedDate, @CreatedBy)";
                DynamicParameters parameters = new DynamicParameters();
                parameters.Add("@Message", message);
                parameters.Add("@MessageType", type);
                parameters.Add("@Exception", ex.ToString());
                parameters.Add("@MachineName", Environment.MachineName);
                parameters.Add("@Ip", Environment.MachineName);
                parameters.Add("@CreatedDate", DateTime.Now);
                parameters.Add("@CreatedBy", 1);

                con.Execute(sqlQuery, parameters, commandType: CommandType.Text);
            }
        }
    }
}
