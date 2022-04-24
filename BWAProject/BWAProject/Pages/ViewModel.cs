using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace BWAProject.Pages
{
    public class ViewModel : ComponentBase
    {
        public List<Dictionary<string, string>> info = new List<Dictionary<string, string>>();

        public ViewModel()
        {
            for (int i = 0; i < 20; i++)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("name","name(" + i + ")");
                dic.Add("shift", "shift(" + i + ")");

                info.Add(dic);
            }
        }

        public List<Dictionary<string, string>> GetInfoList()
        {
            return info;
        }

        public int GetInfoListCount()
        {
            return info.Count;
        }
    }
}
