using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Serialak
{
    partial class Checker : ServiceBase
    {
        public Checker()
        {
            InitializeComponent();
            
        }

        protected override void OnStart(string[] args)
        {
            // TODO: Tutaj dodaj kod, aby uruchomić swoją usługę.
        }

        protected override void OnStop()
        {
            // TODO: Tutaj dodaj kod, aby wykonać wszelkie zakończenia niezbędne do zatrzymania usługi.
        }
    }
}
