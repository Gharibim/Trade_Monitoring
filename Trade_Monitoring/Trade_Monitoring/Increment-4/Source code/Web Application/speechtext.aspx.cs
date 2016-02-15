using System;
using System.Speech.Synthesis;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;

namespace ConvertTextToSpeech
{
    public partial class speechtext : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnVoice_Click(object sender, EventArgs e)
        {

            // creating the object of SpeechSynthesizer class
            SpeechSynthesizer sp = new SpeechSynthesizer();
            //setting volume 
            sp.Volume = 100;
            //passing text box text to SpeakAsync method 

            string text = txtMsg.Text;
            sp.SpeakAsync(text);

        }
    }
}