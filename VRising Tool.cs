using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsInput;
using WindowsInput.Native;

namespace VRising_Tool
{
    public partial class VRising_Tool : Form
    {

        //DLL Imports
        #region DLL Imports
        [DllImport("user32.dll")]
        private static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, uint vk);

        [DllImport("user32.dll")]
        private static extern bool UnregisterHotKey(IntPtr hWnd, int id);

        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, int dx, int dy, uint dwData, int dwExtraInfo);
        #endregion

        //Hotkeys
        #region Hotkeys
        private const int HOTKEY_ID_F1 = 1;
        private const int HOTKEY_ID_F2 = 2;
        private const int HOTKEY_ID_F3 = 3;
        private const int HOTKEY_ID_F4 = 4;
        private const int HOTKEY_ID_F5 = 5;

        private const uint VK_F1 = 0x70;
        private const uint VK_F2 = 0x71;
        private const uint VK_F3 = 0x72;
        private const uint VK_F4 = 0x73;
        private const uint VK_F5 = 0x74;

        private const uint MOUSEEVENTF_RIGHTDOWN = 0x0008;
        private const uint MOUSEEVENTF_RIGHTUP = 0x0010;
        #endregion

        //DataHold
        #region DataHold
        private static string Skill_Key_1;
        private static string Skill_Key_2;
        private static string Skill_Key_3;

        private bool isFormVisible = true;
        #endregion

        InputSimulator isim = new InputSimulator();

        public VRising_Tool()
        {
            InitializeComponent();
        }

        //#######################################//
        //                                       //
        //             WINDOWS FORM              //
        //                                       //
        //#######################################//

        //Form Load/Close
        #region Form Load/Close

        //Load Settings From INI
        private void Form1_Load(object sender, EventArgs e)
        {
            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Settings.ini");

            if (File.Exists(filePath))
            {
                Dictionary<string, string> settings = new Dictionary<string, string>();

                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    if (line.Trim() == "[Settings]")
                    {
                        continue;
                    }

                    string[] parts = line.Split('=');
                    if (parts.Length == 2)
                    {
                        string key = parts[0].Trim();
                        string value = parts[1].Trim();
                        settings[key] = value;
                    }
                    else
                    {
                        Console.WriteLine($"Ungültiges Format: {line}");
                    }
                }

                if (settings.ContainsKey("Skill_Key_1"))
                {
                    Skill_Key_1 = settings["Skill_Key_1"];
                }

                if (settings.ContainsKey("Skill_Key_2"))
                {
                    Skill_Key_2 = settings["Skill_Key_2"];
                }

                if (settings.ContainsKey("Skill_Key_3"))
                {
                    Skill_Key_3 = settings["Skill_Key_3"];
                }
            }
            else
            {
                Console.WriteLine("Die Settings.ini-Datei existiert nicht im Arbeitsverzeichnis.");
            }

            //Save HotKey's
            SkillKey1.Text = Skill_Key_1;
            SkillKey2.Text = Skill_Key_2;
            SkillKey3.Text = Skill_Key_3;

            //Register Hotkey's
            RegisterHotKey(Handle, HOTKEY_ID_F1, 0, VK_F1);
            RegisterHotKey(Handle, HOTKEY_ID_F2, 0, VK_F2);
            RegisterHotKey(Handle, HOTKEY_ID_F3, 0, VK_F3);
            RegisterHotKey(Handle, HOTKEY_ID_F4, 0, VK_F4);
            RegisterHotKey(Handle, HOTKEY_ID_F5, 0, VK_F5);
        }

        //Unregister Hotkey's
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UnregisterHotKey(Handle, HOTKEY_ID_F1);
            UnregisterHotKey(Handle, HOTKEY_ID_F2);
            UnregisterHotKey(Handle, HOTKEY_ID_F3);
            UnregisterHotKey(Handle, HOTKEY_ID_F4);
            UnregisterHotKey(Handle, HOTKEY_ID_F5);
        }
        #endregion

        //Menu
        #region Menu

        //Show and Hide Menu
        private void HideMenuF()
        {
            if (isFormVisible)
            {
                this.Hide();
            }
            else
            {
                this.Show();
            }

            isFormVisible = !isFormVisible;
        }
        #endregion



        //#######################################//
        //                                       //
        //                MACROS                 //
        //                                       //
        //#######################################//

        //Mouse Lock AttackMode
        #region Mouse Lock AttackMode
        private void LockAttackModeF()
        {
            if (CheckLAM.Checked)
            {
                CheckLAM.ForeColor = Color.Red;
                CheckLAM.Checked = false;

                mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
            }
            else
            {
                CheckLAM.ForeColor = Color.LimeGreen;
                CheckLAM.Checked = true;

                int centerX = Screen.PrimaryScreen.Bounds.Width / 2;
                int centerY = Screen.PrimaryScreen.Bounds.Height / 2;
                Cursor.Position = new Point(centerX - 4, centerY - 4);

                mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
            }
        }
        #endregion

        //Skill 1
        #region Skill 1

        //Skill Cooldown
        private void SkillCD1_ValueChanged(object sender, EventArgs e)
        {
            AutoSkill1.Interval = (int)SkillCD1.Value * 1000 + 100;
        }

        //Skill Checkbox
        private void SkillCD1F()
        {
            if (CheckSkill1.Checked)
            {
                CheckSkill1.ForeColor = Color.Red;
                CheckSkill1.Checked = false;
                AutoSkill1.Stop();
            }
            else
            {
                CheckSkill1.ForeColor = Color.LimeGreen;
                CheckSkill1.Checked = true;
                AutoSkill1.Start();
            }
        }

        //Skill Timer
        private void AutoSkill1_Tick(object sender, EventArgs e)
        {
            VirtualKeyCode keyCode = GetVirtualKeyCodeFromString(Skill_Key_1);
            isim.Keyboard.KeyPress(keyCode);
        }
        #endregion

        //Skill 2
        #region Skill 2

        //Skill Cooldown
        private void SkillCD2_ValueChanged(object sender, EventArgs e)
        {
            AutoSkill2.Interval = (int)SkillCD2.Value * 1000 + 100;
        }

        //Skill Checkbox
        private void SkillCD2F()
        {
            if (CheckSkill2.Checked)
            {
                CheckSkill2.ForeColor = Color.Red;
                CheckSkill2.Checked = false;
                AutoSkill2.Stop();
            }
            else
            {
                CheckSkill2.ForeColor = Color.LimeGreen;
                CheckSkill2.Checked = true;
                AutoSkill2.Start();
            }
        }

        //Skill Timer
        private void AutoSkill2_Tick(object sender, EventArgs e)
        {
            VirtualKeyCode keyCode = GetVirtualKeyCodeFromString(Skill_Key_2);
            isim.Keyboard.KeyPress(keyCode);
        }
        #endregion

        //Skill 3
        #region Skill 3

        //Skill Cooldown
        private void SkillCD3_ValueChanged(object sender, EventArgs e)
        {
            AutoSkill3.Interval = (int)SkillCD3.Value * 1000 + 100;
        }

        //Skill Checkbox
        private void SkillCD3F()
        {
            if (CheckSkill3.Checked)
            {
                CheckSkill3.ForeColor = Color.Red;
                CheckSkill3.Checked = false;
                AutoSkill3.Stop();
            }
            else
            {
                CheckSkill3.ForeColor = Color.LimeGreen;
                CheckSkill3.Checked = true;
                AutoSkill3.Start();
            }
        }

        //Skill Timer
        private void AutoSkill3_Tick(object sender, EventArgs e)
        {
            VirtualKeyCode keyCode = GetVirtualKeyCodeFromString(Skill_Key_3);
            isim.Keyboard.KeyPress(keyCode);
        }
        #endregion



        //#######################################//
        //                                       //
        //          KEY REG/UNREG_ISTER          //
        //                                       //
        //#######################################//

        //Key
        #region Key
        private VirtualKeyCode GetVirtualKeyCodeFromString(string key)
        {
            Keys keys;
            if (Enum.TryParse(key, true, out keys))
            {
                return (VirtualKeyCode)keys;
            }
            else
            {
                return VirtualKeyCode.NONAME;
            }
        }
        #endregion

        //KeyRegister
        #region KeyRegister
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == 0x0312)
            {
                int hotkeyId = m.WParam.ToInt32();
                switch (hotkeyId)
                {
                    case HOTKEY_ID_F1:
                        HideMenuF();
                        break;
                    case HOTKEY_ID_F2:
                        LockAttackModeF();
                        break;
                    case HOTKEY_ID_F3:
                        SkillCD1F();
                        break;
                    case HOTKEY_ID_F4:
                        SkillCD2F();
                        break;
                    case HOTKEY_ID_F5:
                        SkillCD3F();
                        break;
                }
            }
        }
        #endregion

    }
}
