
namespace Orpheum.objects
{
    public class Response
    {
        

        public string Value { get; set; }
        public string Action { get; set; }
        public string MediaPath { get; set; }
        public bool CorrectAnswer { get; set; }

        public int p { get; set; }
        public Response()
        {
            Value = "";
            Action = "";
            MediaPath = "";
            CorrectAnswer = false;
        }
        public Response(string value, string action, string mediapath, bool correctAnswer = false)
        {
            Value = value;
            Action = action;
            MediaPath = mediapath;
            CorrectAnswer = correctAnswer;
        }

    }    
}
