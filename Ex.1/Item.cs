using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1
{
    public class Item
    {
        private string _name = "unknown";


        public void SetName(string name)
        {
            _name = name;
        }

        public string GetName()
        {
            if (string.IsNullOrEmpty(_name))
                return "Это строка пуста";
            return _name;
        }
    }
}
