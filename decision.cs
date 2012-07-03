using System.Collections.Generic;

namespace Orpheum.objects
{

    public class Decision
    {
        public string Question { get; set; }
        public List<Response> Responses { get; set; }

        public Decision()
        {
            Question = "";
            Responses = new List<Response>();
        }
        public Decision(string question)
        {
            Question = question;
            Responses = new List<Response>();
        }
    }

}
