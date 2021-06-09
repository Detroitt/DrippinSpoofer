using System;
using System.Text;
using Microsoft.Win32;

namespace HWIDSpoofer
{
    class Spoofer
    {
        public static class HWID
        {
            public static Regedit regeditOBJ = new Regedit(@"SYSTEM\CurrentControlSet\Control\IDConfigDB\Hardware Profiles\0001");
            public static readonly string Key = "HwProfileGuid";

            public static string GetValue()
            {
                return regeditOBJ.Read(Key);
            }

            public static bool SetValue(object value)
            {
                return regeditOBJ.Write(Key, value);
            }

            public static StringBuilder Log = new StringBuilder();
            public static bool Spoof()
            {
                Log.Clear();
                string oldValue = GetValue();
                bool result =  SetValue("{" + Guid.NewGuid().ToString() + "}");
                if (result)
                {
                    Log.Append("  [DRIPPIN] Old HWID " + oldValue + " New HWID " + GetValue());
                }
                else
                {
                    Log.AppendLine("  [DRIPPIN] Error! Pls run as admin!");
                }
                return result;
            }
        }

        public static class PCGuid
        {
            public static Regedit regeditOBJ = new Regedit(@"SOFTWARE\Microsoft\Cryptography");
            public static readonly string Key = "MachineGuid";

            public static string GetValue()
            {
                return regeditOBJ.Read(Key);
            }

            public static bool SetValue(object value)
            {
                return regeditOBJ.Write(Key, value);
            }

            public static StringBuilder Log = new StringBuilder();
            public static bool Spoof()
            {
                Log.Clear();
                string oldValue = GetValue();
                bool result = SetValue(Guid.NewGuid().ToString());
                if (result)
                {
                    Log.Append("  [DRIPPIN] OLD GUID " + oldValue + " NEW GUID " + GetValue());
                }
                else
                {
                    Log.AppendLine("  [DRIPPIN] Error! Pls run as admin!");
                }
                return result;
            }
        }

        public static class PCName
        {
            public static Regedit regeditOBJ = new Regedit(@"SYSTEM\CurrentControlSet\Control\ComputerName\ActiveComputerName");
            public static readonly string Key = "ComputerName";

            public static string GetValue()
            {
                return regeditOBJ.Read(Key);
            }

            public static bool SetValue(object value)
            {
                return regeditOBJ.Write(Key, value);
            }

            public static StringBuilder Log = new StringBuilder();
            public static bool Spoof()
            {
                Log.Clear();
                string oldValue = GetValue();
                bool result = SetValue("DESKTOP-" + Utilities.GenerateString(15));
                if (result)
                {
                    Log.Append("  [DRIPPIN] OLD Computer Name  " + oldValue + " NEW Computer Name " + GetValue());
                }
                else
                {
                    Log.AppendLine("  [DRIPPIN] Error! Pls Run As Admin!");
                }
                return result;
            }
        }

        public static class ProductId
        {
            public static Regedit regeditOBJ = new Regedit(@"SOFTWARE\\Microsoft\\Windows NT\\CurrentVersion");
            public static readonly string Key = "ProductID";

            public static string GetValue()
            {
                return regeditOBJ.Read(Key);
            }

            public static bool SetValue(object value)
            {
                return regeditOBJ.Write(Key, value);
            }

            public static StringBuilder Log = new StringBuilder();
            public static bool Spoof()
            {
                Log.Clear();
                string oldValue = GetValue();
                bool result = SetValue(Utilities.GenerateString(5) + "-" + Utilities.GenerateString(5) + "-" + Utilities.GenerateString(5) + "-" + Utilities.GenerateString(5));
                if(result)
                {
                    Log.AppendLine("  [DRIPPIN] OLD Computer ProductID  " + oldValue + " NEW Computer ProductID " + GetValue());
                }
                else
                {
                    Log.AppendLine("  [DRIPPIN] Error! Pls Run As Admin!");
                }
                return result;
            }
        }

        public class Regedit
        {
            private string regeditPath = string.Empty;
            public Regedit(string regeditPath)
            {
                this.regeditPath = regeditPath;
            }

            public string Read(string keyName)
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regeditPath))
                    {
                        if (key != null)
                        {
                            return key.GetValue(keyName).ToString();
                        }
                        else
                        {

                            return "ERR";
                        }
                    }
                }
                catch 
                {

                    return "ERR";
                }
            }

            public bool Write(string keyName, object value)
            {
                try
                {
                    using (RegistryKey key = Registry.LocalMachine.OpenSubKey(regeditPath))
                    {
                        if (key != null)
                        {
                            key.SetValue(keyName, value);
                            return true;
                        }
                        else
                        {

                            return false;
                        }
                    }
                }
                catch 
                {

                    return false;
                }
            }
        }

        public static class Utilities
        {
            private static Random rand = new Random();
            public const string Alphabet = "ABCDEF0123456789";
            private static Random random = new Random();
            public const string Alphabet1 = "abcdef0123456789";

            public static string GenerateString(int size)
            {
                char[] array = new char[size];
                for (int i = 0; i < size; i++)
                {
                    array[i] = Alphabet[rand.Next(Alphabet.Length)];
                }
                return new string(array);
            }
        }
    }
}
