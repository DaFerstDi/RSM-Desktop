using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSM_Desktop.Models
{
    internal class Resource
    {
        private int _value;
        private int _maxValue;
        private String _name;

        public Resource(String name, int value, int maxValue)
        {
            this._name = name;
            set_value(value);
            set_maxValue(maxValue);
        }

        public void set_maxValue(int maxValue)
        {
            this._maxValue = maxValue;
        }
        public void set_value(int value)
        {
            if (validate(value)) _value = value;
            else throw new ArgumentException("---Check the entered number---");
        }
        public int get_value()
        {
            return _value;
        }

        private bool validate(int val)
        {
            if (val < 0) return false;
            if (_maxValue == -10 && val % 10 == 0) return true;
            else if (_maxValue == 0) return true;
            else return val <= _maxValue;
        }

        public String getName()
        {
            return this._name;
        }
    }
}
