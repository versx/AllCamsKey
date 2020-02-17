/*
 * Author: Jeremy Broadbent (versx)
 * Date: 7/26/2017
*/

using System;
using System.Diagnostics;
using SKGL;

namespace T
{
    class Program
    {
        static string _secretPhase = "TheVSViewer2014Licen$$eContinue";

        static void Main(string[] args)
        {
            var gen = new Generate();
            gen.secretPhase = _secretPhase;
            var key = gen.doKey(999, DateTime.Now);
            Console.WriteLine($"Key: {key}");
            Debug.WriteLine($"Key: {key}");

            var serialKeyConfig = new SerialKeyConfiguration { addSplitChar = true, Features = new bool[] { true }, Key = key} ;
            var validate = new Validate(serialKeyConfig);
            validate.secretPhase = _secretPhase;
            Console.WriteLine($"Valid: {validate.IsValid}");
            //Console.WriteLine("Correct Machine: {0}", validate.IsOnRightMachine);
            //Console.WriteLine("Expired: {0}", validate.IsExpired);

            Console.Read();
        }
    }
}