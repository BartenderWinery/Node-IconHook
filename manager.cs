using System;
using System.Collections.Generic;
using IWshRuntimeLibrary;
namespace iconhook{
    class main{
        static void Main(string[] args){
            Console.WriteLine("Successful; "+String.Join(";",args)); //arg output
            Dictionary<string,string> rest=new Dictionary<string,string>();
            WshShell shell=new WshShell();
            IWshShortcut lnk=(IWshShortcut)shell.CreateShortcut(args[0]);
            rest.Add("path",lnk.TargetPath);
            Console.WriteLine(rest["path"]);}}}