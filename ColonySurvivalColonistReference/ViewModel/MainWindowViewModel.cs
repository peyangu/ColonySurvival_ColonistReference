using ColonySurvivalColonistReference.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColonySurvivalColonistReference.ViewModel
{
    public class MainWindowViewModel : ModelBase
    {
        public MainWindowModel Model { get; set; }

        public MainWindowViewModel()
        {
            Model = new MainWindowModel();
        }
    }
}
