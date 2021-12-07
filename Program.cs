using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Win32;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RegistryKey key = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
            RegistryKey key1 = key.OpenSubKey($@"SOFTWARE\Task_Queue\Claims");
            key1.SetValue("Task_1111", null, Microsoft.Win32.RegistryValueKind.QWord);
            key.Close();
            Console.WriteLine("Success!!!");
        }
        void CreateValue(string ValueName, string Folder)
        {
            
        }
    }
}
