using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using MvvmCross.ViewModels;
using TasksDrop.Core.Models;
namespace TasksDrop.Core.ViewModels
{
     public class TasksDropViewModel:MvxViewModel
    {
        
 
        public event PropertyChangedEventHandler PropertyChanged;
        private Task _task;

        public TasksDropViewModel()
        {
            _task = new Task();
        }

        public int Id
        {
            get => _task.Id;
    
            set
            {
                _task.Id = value;
                RaisePropertyChanged(() => Id);
            }
        }

        public string Title
        {
            get => _task.Title;
            set
            {
                _task.Title = value;
                RaisePropertyChanged(() => Title);
            }
        }

        public string Description
        {
            get => _task.Description;
            set
            {
                _task.Description = value;
                RaisePropertyChanged(() => Description);
            }
        }
       
        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }
    }
}

