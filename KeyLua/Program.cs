using System;
using System.IO;
using MoonSharp.Interpreter;
using System.Runtime.InteropServices;
using CallLua.Callablethings;

namespace KeyLua
{
    class Program
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();

        static void Main(string[] args)
        {
            AllocConsole();
            Console.WriteLine(string.Format("KeyLua\n{0} Sharkbyteprojects\nHelp: https://github.com/Sharkbyteprojects/Windows-Lua-Interpreter-with-Keyboard\n", ((char)0x00a9).ToString()));
            callable c = new callable();
            foreach (string arg in args)
            {
                if (arg != "")
                {
                    if (File.Exists(arg))
                    {
                        Console.WriteLine(string.Format("Are you Sure to run {0} (IF YES, PRESS Y): ", arg));
                        bool openit = Console.ReadKey().Key == ConsoleKey.Y;
                        Console.WriteLine("");
                        if (openit)
                        {
                            try
                            {
                                string scriptCode = File.ReadAllText(arg);
                                Script script = new Script();
                                script.Globals["wait"] = (Func<int, bool>)c.twait;
                                script.Globals["keypress"] = (Func<string, bool>)c.keypress;
                                script.Globals["keystate"] = (Func<string, bool, bool>)c.keystate;
                                script.Globals["keystroke"] = (Func<string, string, bool>)c.keystroke;
                                script.Globals["keytext"] = (Func<string, bool>)c.entertext;
                                script.Globals["pause"] = (Func<bool>)c.pause;
                                script.Globals["print"] = (Func<string, bool>)c.print;
                                script.Globals["input"] = (Func<string, string>)c.requestinput;
                                script.Globals["file_exist"] = (Func<string, bool>)File.Exists;
                                script.Globals["file_read"] = (Func<string, string>)File.ReadAllText;
                                script.Globals["file_write"] = (Func<string, string, bool>)c.writef;
                                script.Globals["tmpstore_write"] = (Func<string, object, bool>)c.writeStore;
                                script.Globals["tmpstore_read"] = (Func<string, object>)c.readStore;
                                script.DoString(scriptCode);
                                DynValue res = script.Call(script.Globals["main"]);
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine(string.Format("Error: {0}", e.Message));
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine(string.Format("File {0} does not exist\n", arg));
                    }
                }
            }
            Console.WriteLine("Press any Key to exit ...");
            Console.ReadKey();
        }
    }
}
