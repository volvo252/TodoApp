using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Models
{
    internal class TodoModel
    {
        public DateTime CreationDate { get; set; } = DateTime.Now;  // при создании объекта дататайм будет сразу же присваиваться текущее время

		private bool _IsDone;
		private string _text;

		public bool IsDone
		{
			get { return _IsDone; }
			set { _IsDone = value; }
		}
		public string Text
		{
			get { return _text; }
			set { _text = value; }
		}

	}
}
