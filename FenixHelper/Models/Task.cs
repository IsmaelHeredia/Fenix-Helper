using System;
using System.Collections.Generic;
using System.Text;

namespace FenixHelper
{
    class Task
    {
        int id;
        int key_id;
        string name;
        string working_directory;
        string filename;
        int window_style;
        int terminate;
        int admin;

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public int Key_id
        {
            get
            {
                return key_id;
            }

            set
            {
                key_id = value;
            }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Working_directory
        {
            get
            {
                return working_directory;
            }

            set
            {
                working_directory = value;
            }
        }

        public string Filename
        {
            get
            {
                return filename;
            }

            set
            {
                filename = value;
            }
        }

        public int Window_style
        {
            get
            {
                return window_style;
            }

            set
            {
                window_style = value;
            }
        }

        public int Terminate
        {
            get
            {
                return terminate;
            }

            set
            {
                terminate = value;
            }
        }

        public int Admin
        {
            get
            {
                return admin;
            }

            set
            {
                admin = value;
            }
        }
    }
}
