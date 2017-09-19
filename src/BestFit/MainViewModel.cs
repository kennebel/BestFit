using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestFit
{
    public class MainViewModel : BaseNotify
    {
        #region Fields
        private string _StartOn = "";
        private string _EndOn = "";
        private Dictionary<DateTime, string> _Output = new Dictionary<DateTime, string>();
        #endregion

        #region Properties
        public string StartOn
        {
            get { return _StartOn; }
            set
            {
                if (_StartOn != value)
                {
                    _StartOn = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime? Start
        {
            get
            {
                DateTime Result = DateTime.MinValue;
                if (DateTime.TryParse(StartOn, out Result))
                {
                    return Result;
                }
                return null;
            }
        }

        public string EndOn
        {
            get { return _EndOn; }
            set
            {
                if (_EndOn != value)
                {
                    _EndOn = value;
                    OnPropertyChanged();
                }
            }
        }

        public DateTime? End
        {
            get
            {
                DateTime Result = DateTime.MinValue;
                if (DateTime.TryParse(EndOn, out Result))
                {
                    return Result;
                }
                return null;
            }
        }

        public Dictionary<string, int> DayList { get; set; }

        public Dictionary<DateTime, string> Output
        {
            get { return _Output; }
            set
            {
                if (_Output != value)
                {
                    _Output = value ?? new Dictionary<DateTime, string>();
                    OnPropertyChanged();
                }
            }
        }
        #endregion
    }
}
