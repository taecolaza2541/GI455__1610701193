using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WebSocketSharp;
using UnityEngine.UI;
using TMPro;

public class week2 : MonoBehaviour
{
    private WebSocket websocket;
    public InputField chatwords;
    public Text testsend;
    public Text testmessage;
    string returnchat;
    int send;
    // Start is called before the first frame update
    void Start()
    {
        websocket = new WebSocket("ws://127.0.0.1:25500/");
        websocket.OnMessage += OnMessage;
        websocket.Connect();
    }
    // Update is called once per frame
    void Update()
    {
    }
    public void OnDestroy()
    {
        if (websocket != null)
        {
            websocket.Close();
        }
    }
    public void OnMessage(object sender, MessageEventArgs messageEventArgs)
    {
        returnchat = messageEventArgs.Data;
        resaltformserver();
    }
    public void sendmessage()
    {
        websocket.Send(chatwords.text);
        testsend.text += ("\r\n" + chatwords.text);
        send = 1;
    }
    public void resaltformserver()
    {
        if (send > 0)
        {
            testmessage.text += ("\r\n");
            send = 0;
        }
        else if (send < 1)
        {
            testmessage.text += ("\r\n" + returnchat);
            testsend.text += ("\r\n");
        }
    }
}

