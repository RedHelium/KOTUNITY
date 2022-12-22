

using System;
using UnityEngine;

namespace KOT.System
{
    public class UserInfoEntity : MonoBehaviour
    {
        private UserInformation userInformation;

        [Serializable]
        struct UserInformation
        {
            public string OS;
            public string processorType;
            public int processorFrequency;
            public int processorCount;
            public int systemMemorySize;
            public string deviceName;
            public string deviceModel;
            public bool supportAudio;
            public int graphicsMemorySize;
            public string graphicsDeviceName;
            
            public override string ToString()
            => $"OS: {OS}\nProcessor Type: {processorType}\nProcessor Frequency: {processorFrequency}\nProcessor Count: {processorCount}\n" +
            $"Memory Size: {systemMemorySize}\nDevice Name: {deviceName}\nDevice Model: {deviceModel}\nSupport Audio: {supportAudio}\n" +
            $"Graphic memory size: {graphicsMemorySize}\nGraphic device name: {graphicsDeviceName}";
        }

        private void Awake()
        {
            InitUserInformation();  
        }
        private void InitUserInformation()
        {
            //TODO If user config file not exists else return
            userInformation = new UserInformation();
            userInformation.OS = SystemInfo.operatingSystem;
            userInformation.processorType = SystemInfo.processorType;
            userInformation.processorFrequency = SystemInfo.processorFrequency;
            userInformation.processorCount = SystemInfo.processorCount;
            userInformation.systemMemorySize = SystemInfo.systemMemorySize;
            userInformation.deviceName = SystemInfo.deviceName;
            userInformation.deviceModel = SystemInfo.deviceModel;
            userInformation.supportAudio = SystemInfo.supportsAudio;
            userInformation.graphicsMemorySize = SystemInfo.graphicsMemorySize;
            userInformation.graphicsDeviceName = SystemInfo.graphicsDeviceName;
        }
    }
}