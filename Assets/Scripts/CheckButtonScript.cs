using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WebSocketSharp;
using UnityEngine.UI;
using Newtonsoft.Json;
using System.Net.Http;
using UnityEngine.SceneManagement;


public class CheckButtonScript : MonoBehaviour
{
    public static string res;
    private static void Ws_OnMessage(object sender, MessageEventArgs e)
    {
        Debug.Log("CheckOpen: " + e.Data);
        res = e.Data;
        var currency111 = JsonConvert.DeserializeObject<RootAction>(res);


        if (currency111.eventType == "end_game")
        {

            string? ioi = currency111.msg;
            Debug.Log(ioi);
            JoinTable.WinsMessage = Convert.ToString(ioi);
           



        }

    }

    public async void CheckTableAction()
    {
        WebSocket ws = new WebSocket(Glob.websocketurl);

        ws.OnMessage += Ws_OnMessage;

        ws.Connect();

        var jsona = new CheckTableAssetsMain
        {
            eventType = "action",
            action = new CheckTableAssetsMain { type = "check" }
        };

        string message = JsonConvert.SerializeObject(jsona);

        ws.Send(message);


    }








}
public class CheckTableAssets
{

    public new CheckTableAssetsMain action { get; set; }

}
public class CheckTableAssetsMain : CheckTableAssets
{
    public string eventType { get; set; }

    public string type { get; set; }




}
public class BestCombination
{
    public List<string> cards { get; set; }
    public string name { get; set; }
}

public class GameAction
{
    public int id { get; set; }
    public int pokerTableId { get; set; }
    public string state { get; set; }
    public List<string> board { get; set; }
    public int bank { get; set; }
}

public class RootAction
{
    public string eventType { get; set; }
    public string msg { get; set; }
    public GameAction game { get; set; }
    public List<Winner> winners { get; set; }
}

public class Winner
{
    public BestCombination bestCombination { get; set; }
    public int userId { get; set; }
    public int chips { get; set; }
}