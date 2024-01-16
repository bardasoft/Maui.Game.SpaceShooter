﻿using Foundation;
using SpaceShooter.Game;
using System.Diagnostics;
using UIKit;

namespace SpaceShooter;

[Register("AppDelegate")]
public class AppDelegate : MauiUIApplicationDelegate
{

    public override void PressesBegan(NSSet<UIPress> presses, UIPressesEvent evt)
    {
        foreach (UIPress press in presses)
        {
            var mapped = AppleKeyMapper.MapToMaui((int)press.Type);
            MauiGame.KeyboardPressed(mapped);
        }

        //if (!consumed)
        //{
        //    base.PressesBegan(presses, evt);
        //}
    }

    void ReleaseKeys(NSSet<UIPress> presses)
    {
        foreach (UIPress press in presses)
        {
            var mapped = AppleKeyMapper.MapToMaui((int)press.Type);
            MauiGame.KeyboardReleased(mapped);

            Trace.WriteLine($"[KEY] {press.Type}/{(int)press.Type} => {mapped}");
        }
    }

    public override void PressesEnded(NSSet<UIPress> presses, UIPressesEvent evt)
    {
        base.PressesEnded(presses, evt);

        ReleaseKeys(presses);
    }

    protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
}

public static class AppleKeyMapper
{
    public static MauiKey MapToMaui(int virtualKey)
    {
        switch (virtualKey)
        {
        case 2044: return MauiKey.Space;
        case 2080: return MauiKey.ArrowLeft;
        case 2079: return MauiKey.ArrowUp;
        //case VirtualKey.Right: return MauiKey.ArrowRight;
        //case VirtualKey.Down: return MauiKey.ArrowDown;
        //case VirtualKey.Number0: return MauiKey.Digit0;
        //case VirtualKey.Number1: return MauiKey.Digit1;
        //case VirtualKey.Number2: return MauiKey.Digit2;
        //case VirtualKey.Number3: return MauiKey.Digit3;
        //case VirtualKey.Number4: return MauiKey.Digit4;
        //case VirtualKey.Number5: return MauiKey.Digit5;
        //case VirtualKey.Number6: return MauiKey.Digit6;
        //case VirtualKey.Number7: return MauiKey.Digit7;
        //case VirtualKey.Number8: return MauiKey.Digit8;
        //case VirtualKey.Number9: return MauiKey.Digit9;
        //case VirtualKey.A: return MauiKey.KeyA;
        //case VirtualKey.B: return MauiKey.KeyB;
        //case VirtualKey.C: return MauiKey.KeyC;
        //case VirtualKey.D: return MauiKey.KeyD;
        //case VirtualKey.E: return MauiKey.KeyE;
        //case VirtualKey.F: return MauiKey.KeyF;
        //case VirtualKey.G: return MauiKey.KeyG;
        //case VirtualKey.H: return MauiKey.KeyH;
        //case VirtualKey.I: return MauiKey.KeyI;
        //case VirtualKey.J: return MauiKey.KeyJ;
        //case VirtualKey.K: return MauiKey.KeyK;
        //case VirtualKey.L: return MauiKey.KeyL;
        //case VirtualKey.M: return MauiKey.KeyM;
        //case VirtualKey.N: return MauiKey.KeyN;
        //case VirtualKey.O: return MauiKey.KeyO;
        //case VirtualKey.P: return MauiKey.KeyP;
        //case VirtualKey.Q: return MauiKey.KeyQ;
        //case VirtualKey.R: return MauiKey.KeyR;
        //case VirtualKey.S: return MauiKey.KeyS;
        //case VirtualKey.T: return MauiKey.KeyT;
        //case VirtualKey.U: return MauiKey.KeyU;
        //case VirtualKey.V: return MauiKey.KeyV;
        //case VirtualKey.W: return MauiKey.KeyW;
        //case VirtualKey.X: return MauiKey.KeyX;
        //case VirtualKey.Y: return MauiKey.KeyY;
        //case VirtualKey.Z: return MauiKey.KeyZ;
        //case VirtualKey.CapitalLock: return MauiKey.CapsLock;
        //case VirtualKey.Insert: return MauiKey.Insert;
        //case VirtualKey.Delete: return MauiKey.Delete;
        //case VirtualKey.Snapshot: return MauiKey.PrintScreen;
        //case VirtualKey.Home: return MauiKey.Home;
        //case VirtualKey.End: return MauiKey.End;
        //case VirtualKey.PageDown: return MauiKey.PageDown;
        //case VirtualKey.PageUp: return MauiKey.PageUp;
        //case VirtualKey.Escape: return MauiKey.Escape;
        //case VirtualKey.Pause: return MauiKey.Pause;
        //case VirtualKey.Menu: return MauiKey.AltLeft;
        //case VirtualKey.LeftMenu: return MauiKey.AltLeft;
        //case VirtualKey.RightMenu: return MauiKey.AltRight;
        //case VirtualKey.Shift: return MauiKey.ShiftLeft;
        //case VirtualKey.LeftShift: return MauiKey.ShiftLeft;
        //case VirtualKey.RightShift: return MauiKey.ShiftRight;
        //case VirtualKey.LeftControl: return MauiKey.ControlLeft;
        //case VirtualKey.RightControl: return MauiKey.ControlRight;
        //case VirtualKey.Control: return MauiKey.ControlLeft;
        //case VirtualKey.Enter: return MauiKey.Enter;
        //case VirtualKey.Tab: return MauiKey.Tab;
        //case VirtualKey.Back: return MauiKey.Backspace;
        //case VirtualKey.F1: return MauiKey.F1;
        //case VirtualKey.F2: return MauiKey.F2;
        //case VirtualKey.F3: return MauiKey.F3;
        //case VirtualKey.F4: return MauiKey.F4;
        //case VirtualKey.F5: return MauiKey.F5;
        //case VirtualKey.F6: return MauiKey.F6;
        //case VirtualKey.F7: return MauiKey.F7;
        //case VirtualKey.F8: return MauiKey.F8;
        //case VirtualKey.F9: return MauiKey.F9;
        //case VirtualKey.F10: return MauiKey.F10;
        //case VirtualKey.F11: return MauiKey.F11;
        //case VirtualKey.F12: return MauiKey.F12;
        //case VirtualKey.NumberKeyLock: return MauiKey.NumLock;
        //case VirtualKey.Scroll: return MauiKey.ScrollLock;
        //case VirtualKey.NumberPad0: return MauiKey.Numpad0;
        //case VirtualKey.NumberPad1: return MauiKey.Numpad1;
        //case VirtualKey.NumberPad2: return MauiKey.Numpad2;
        //case VirtualKey.NumberPad3: return MauiKey.Numpad3;
        //case VirtualKey.NumberPad4: return MauiKey.Numpad4;
        //case VirtualKey.NumberPad5: return MauiKey.Numpad5;
        //case VirtualKey.NumberPad6: return MauiKey.Numpad6;
        //case VirtualKey.NumberPad7: return MauiKey.Numpad7;
        //case VirtualKey.NumberPad8: return MauiKey.Numpad8;
        //case VirtualKey.NumberPad9: return MauiKey.Numpad9;
        //case VirtualKey.LeftWindows: return MauiKey.MetaLeft;
        //case VirtualKey.RightWindows: return MauiKey.MetaRight;
        //case VirtualKey.Divide: return MauiKey.NumpadDivide;
        //case VirtualKey.Multiply: return MauiKey.NumpadMultiply;
        //case VirtualKey.Subtract: return MauiKey.NumpadSubtract;
        //case VirtualKey.Add: return MauiKey.NumpadAdd;
        }

        if ((int)virtualKey == 187) return MauiKey.Equal;
        if ((int)virtualKey == 189) return MauiKey.Minus;
        if ((int)virtualKey == 192) return MauiKey.Backquote;


        return MauiKey.Unknown;

    }
}