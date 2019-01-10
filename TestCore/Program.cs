using System;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Knyaz.Optimus;
using Knyaz.Optimus.Dom.Elements;
using Knyaz.Optimus.Graphics;
using Console = System.Console;

namespace TestCore
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(Ezivi).Wait();
        }

        private static async Task Ezivi()
        {
            var website = "https://www.ezivi.admin.ch/";

            var engine = new Engine();

            await engine.OpenUrl(website);
                
            var button = engine.Document.QuerySelector("a.[title='Einsatz suchen und vereinbaren']") as HtmlElement;
            
            button.Click();
            
            //await engine.OpenUrl("https://www.ezivi.admin.ch/ivy/faces/instances/16839CC238F32510/MainPage.xhtml");
            
            Console.WriteLine(engine.Document.InnerHTML);
            //File.WriteAllText("test.html", engine.Document.OuterHTML);
        }
    }
}
