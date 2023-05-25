using System;
using System.ComponentModel;

namespace TodoApp.Models
{
    internal class TodoModel : INotifyPropertyChanged
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;  // при создании объекта дататайм будет сразу же присваиваться текущее время

        private bool _IsDone;
        private string _text;

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));  //проверка на null
        }

        public bool IsDone
        {
            get { return _IsDone; }
            set
            {
                if (_IsDone == value)
                    return;
                _IsDone = value;
                OnPropertyChanged("IsDone");
            }
        }
        public string Text
        {
            get { return _text; }
            set
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("Text");
            }
        }

    }
}
