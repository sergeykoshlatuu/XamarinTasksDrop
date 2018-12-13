using System;
using MvvmCross;

namespace TasksDrop.Core.Models
{
    class Task
    {
        public int _id;
        public string _title;
        public string _description;

        public int Id
        {
            get => _id;
            set
            {
                _id = value;
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                _title = value;
               
            }
        }

        public string Description
        {
            get => _description;
            set
            {
                _description = value;
              
            }
        }
    }
}
