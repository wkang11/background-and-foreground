using System.Collections.Generic;
using System.Linq;

namespace Orpheum.objects
{
    public class Story
    {
        public List<Scene> story { get; set; }
        public Story()
        {
            story = new List<Scene>();
        }
        public void Clear()
        {
            story.Clear();
        }
        public void Add(Scene scene) 
        {
            story.Add(scene);
        }
       
        public Scene Search(Scene scene)
        {
            return story.Where(x => x.scene == scene.scene).FirstOrDefault();
        }
       
        public Scene NextScene(Scene scene)
        {
            return null;
        }
        public Scene PrevScene(Scene scene)
        {
            return null;
        }


    }

}
