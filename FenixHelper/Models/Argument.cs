using System;
using System.Collections.Generic;
using System.Text;

namespace FenixHelper
{
    class Argument
    {
        int id;
        int task_id;
        string name;
        string value;

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

        public int Task_id
        {
            get
            {
                return task_id;
            }

            set
            {
                task_id = value;
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

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
