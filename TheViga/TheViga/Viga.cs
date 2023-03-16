using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheViga
{
    internal class Viga
    {
        private string _weight;
        private int _totalWeight = 0;
        private int _platforms = 0;
        private int _valuePlatforms = 0;
        private int _endurance;

        public string Weight
        {
            get => _weight;
            set => _weight = value;
        }

        public int TotalWeight
        {
            get => _totalWeight;
            set => _totalWeight = value;
        }

        public int Endurance
        {
            get => _endurance;
            set => _endurance = value;
        }

        public Viga() { }

        public int AnalizeBase()
        {
            if (_weight[0] != '%' && _weight[0] != '&' && _weight[0] != '#')
            {
                throw new ArgumentException("The beam is poorly built. Has no base.");
            }

            if (_weight[0] == '%')
            {
                return 10;
            }
            else if (_weight[0] == '&')
            {
                return 30;
            }
            else
            {
                return 90;
            }
        }

        public void VerifyWeight()
        {
            for (int i = 1; i < _weight.Length; i++)
            {
                if (_weight[i] == '=')
                {
                    _valuePlatforms++;
                    _platforms += _valuePlatforms;
                    _totalWeight += _valuePlatforms;
                }
                else if (_weight[i] == '*')
                {
                    if (_weight[i - 1] == '*')
                    {
                        throw new NotImplementedException("The beam is poorly built. Has connection error.");
                    }
                    else
                    {
                        _totalWeight += 2 * _platforms;
                        _platforms = 0;
                        _valuePlatforms = 0;
                    }
                }
                else
                {
                    throw new NotImplementedException("Error of construction.");
                }
            }
        }
    }
}
