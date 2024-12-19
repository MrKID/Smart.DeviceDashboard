using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zhaoxi.DeviceDashboard.Models;

namespace Zhaoxi.DeviceDashboard.ViewModels
{
    public class MainViewModel : ObservableObject
    {
        // 基本信息池
        public List<DeviceGroupModel> DeviceGroup { get; set; } =
            new List<DeviceGroupModel>();

        private string _currentImage;

        public string CurrentImage
        {
            get { return _currentImage; }
            set { SetProperty<string>(ref _currentImage, value); }
        }



        public List<DeviceItemModel> DeviceList { get; set; } =
            new List<DeviceItemModel>();

        public List<AlarmItemModel> AlarmList { get; set; } =
            new List<AlarmItemModel>();


        public RelayCommand<object> NavCommand { get; set; }

        public MainViewModel()
        {
            // 有多少个设备组
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/Zhaoxi.DeviceDashboard;component/Assets/Images/Devices/d_1.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=11,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Feed Rate Multiplier",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Spindle Speed",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="MT Coordinates-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=12,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Feed Rate Multiplier",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Spindle Speed",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="MT Coordinates-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=13,
                        IsWarning=true,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Feed Rate Multiplier",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Spindle Speed",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="MT Coordinates-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=14,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Feed Rate Multiplier",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Spindle Speed",
                                Value="0",
                                Unit="r/min"
                            },
                            new VariableModel{
                                Name="MT Coordinates-X",
                                Value="-500.000",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Y",
                                Value="-122.002",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="MT Coordinates-Z",
                                Value="-1525.321",
                                Unit="mm"
                            },
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/Zhaoxi.DeviceDashboard;component/Assets/Images/Devices/d_2.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=21,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L NO",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B NO",
                                Value="0"
                            },
                            new VariableModel{
                                Name="Power-on Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="Machine ON Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=22,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L NO",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B NO",
                                Value="0"
                            },
                            new VariableModel{
                                Name="Power-on Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="Machine ON Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=23,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L NO",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B NO",
                                Value="0"
                            },
                            new VariableModel{
                                Name="Power-on Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="Machine ON Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=24,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="L NO",
                                Value="31",
                            },
                            new VariableModel{
                                Name="N NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="B NO",
                                Value="0"
                            },
                            new VariableModel{
                                Name="Power-on Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="Machine ON Time",
                                Value="0:0:10"
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002"
                            }
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/Zhaoxi.DeviceDashboard;component/Assets/Images/Devices/d_3.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=31,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="Joint Axis-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="Joint Axis-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="Joint Axis-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="Joint Axis-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="Joint Axis-J5",
                                Value="-8.535",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=32,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="手动",
                            },
                            new VariableModel{
                                Name="Joint Axis-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="Joint Axis-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="Joint Axis-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="Joint Axis-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="Joint Axis-J5",
                                Value="-8.535",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=33,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="手动",
                            },
                            new VariableModel{
                                Name="Joint Axis-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="Joint Axis-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="Joint Axis-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="Joint Axis-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="Joint Axis-J5",
                                Value="-8.535",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=34,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="手动",
                            },
                            new VariableModel{
                                Name="Joint Axis-J1",
                                Value="-97.979",
                            },
                            new VariableModel{
                                Name="Joint Axis-J2",
                                Value="-31.493",
                            },
                            new VariableModel{
                                Name="Joint Axis-J3",
                                Value="-34.517",
                            },
                            new VariableModel{
                                Name="Joint Axis-J4",
                                Value="-0.032",
                            },
                            new VariableModel{
                                Name="Joint Axis-J5",
                                Value="-8.535",
                            }
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/Zhaoxi.DeviceDashboard;component/Assets/Images/Devices/d_4.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=41,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="Position Coordinates-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Position Coordinates-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="Position Coordinates-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Surface Roughness",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="PV Height",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=42,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="Position Coordinates-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Position Coordinates-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="Position Coordinates-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Surface Roughness",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="PV Height",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=43,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="Position Coordinates-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Position Coordinates-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="Position Coordinates-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Surface Roughness",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="PV Height",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=44,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="MANUAL",
                            },
                            new VariableModel{
                                Name="Position Coordinates-X",
                                Value="50.23",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Position Coordinates-Y",
                                Value="26.67",
                            },
                            new VariableModel{
                                Name="Position Coordinates-Z",
                                Value="10.45",
                                Unit="mm"
                            },
                            new VariableModel{
                                Name="Surface Roughness",
                                Value="0.32",
                                Unit="μm"
                            },
                            new VariableModel{
                                Name="PV Height",
                                Value="2.10",
                                Unit="μm"
                            }
                        }
                    }
                }
            });
            DeviceGroup.Add(new DeviceGroupModel()
            {
                Image = "/Zhaoxi.DeviceDashboard;component/Assets/Images/Devices/d_5.png",
                // 里面对应多少台设备
                DeviceList = new List<DeviceItemModel>()
                {
                    new DeviceItemModel()
                    {
                        Index=51,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Stop NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Boot Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="Working Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="Mechanical Coordinates",
                                Value="N/A",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=52,
                        IsWarning=true,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Stop NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Boot Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="Working Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="Mechanical Coordinates",
                                Value="N/A",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=53,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Stop NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Boot Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="Working Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="Mechanical Coordinates",
                                Value="N/A",
                            }
                        }
                    },
                    new DeviceItemModel()
                    {
                        Index=54,
                        // 设备中有多少监测变量
                        VariableList=new List<VariableModel>{
                            new VariableModel{
                                Name="Working Mode",
                                Value="AUTO",
                            },
                            new VariableModel{
                                Name="Stop NO",
                                Value="0",
                            },
                            new VariableModel{
                                Name="Boot Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="Working Time",
                                Value="0:0:0",
                            },
                            new VariableModel{
                                Name="E Condition NO",
                                Value="909002",
                            },
                            new VariableModel{
                                Name="Mechanical Coordinates",
                                Value="N/A",
                            }
                        }
                    }
                }
            });

            for (int i = 0; i < 15; i++)
            {
                AlarmList.Add(new AlarmItemModel() { Index = i + 1 });
            }


            NavCommand = new RelayCommand<object>(OnNavigation);

            OnNavigation("0");

            // 启动监听设备信息
            StartMonitor();
        }
        private void OnNavigation(object arg)
        {
            var group = DeviceGroup[int.Parse(arg.ToString())];
            // 显示当前级的设备图片
            CurrentImage = group.Image;
            DeviceList = group.DeviceList;

            this.OnPropertyChanged(nameof(DeviceList));
        }

        CancellationTokenSource cts = new CancellationTokenSource();
        private void StartMonitor()
        {
            Task.Run(async () =>
            {
                S7.Net.Plc plc = new S7.Net.Plc(S7.Net.CpuType.S7200Smart, "192.168.2.1", 0, 0);
                plc.Open();

                var list = DeviceGroup[0].DeviceList;
                while (!cts.IsCancellationRequested)
                {
                    ushort[] values = (ushort[])plc.Read(S7.Net.DataType.DataBlock, 1, 100, S7.Net.VarType.Word, 24);
                    // 0 0 0 0 0 0    0 0 0 0 0 0
                    // 报警条件：
                    for (int i = 0; i < 4; i++)
                    {
                        var item = list[i];
                        item.IsWarning = false;

                        for (int j = 0; j < item.VariableList.Count; j++)
                        {
                            item.VariableList[j].Value = values[i * 6 + j];
                        }

                        // 判断当前设备的Spindle Speed不能低于50
                        if ((ushort)item.VariableList[2].Value < 50)
                            item.IsWarning = true;
                    }

                    await Task.Delay(1000);
                }

                plc.Close();
            }, cts.Token);
        }
    }
}
