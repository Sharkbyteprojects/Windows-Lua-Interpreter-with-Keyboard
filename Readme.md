# Lua Key Interpret for Windows

Make Lua Powerful!

Based on Moonsharp

You can use the most of Luas Std Lib's

Your `.lua` file must contain a `main` function.

```
function main()

-- Your Commands

end
```

## Download

You need also the [.NET Core 3.1](https://dotnet.microsoft.com/download/dotnet-core/thank-you/runtime-desktop-3.1.10-windows-x86-installer) or [Mono (NOT TESTED ON MONO)](https://mono-project.com/)

- [Download Setup](https://github.com/Sharkbyteprojects/Windows-Lua-Interpreter-with-Keyboard/raw/master/.bin/interpreterSetup.exe)

## Additional Functions

Returns		| Args						| Functionname		 | Example												| Describtion
------------|---------------------------|--------------------|------------------------------------------------------|-----------------------------------------------
nothing		| int seconds				| `wait`			 | `wait(10)`											| Wait for `x` Seconds
bool 		| string key				| `keypress`		 | `keypress("return")`									| Press the key `x`
bool		| string key, bool pressed	| `keystate`		 | `keystate("return", true)`							| Press down or release (`y`) key `x`
bool		| string key, string key2	| `keystroke`		 | `keystroke("ctrl", "c")`								| Press keys `x` and `y`
bool		| string text				| `keytext`			 | `keytext("Hello World!")`							| Type Text `x` with Keyboard
nothing		| nothing					| `pause`			 | `pause()`											| Similar to `cmd` command `pause`
nothing		| string text				| `print`			 | `print("Hello World")`								| Print text `x` in console
string		| string text				| `input`			 | `local dish = input("What your favorite dish")`		| Wait for user input on console
bool		| string path				| `file_exist`		 | `if(file_exist("C:\\temp.txt"));do`					| If file `x` exist
string		| string path				| `file_read`		 | `local mydata = file_read("C:\\temp.txt")`			| Read file `x`
bool		| string path, string data	| `file_write`		 | `file_write("C:\\temp.txt", "Hi")`					| Write text `y` to file `x`
bool		| string name, any data		| `tmpstore_write`	 | `tmpstore_write("Number", 3)`						| Alternate to Local, store data as global Var
any			| string name				| `tmpstore_read`	 | `local my = tmpstore_read("Number")`					| Read data from global var

## Keycodes:

All numbers and Alphabet and

- CTRL
- RCTRL
- LCTRL
- SHIFT
- RSHIFT
- LSHIFT
- RETURN
- VOLUME_UP
- VOLUME_DOWN
- VOLUME_MUTE
- LWIN
- RWIN
- PRINT
- BACKSPACE
- SPACE
- TAB
- SNAPSHOT

---

&copy; Sharkbyteprojects