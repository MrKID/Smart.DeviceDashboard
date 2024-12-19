using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zhaoxi.DeviceDashboard.Models
{
    public class DeviceItemModel : ObservableObject
    {
        public int Index { get; set; }
        private bool _isWarning;

        public bool IsWarning
        {
            get { return _isWarning; }
            set { SetProperty<bool>(ref _isWarning, value); }
        }


        public List<VariableModel> VariableList { get; set; }
    }
}
