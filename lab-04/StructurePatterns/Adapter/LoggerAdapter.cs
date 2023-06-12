using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class LoggerAdapter : Logger
    {
        private FileWriter _fileWriter;
        private string _file;
        public LoggerAdapter(string file) :base() 
        {
            _fileWriter = new FileWriter();
            _file = file;
        }

        public override void Log(string message)
        {
            _fileWriter.WriteLine(_file, $"[Log] {message}");
            base.Log(message);
        }

        public override void Error(string message)
        {
            _fileWriter.WriteLine(_file, $"[Error] {message}");
            base.Error(message);
        }

        public override void Warn(string message)
        {
            _fileWriter.WriteLine(_file, $"[Warn] {message}");
            base.Warn(message);
        }
    }
}
