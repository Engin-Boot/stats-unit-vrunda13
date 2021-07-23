using System;
using System.Collections.Generic;

namespace Statistics
{
    
    public class LEDBulbAlert : IAlert
    {
       
        public bool ledBulbGlows;
       
        public LEDBulbAlert(){
            ledBulbGlows = false;
        }
           
        public void Alert()
        {
            ledBulbGlows = true;
        }
    }
    
}
