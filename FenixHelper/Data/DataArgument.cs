using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace FenixHelper.Data
{
    class DataArgument
    {
        public Boolean Add(Argument argument)
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                int task_id = argument.Task_id;
                string name = argument.Name;
                string value = argument.Value;

                var query = new SQLiteCommand("INSERT INTO arguments(task_id,name,value) VALUES (@p0,@p1,@p2)", conn.connection);

                query.Parameters.AddWithValue("@p0", task_id);
                query.Parameters.AddWithValue("@p1", name);
                query.Parameters.AddWithValue("@p2", value);

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

        public Boolean Update(Argument argument)
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                int id = argument.Id;
                int task_id = argument.Task_id;
                string name = argument.Name;
                string value = argument.Value;

                var query = new SQLiteCommand("UPDATE arguments SET task_id = @p0, name = @p1, value = @p2 WHERE id = @p3", conn.connection);

                query.Parameters.AddWithValue("@p0", task_id);
                query.Parameters.AddWithValue("@p1", name);
                query.Parameters.AddWithValue("@p2", value);
                query.Parameters.AddWithValue("@p3", id);

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
                var query = new SQLiteCommand("DELETE FROM arguments WHERE id = @p0", conn.connection);

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

        public Boolean DeleteByTask(int task_id)
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                var query = new SQLiteCommand("DELETE FROM arguments WHERE task_id = @p0", conn.connection);

                query.Parameters.AddWithValue("@p0", task_id);

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

        public ArrayList List(int task_id)
        {
            ArrayList arguments = new ArrayList();
            Connection conn = new Connection();
            conn.open();

            var query = new SQLiteCommand("SELECT a.id,a.task_id,a.name,a.value FROM arguments a, tasks t WHERE t.id = a.task_id AND a.task_id = @p0", conn.connection);
            query.Parameters.AddWithValue("@p0", task_id);

            var reader = query.ExecuteReader();

            while (reader.Read())
            {
                Argument argument = new Argument();
                if (!reader.IsDBNull(0))
                {
                    argument.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    argument.Task_id = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    argument.Name = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    argument.Value = reader.GetString(3);
                }
                arguments.Add(argument);
            }
            reader.Close();
            conn.close();
            return arguments;
        }

        public Argument Get(int id)
        {
            Argument argument = new Argument();
            Connection conn = new Connection();
            conn.open();
            var query = new SQLiteCommand("SELECT id,task_id,name,value FROM arguments WHERE id = @p0");
            query.Parameters.AddWithValue("@p0", id);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    argument.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    argument.Task_id = reader.GetInt32(1);
                }
                if (!reader.IsDBNull(2))
                {
                    argument.Name = reader.GetString(2);
                }
                if (!reader.IsDBNull(3))
                {
                    argument.Value = reader.GetString(3);
                }
            }
            reader.Close();
            conn.close();
            return argument;
        }
    }
}
