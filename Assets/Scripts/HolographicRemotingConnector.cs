using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.WSA;

public class HolographicRemotingConnector : MonoBehaviour
{
    public string IP="192.168.3.56";

    private bool connected;

    public void Connect()
    {
        if (HolographicRemoting.ConnectionState != HolographicStreamerConnectionState.Connected)
        {
            HolographicRemoting.Connect(IP);
        }
    }

    void Update()
    {
        if (!connected && HolographicRemoting.ConnectionState == HolographicStreamerConnectionState.Connected)
        {
            connected = true;

            StartCoroutine(LoadDevice("WindowsMR"));
        }

        if (Input .GetKeyDown (KeyCode .Q))
            Connect();
    }

    IEnumerator LoadDevice(string newDevice)
    {
        XRSettings.LoadDeviceByName(newDevice);
        yield return null;
        XRSettings.enabled = true;
    }
}
