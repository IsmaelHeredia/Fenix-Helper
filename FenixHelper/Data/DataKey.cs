using System;
using System.Collections;
using System.Text;
using System.Data;
using System.Data.SQLite;

namespace FenixHelper.Data
{
    class DataKey
    {
        public Boolean Add(Key key)
        {
            Boolean response = false;

            Connection conn = new Connection();
            conn.open();

            try
            {
                string name = key.Name;
                int code = key.Code;

                var query = new SQLiteCommand("INSERT INTO keys(name,code) VALUES (@p0,@p1)", conn.connection);

                query.Parameters.AddWithValue("@p0", name);
                query.Parameters.AddWithValue("@p1", code);

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
            ArrayList keys = new ArrayList();
            Connection conn = new Connection();
            conn.open();
            conn.command.CommandText = "SELECT id,name,code FROM keys";
            var reader = conn.command.ExecuteReader();
            while (reader.Read())
            {
                Key key = new Key();
                if (!reader.IsDBNull(0))
                {
                    key.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    key.Name = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    key.Code = reader.GetInt32(2);
                }
                keys.Add(key);
            }
            reader.Close();
            conn.close();
            return keys;
        }

        public Key Get(int id)
        {
            Key key = new Key();
            Connection conn = new Connection();
            conn.open();
            var query = new SQLiteCommand("SELECT id,name,code FROM keys WHERE id = @p0");
            query.Parameters.AddWithValue("@p0", id);

            var reader = query.ExecuteReader();

            reader.Read();

            if (reader.HasRows)
            {
                if (!reader.IsDBNull(0))
                {
                    key.Id = reader.GetInt32(0);
                }
                if (!reader.IsDBNull(1))
                {
                    key.Name = reader.GetString(1);
                }
                if (!reader.IsDBNull(2))
                {
                    key.Code = reader.GetInt32(2);
                }
            }
            reader.Close();
            conn.close();
            return key;
        }
    }
}
