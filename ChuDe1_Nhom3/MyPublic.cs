using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChuDe1_Nhom3 {
    class MyPublic {
        public static SqlConnection connection;
        public static string connectionString = "Server=localhost; Database=QL_BaiThi; User Id=TN207User; Password=TN207User";
        public static string tenTaiKhoan, quyenSD, maTT;

        public static void createConnection() {
            connection = new SqlConnection(connectionString);
        }

        public static void OpenData(string query, DataSet dataset, string tableName) {
            try {
                if (connection == null) {
                    createConnection();
                }

                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                adapter.Fill(dataset, tableName);

                connection.Close();
            } catch { }
        }

        public static void OpenData(string query, DataSet dataset, string tableName, SqlDataAdapter adapter) {
            try {
                if (connection == null) {
                    createConnection();
                }

                adapter.SelectCommand = new SqlCommand(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                adapter.Fill(dataset, tableName);

                connection.Close();
            } catch { }
        }

        public static bool tonTaiKhoaChinh(string field, string value, string tableName) {
            try {
                if (connection == null) {
                    createConnection();
                } else if (connection.State == ConnectionState.Closed) {
                    connection.Open();
                }

                var command = connection.CreateCommand();

                command.CommandText = "SELECT 1 FROM " + tableName + " WHERE " + field + " = '" + value + "'";

                var reader = command.ExecuteReader();
                bool tonTai = reader.HasRows;
                reader.Close();

                return tonTai;
            } catch {
                return false;
            }
        }
    }
}
