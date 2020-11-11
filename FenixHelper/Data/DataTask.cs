using System;
using System.Collections;
using System.Text;
using System.Data.SQLite;

namespace FenixHelper.Data
{
    class DataTask
    {
        public int Add(Task task)
        {
            int task_id = 0;

            Connection conn = new Connection();
            conn.open();

            try
            {
                int key_id = task.Key_id;
                string name = task.Name;
                string working_directory = task.Working_directory;
                string filename = task.Filename;
                int window_style = task.Window_style;
                int terminate = task.Terminate;
                int admin = task.Admin;

                var query = new SQLiteCommand("INSERT INTO tasks(key_id,name,working_directory,filename,window_style,terminate,admin) VALUES (@p0,@p1,@p2,@p3,@p4,@p5,@p6); SELECT last_insert_rowid();", conn.connection);

                query.Parameters.AddWithValue("@p0", key_id);
                query.Parameters.AddWithValue("@p1", name);
                query.Parameters.AddWithValue("@p2", working_directory);
                query.Parameters.AddWithValue("@p3", filename);
                query.Parameters.AddWithValue("@p4", window_style);
                query.Parameters.AddWithValue("@p5", terminate);
                query.Parameters.AddWithValue("@p6", admin);

                task_id = Convert.ToInt32(query.ExecuteScalar());
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conn.close();

            return task_id;
        }

        public Boolean Update(Task task)
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                int id = task.Id;
                int key_id = task.Key_id;
                string name = task.Name;
                string working_directory = task.Working_directory;
                string filename = task.Filename;
                int window_style = task.Window_style;
                int terminate = task.Terminate;
                int admin = task.Admin;

                var query = new SQLiteCommand("UPDATE tasks SET key_id = @p0, name = @p1, working_directory = @p2, filename = @p3, window_style = @p4, terminate = @p5, admin = @p6 WHERE id = @p7", conn.connection);

                query.Parameters.AddWithValue("@p0", key_id);
                query.Parameters.AddWithValue("@p1", name);
                query.Parameters.AddWithValue("@p2", working_directory);
                query.Parameters.AddWithValue("@p3", filename);
                query.Parameters.AddWithValue("@p4", window_style);
                query.Parameters.AddWithValue("@p5", terminate);
                query.Parameters.AddWithValue("@p6", admin);
                query.Parameters.AddWithValue("@p7", id);

                query.ExecuteNonQuery();

                response = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conn.close();

            return response;
        }

        public Boolean Delete(int id)
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                var query = new SQLiteCommand("DELETE FROM tasks WHERE id = @p0", conn.connection);

                query.Parameters.AddWithValue("@p0", id);

                query.ExecuteNonQuery();

                response = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }

            conn.close();

            return response;
        }

        public ArrayList List()
        {
            ArrayList tasks = new ArrayList();
            Connection conn = new Connection();
            conn.open();
            conn.command.CommandText = "SELECT id,key_id,name,working_directory,filename,window_style,terminate,admin FROM tasks";
            var reader = conn.command.ExecuteReader();
            while (reader.Read())
            {
                Task task = new Task();
                if (!reader.IsDBNull(0))
                {
                    task.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    task.Key_id = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    task.Name = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    task.Working_directory = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    task.Filename = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    task.Window_style = reader.GetInt32(5);
                }
                if (!reader.IsDBNull(6))
                {
                    task.Terminate = reader.GetInt32(6);
                }
                if (!reader.IsDBNull(7))
                {
                    task.Admin = reader.GetInt32(7);
                }
                tasks.Add(task);
            }
            reader.Close();
            conn.close();
            return tasks;
        }

        public Task Get(int id)
        {
            Task task = new Task();
            Connection conn = new Connection();
            conn.open();
            var query = new SQLiteCommand("SELECT id,key_id,name,working_directory,filename,window_style,terminate,admin FROM tasks WHERE id = @p0", conn.connection);
            query.Parameters.AddWithValue("@p0", id);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    task.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    task.Key_id = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    task.Name = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    task.Working_directory = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    task.Filename = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    task.Window_style = reader.GetInt32(5);
                }
                if (!reader.IsDBNull(6))
                {
                    task.Terminate = reader.GetInt32(6);
                }
                if (!reader.IsDBNull(7))
                {
                    task.Admin = reader.GetInt32(7);
                }
            }
            reader.Close();
            conn.close();
            return task;
        }

        public Task GetByKeyId(int key_id)
        {
            Task task = null;
            Connection conn = new Connection();
            conn.open();
            var query = new SQLiteCommand("SELECT t.id,t.key_id,t.name,t.working_directory,t.filename,t.window_style,t.terminate,t.admin FROM tasks t, keys k WHERE t.key_id = k.id AND k.id = @p0", conn.connection);
            query.Parameters.AddWithValue("@p0", key_id);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                task = new Task();
                if (!reader.IsDBNull(0))
                {
                    task.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    task.Key_id = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    task.Name = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    task.Working_directory = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    task.Filename = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    task.Window_style = reader.GetInt32(5);
                }
                if (!reader.IsDBNull(6))
                {
                    task.Terminate = reader.GetInt32(6);
                }
                if (!reader.IsDBNull(7))
                {
                    task.Admin = reader.GetInt32(7);
                }
            }
            reader.Close();
            conn.close();
            return task;
        }

        public Task GetByKey(string key)
        {
            Task task = null;
            Connection conn = new Connection();
            conn.open();
            var query = new SQLiteCommand("SELECT t.id,t.key_id,t.name,t.working_directory,t.filename,t.window_style,t.terminate,t.admin FROM tasks t, keys k WHERE t.key_id = k.id AND k.name = @p0", conn.connection);
            query.Parameters.AddWithValue("@p0", key);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                task = new Task();
                if (!reader.IsDBNull(0))
                {
                    task.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    task.Key_id = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    task.Name = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    task.Working_directory = reader.GetString(3);
                }
                if (!reader.IsDBNull(4))
                {
                    task.Filename = reader.GetString(4);
                }
                if (!reader.IsDBNull(5))
                {
                    task.Window_style = reader.GetInt32(5);
                }
                if (!reader.IsDBNull(6))
                {
                    task.Terminate = reader.GetInt32(6);
                }
                if (!reader.IsDBNull(7))
                {
                    task.Admin = reader.GetInt32(7);
                }
            }
            reader.Close();
            conn.close();
            return task;
        }
    }
}
