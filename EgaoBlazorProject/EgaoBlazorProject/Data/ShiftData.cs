using System;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace EgaoBlazorProject.Data
{
    public class ShiftData : ComponentBase
    {
        public List<Dictionary<string, string>> info = new List<Dictionary<string, string>>();

        public ShiftData()
        {
            // test code for table
            for (int i = 0; i < 20; i++)
            {
                Dictionary<string, string> dic = new Dictionary<string, string>();
                dic.Add("name", "name(" + i + ")");
                dic.Add("shift", "shift(" + i + ")");

                info.Add(dic);
            }

            // TODO:MySql

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
