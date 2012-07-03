using System;

namespace Orpheum.objects
{
    public class Scene
    {
        public String scene { get; set; }
        public SceneType Type { get; set; }
        public string BackgroundMediaPath { get; set; }
        public Boolean isVideo { get; set; }
        public string ForeGroundMediaPath { get; set; }
        public Boolean ShowAlpha { get; set; }
        public Decision decison { get; set; }
        public Boolean MoveableForeground { get; set; }
        public Scene()
        {
            scene = "";
        }
    }



}
