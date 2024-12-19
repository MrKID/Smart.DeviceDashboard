using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.DeviceDashboard.Models
{
    public class VariableModel : ObservableObject
    {
        public string Name { get; set; }

		private object _value;

		public object Value
		{
			get { return _value; }
			set { SetProperty<object>(ref _value, value); }
		}

        public string Unit { get; set; }
    }
}
