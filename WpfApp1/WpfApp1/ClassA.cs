using System;
using System.Collections.Generic;
using System.Text;

namespace WpfApp1
{
    public class ClassA
    {
        private string label = "新建类A的标签";
        public string myLabel
        {
            get { return label; }
            set { label = value; }
        }
    }
}
