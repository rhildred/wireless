using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Twilio;
using Twilio.TwiML;


namespace wireless.Pages
{

public class User{
    private enum State
    {
        WELCOMING, GUESSING
    }

    private State nCur = State.WELCOMING;
    private int nNumber;
    User(){
        Random rnd = new Random();
        this.nNumber = rnd.Next(1, 99);

    }

    public String OnMessage(String sMessage){
        sMessage = "Welcome, I am thinking of a number between 1 and 100 ... Please guess";
        switch (this.nCur){
            case State.WELCOMING:
                this.nCur = State.GUESSING;
                break;
            case State.GUESSING:
                try{
                    if(Int32.Parse(sMessage) > this.nNumber){
                        sMessage = "Too high";
                    }else if(Int32.Parse(sMessage) < this.nNumber){
                        sMessage = "Too low";
                    }else{
                        sMessage = "Just Right ... Guess my new number";
                        Random rnd = new Random();
                        this.nNumber = rnd.Next(1, 99);
                    }
                }
                catch(Exception){
                    sMessage = "Enter a number between 1 and 100";
                }
                break;

        }
        return sMessage;
    }
}

 [IgnoreAntiforgeryToken(Order = 1001)]
    public class IndexModel : PageModel
    {
        public string Message { get; set; }
        public ActionResult OnPost()
        {
            string sFrom = Request.Form["From"];
            string sBody = Request.Form["Body"];
            var oMessage = new Twilio.TwiML.MessagingResponse();
            oMessage.Message("Hello There");
            return Content(oMessage.ToString());
        }
    }
}
