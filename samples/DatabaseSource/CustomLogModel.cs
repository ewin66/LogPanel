using LogDashboard.Model;
using System;

namespace DatabaseSource
{
    public class CustomLogModel : LogModel
    {
        public string MachineName { get; set; }

        public string Callsite { get; set; }
    }

    public class Alog : LogModel
    {
        public string URL { get; set; }

        public string Action { get; set; }

        public string Arguments { get; set; }
    }
}
