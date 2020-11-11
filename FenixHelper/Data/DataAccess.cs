using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace FenixHelper.Data
{
    class DataAccess
    {
        public DataAccess()
        {
        }

        public Boolean createDB()
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                // Table keys

                string sql_drop_keys = "DROP TABLE IF EXISTS keys;";

                SQLiteCommand cmd_drop_keys = new SQLiteCommand(sql_drop_keys, conn.connection);
                cmd_drop_keys.ExecuteNonQuery();

                string sql_create_table_keys = "CREATE TABLE keys(id integer PRIMARY KEY autoincrement,name nvarchar(100), code integer);";

                SQLiteCommand cmd_create_keys = new SQLiteCommand(sql_create_table_keys, conn.connection);
                cmd_create_keys.ExecuteNonQuery();

                // Table tasks

                string sql_drop_tasks = "DROP TABLE IF EXISTS tasks;";

                SQLiteCommand cmd_drop_tasks = new SQLiteCommand(sql_drop_tasks, conn.connection);
                cmd_drop_tasks.ExecuteNonQuery();

                string sql_create_table_tasks = "CREATE TABLE tasks(id integer PRIMARY KEY autoincrement,key_id integer, name nvarchar(100), working_directory nvarchar(100), filename nvarchar(100), window_style integer, terminate integer, admin integer,constraint fk_tasks foreign key (key_id) references keys(id));";

                SQLiteCommand cmd_create_tasks = new SQLiteCommand(sql_create_table_tasks, conn.connection);
                cmd_create_tasks.ExecuteNonQuery();

                // Table arguments

                string sql_drop_arguments = "DROP TABLE IF EXISTS arguments;";

                SQLiteCommand cmd_drop_arguments = new SQLiteCommand(sql_drop_arguments, conn.connection);
                cmd_drop_arguments.ExecuteNonQuery();

                string sql_create_table_arguments = "CREATE TABLE arguments(id integer PRIMARY KEY autoincrement,task_id integer, name nvarchar(100), value nvarchar(100),constraint fk_arguments foreign key (task_id) references tasks(id));";

                SQLiteCommand cmd_create_arguments = new SQLiteCommand(sql_create_table_arguments, conn.connection);
                cmd_create_arguments.ExecuteNonQuery();

                // Add values

                DataKey dc = new DataKey();
                dc.Add(new Key { Name = "F2", Code = 113});
                dc.Add(new Key { Name = "F3", Code = 114 });
                dc.Add(new Key { Name = "F4", Code = 115 });
                dc.Add(new Key { Name = "F5", Code = 116 });
                dc.Add(new Key { Name = "F6", Code = 117 });
                dc.Add(new Key { Name = "F7", Code = 118 });
                dc.Add(new Key { Name = "F8", Code = 119 });
                dc.Add(new Key { Name = "F9", Code = 120 });
                dc.Add(new Key { Name = "F10", Code = 121 });
                dc.Add(new Key { Name = "F11", Code = 122 });
                dc.Add(new Key { Name = "F12", Code = 123 });

                response = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return response;
        }
    }
}
