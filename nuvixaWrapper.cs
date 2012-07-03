using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Orpheum.objects
{
    class nuvixaWrapper
    {
        Nuvixa.UE.UserExtraction newDll = new Nuvixa.UE.UserExtraction();
        public event onAlphaListner onAlphaListnerEvent;
        public delegate void onAlphaListner(object alphaImage);
        public event onDepthListner onDepthListnerEvent;
        public delegate void onDepthListner(Int32  depth);

        public nuvixaWrapper ()
        {
            //intialize access to nuvixa object
            // possibly add listener event

            // TODO: Add real code for Nuvixa technology
            FakeNuxiaWrapper dll = new FakeNuxiaWrapper();
            
            newDll.NewUEImage += new Action<System.Windows.Media.Imaging.BitmapSource>(newDll_NewUEImage);
  
            // add comments about event
            /// TODO: Research about Lambda
            dll.onAlphaListnerEvent += (alphaImage) =>
            {
                onAlphaListnerEvent(alphaImage);
            };
        }

        void newDll_NewUEImage(System.Windows.Media.Imaging.BitmapSource obj)
        {
            onAlphaListnerEvent(obj);
            onDepthListnerEvent(newDll.getUserComZ());

        }

 

 
 
    }

    public class FakeNuxiaWrapper
    {
        public event onAlphaListner onAlphaListnerEvent;
        public delegate void onAlphaListner(object alphaImage);
        public event onDepthListner onDepthListnerEvent;
        public delegate void onDepthListner(Int32 depth);
    }
}
