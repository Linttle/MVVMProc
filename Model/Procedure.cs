using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace MVVMProc.Model
{        
    public class Procedure : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private string procName = "procedure";
        private string procType = "default";
        private bool enabled = true;
        private Dictionary<string, string> parameters = new Dictionary<string, string>();

        private void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }

        public Procedure() { }

        public Procedure(string name, string type)
        {
            procName = name;
            procType = type;
        }

        public Procedure(string type)
        {
            procType = type;
        }

        public Procedure(string type, Dictionary<string, string> dict)
        {
            procType = type;
            parameters = dict;
        }

        public string ProcName
        {
            get { return procName; }
            set { procName = value; }
        }

        public string ProcType
        {
            get { return procType; }
            set { procType = value; }
        }

        public bool Enabled
        {
            get { return enabled; }
            set { enabled = value; }
        }

        public Dictionary<string, string> ProcParams
        {
            get { return parameters; }
            set { parameters = value; }
        }

        public void AddParam(string key, string value)
        {
            parameters.Add(key, value);
        }

        public override string ToString()
        {
            string msgBoxText = $"Procedure Type: {procType}\n";
            foreach (var param in parameters)
            {
                string paramText = $"{param.Key}: {param.Value}\n";
                msgBoxText += paramText;
            }
            return msgBoxText;
        }
    }
}
