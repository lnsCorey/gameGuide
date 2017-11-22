using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Collections.ObjectModel;
using pubgGuide.Models;

namespace pubgGuide.ViewModels
{
    class GuideViewModel: NotificationBase
    {
        Guide guide;

        public GuideViewModelModel(String name)
        {
            guide = new Guide(name);
            _SelectedIndex = -1

            //Load the database

            foreach (var )

        }

    }
}
