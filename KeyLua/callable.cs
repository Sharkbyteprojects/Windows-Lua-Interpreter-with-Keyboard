using System;
using System.Collections.Generic;
using System.Text;
using WindowsInput;
using System.Threading;
using WindowsInput.Native;
using KeyDir;

namespace CallLua.Callablethings
{
    class callable
    {
        InputSimulator sim = new InputSimulator();
        keydir kd = new keydir();
        public bool twait(int seconds)
        {
            Thread.Sleep(seconds * 1000);
            return true;
        }
        public bool keypress(string keyname)
        {
            bool fail = false;
            try
            {
                sim.Keyboard.KeyPress(kd.getKeycode(keyname));
            }
            catch (Exception e) { fail = true; Console.WriteLine(string.Format("KeyError: {0}", e.Message)); }
            return !fail;
        }
        public bool keystate(string keyname, bool keydown)
        {
            bool fail = false;
            try
            {
                if (keydown)
                {
                    sim.Keyboard.KeyDown(kd.getKeycode(keyname));
                }
                else
                {
                    sim.Keyboard.KeyUp(kd.getKeycode(keyname));
                }
            }
            catch (Exception e) { fail = true; Console.WriteLine(string.Format("KeyError: {0}", e.Message)); }
            return !fail;
        }
        public bool entertext(string text)
        {
            bool fail = false;
            try
            {
                sim.Keyboard.TextEntry(text);
            }
            catch (Exception e) { fail = true; Console.WriteLine(string.Format("KeyError: {0}", e.Message)); }
            return !fail;
        }
        public bool keystroke(string keyname, string key2)
        {
            bool fail = false;
            try
            {
                sim.Keyboard.ModifiedKeyStroke(kd.getKeycode(keyname), kd.getKeycode(key2));
            }
            catch (Exception e) { fail = true; Console.WriteLine(string.Format("KeyError: {0}", e.Message)); }
            return !fail;
        }
        public bool print(string toout)
        {
            Console.WriteLine(toout);
            return true;
        }
        public bool writef(string n, string c)
        {
            System.IO.File.WriteAllText(n, c);
            return true;
        }
        Dictionary<string, object> storage = new Dictionary<string, object>();
        public bool writeStore(string name, object o)
        {
            storage[name] = o;
            return true;
        }
        public bool pause()
        {
            Console.WriteLine("Press any Key ...");
            Console.ReadKey();
            return true;
        }
        public object readStore(string name)
        {
            return storage[name];
        }
        public string requestinput(string toreq)
        {
            Console.WriteLine(string.Format("{0}: ", toreq));
            return Console.ReadLine();
        }
    }
}
