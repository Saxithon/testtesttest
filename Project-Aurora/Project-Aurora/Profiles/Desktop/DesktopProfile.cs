﻿using Aurora.Settings;
using Aurora.Settings.Layers;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Aurora.Profiles.Desktop
{
    public enum InteractiveEffects
    {
        [Description("None")]
        None = 0,
        [Description("Key Wave")]
        Wave = 1,
        [Description("Key Wave (Filled)")]
        Wave_Filled = 3,
        [Description("Key Fade")]
        KeyPress = 2,
        [Description("Arrow Flow")]
        ArrowFlow = 4,
        [Description("Key Wave (Rainbow)")]
        Wave_Rainbow = 5,
    }

    public class DesktopProfile : ApplicationProfile
    {
        public DesktopProfile() : base()
        {
            
        }

        public override void Reset()
        {
            base.Reset();
            Layers = new System.Collections.ObjectModel.ObservableCollection<Layer>()
            {
                new Layer("Ctrl Shortcuts", new ShortcutAssistantLayerHandler()
                {
                    Properties = new ShortcutAssistantLayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Red,
                        _ShortcutKeys = new Keybind[]
                        {
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.X }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.C }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.V }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Z }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.F4 }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.A }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.D }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.R }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Y }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Right }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Left }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Down }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Up }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.LMenu, Keys.Tab }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.LShiftKey, Keys.Up }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.LShiftKey, Keys.Down }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.LShiftKey, Keys.Left }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.LShiftKey, Keys.Right }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Escape }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.LShiftKey, Keys.Escape }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.Escape }),
                            new Keybind( new Keys[] { Keys.LControlKey, Keys.F })
                        }
                    }
                }),
                new Layer("Win Shortcuts", new ShortcutAssistantLayerHandler()
                {
                    Properties = new ShortcutAssistantLayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Blue,
                        _ShortcutKeys = new Keybind[]
                        {
                            new Keybind( new Keys[] { Keys.LWin, Keys.L }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.D }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.B }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.A }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.LMenu, Keys.D }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.E }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.G }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.I }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.M }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.P }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.R }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.S }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.Up }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.Down }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.Left }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.Right }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.Home }),
                            new Keybind( new Keys[] { Keys.LWin, Keys.D })
                        }
                    }
                }),
                new Layer("Alt Shortcuts", new ShortcutAssistantLayerHandler()
                {
                    Properties = new ShortcutAssistantLayerHandlerProperties()
                    {
                        _PrimaryColor = Color.Yellow,
                        _ShortcutKeys = new Keybind[]
                        {
                            new Keybind( new Keys[] { Keys.LMenu, Keys.Tab }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.F4 }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.Space }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.Left }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.Right }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.PageUp }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.PageDown }),
                            new Keybind( new Keys[] { Keys.LMenu, Keys.Tab }),
                        }
                    }
                }),
                new Layer("CPU Usage", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties()
                    {
                        _PrimaryColor =  Color.FromArgb(0, 205, 255),
                        _SecondaryColor = Color.FromArgb(0, 65, 80),
                        _PercentType = PercentEffectType.Progressive_Gradual,
                        _Sequence = new KeySequence(new Devices.DeviceKeys[] {
                            Devices.DeviceKeys.F1, Devices.DeviceKeys.F2, Devices.DeviceKeys.F3, Devices.DeviceKeys.F4,
                            Devices.DeviceKeys.F5, Devices.DeviceKeys.F6, Devices.DeviceKeys.F7, Devices.DeviceKeys.F8,
                            Devices.DeviceKeys.F9, Devices.DeviceKeys.F10, Devices.DeviceKeys.F11, Devices.DeviceKeys.F12
                        }),
                        _BlinkThreshold = 0.0,
                        _BlinkDirection = false,
                        _VariablePath = "LocalPCInfo/CPUUsage",
                        _MaxVariablePath = "100"
                    },
                }),
                new Layer("RAM Usage", new PercentLayerHandler()
                {
                    Properties = new PercentLayerHandlerProperties()
                    {
                        _PrimaryColor =  Color.FromArgb(255, 80, 0),
                        _SecondaryColor = Color.FromArgb(90, 30, 0),
                        _PercentType = PercentEffectType.Progressive_Gradual,
                        _Sequence = new KeySequence(new Devices.DeviceKeys[] {
                            Devices.DeviceKeys.ONE, Devices.DeviceKeys.TWO, Devices.DeviceKeys.THREE, Devices.DeviceKeys.FOUR,
                            Devices.DeviceKeys.FIVE, Devices.DeviceKeys.SIX, Devices.DeviceKeys.SEVEN, Devices.DeviceKeys.EIGHT,
                            Devices.DeviceKeys.NINE, Devices.DeviceKeys.ZERO, Devices.DeviceKeys.MINUS, Devices.DeviceKeys.EQUALS
                        }),
                        _BlinkThreshold = 0.0,
                        _BlinkDirection = false,
                        _VariablePath = "LocalPCInfo/MemoryUsed",
                        _MaxVariablePath = "LocalPCInfo/MemoryTotal"
                    },
                }),
                new Layer("Interactive Layer", new InteractiveLayerHandler()
                {
                    Properties = new InteractiveLayerHandlerProperties()
                    {
                        _InteractiveEffect = InteractiveEffects.Wave_Filled,
                        _PrimaryColor = Color.FromArgb(0, 255, 0),
                        _RandomPrimaryColor = true,
                        _SecondaryColor = Color.FromArgb(255, 0, 0),
                        _RandomSecondaryColor = true,
                        _EffectSpeed = 5.0f,
                        _EffectWidth = 2
                    }
                }
                )
            };
        }
    }
}