function main()
    local addtext = input("Your text")
    print("Wait 3 Sec")
    wait(3)
    print("Win")
    keystroke("LWIN", "r")
    wait(1)
    keytext("notepad")
    keypress("return")
    wait(1)
    keytext("Lua with Keys\n<c> Sharkbyteprojects\nHello, I am your Key Friend!\nYou have written: \n    " .. addtext .. "\n\nI think it's to Quit!")
    wait(1)
	pause()
    -- It's to Quit!!
    print("Make VOLUME FOR 9")
    local toadd = 9
    while(toadd >= 0)
    do
        keypress("VOLUME_UP")
        toadd = toadd - 1
    end
end