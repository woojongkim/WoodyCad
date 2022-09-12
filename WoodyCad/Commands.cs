using Autodesk.AutoCAD.EditorInput;
using Autodesk.AutoCAD.Runtime;
using Autodesk.AutoCAD.ApplicationServices;
using System.Collections;

namespace WoodyCad
{
    public class Commnads
    {
        [CommandMethod("PS_HELLO", CommandFlags.Transparent)]
        public void Hhello()
        {
            var document = Application.DocumentManager.MdiActiveDocument;



            var editor = document.Editor;

            editor.WriteMessage("\nHello WOrld!");
        }

        [CommandMethod("PS_LOGLEVEL", CommandFlags.Transparent)]
        public void LogLevelChange()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            PromptStringOptions prompt = new PromptStringOptions("LogLevel : ");

            PromptResult drawingPromptResult = ed.GetString(prompt);
            if (drawingPromptResult.Status == PromptStatus.OK)
            {
                if (drawingPromptResult.StringResult.Equals("DEBUG") || drawingPromptResult.StringResult.Equals("0"))
                    LoggerUtils.Current = LoggerUtils.LogLevel.DEBUG;
                else if (drawingPromptResult.StringResult.Equals("INFO") || drawingPromptResult.StringResult.Equals("1"))
                    LoggerUtils.Current = LoggerUtils.LogLevel.INFO;
                else if (drawingPromptResult.StringResult.Equals("WARN") || drawingPromptResult.StringResult.Equals("2"))
                    LoggerUtils.Current = LoggerUtils.LogLevel.WARN;
                else if (drawingPromptResult.StringResult.Equals("ERROR") || drawingPromptResult.StringResult.Equals("3"))
                    LoggerUtils.Current = LoggerUtils.LogLevel.ERROR;
                else if (drawingPromptResult.StringResult.Equals("FATAL") || drawingPromptResult.StringResult.Equals("4"))
                    LoggerUtils.Current = LoggerUtils.LogLevel.FATAL;
            }
        }


        [CommandMethod("PS_CHECKOUT", CommandFlags.Transparent)]
        public void Checkout()
        {
            Editor ed = Application.DocumentManager.MdiActiveDocument.Editor;

            PromptStringOptions prompt = new PromptStringOptions("Input drawing id : ");

            PromptResult drawingPromptResult = ed.GetString(prompt);
            if (drawingPromptResult.Status == PromptStatus.OK)
            {
                ValutService valutService = new ValutService();
                valutService.CheckOut(drawingPromptResult.StringResult);
            }
        }

        [CommandMethod("PS_REINIT", CommandFlags.Transparent)]
        public void Reinit()
        {
            EKIWindowService eKIWindowService = new EKIWindowService();
            eKIWindowService.Init();
        }

    }

}
