using System;
using System.Collections.Generic;

namespace Statistics
{

    public class MailAlert : IAlertSender
    {
        
        public bool emailAlert;
        
        public MailAlert(){
            emailAlert = false;
        }
        
        public void Alert()
        {
            emailAlert = true;
        }
    }
    
}
