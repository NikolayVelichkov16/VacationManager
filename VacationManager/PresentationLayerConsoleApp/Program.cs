using System;
using ServiceLayer;

namespace PresentationLayerConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CEOView ceoView = new CEOView();
            ceoView.Create();
        }
    }
}
