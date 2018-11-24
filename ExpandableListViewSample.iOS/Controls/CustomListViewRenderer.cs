using System;
using System.ComponentModel;
using ExpandableListViewSample.Controls;
using ExpandableListViewSample.iOS.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomListView),typeof(CustomListViewRenderer))]
namespace ExpandableListViewSample.iOS.Controls
{
    public class CustomListViewRenderer : ListViewRenderer
    { 
        public CustomListViewRenderer()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<ListView> e)
        {
            base.OnElementChanged(e);
            AnimationsEnabled = false;
        }

    }
}