using System;
using System.Collections.Generic;

namespace Statistics
{

    public class MailAlert : IAlert
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
