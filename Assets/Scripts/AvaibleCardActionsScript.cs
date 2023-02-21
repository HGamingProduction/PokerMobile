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

public class AvaibleCardActionsScript : MonoBehaviour
{
    public GameObject BestCardCombinationPokcet;
    public GameObject BestCardCombinationPokcetClone;
    public GameObject BestCardCombinationBoard1;
    public GameObject BestCardCombinationBoard2;
    public GameObject BestCardCombinationBoard3;
    public GameObject BestCardCombinationBoard4;
    public GameObject BestCardCombinationBoard5;
    public static int test;
    public static int test2;

    // Start is called before the first frame update
    void Start()
    {

       
    }

    // Update is called once per frame
    void Update()
    {

       


         if (JoinTable.GlobalCardAction == "FirstException")
         {
             
             BestCardCombinationPokcet.gameObject.SetActive(false);
             BestCardCombinationPokcetClone.gameObject.SetActive(false);
             BestCardCombinationBoard1.gameObject.SetActive(false);
             BestCardCombinationBoard2.gameObject.SetActive(false);
             BestCardCombinationBoard3.gameObject.SetActive(false);
             BestCardCombinationBoard4.gameObject.SetActive(false);
             BestCardCombinationBoard5.gameObject.SetActive(false);


         } else
        {


           
        }
 



        if (JoinTable.GlobalCardAction == "MyCardActionOneClone")
        {

            BestCardCombinationPokcetClone.gameObject.SetActive(true);
            test = 1;
        }
       
       if (JoinTable.GlobalCardAction == "MyCardActionOne")
        {

            BestCardCombinationPokcet.gameObject.SetActive(true);
            test = 2;
        }
      
       if (JoinTable.GlobalCardAction == "CardActionOne")
        {

            BestCardCombinationBoard1.gameObject.SetActive(true);
            test = 3;
        }

        
        if (JoinTable.GlobalCardAction == "CardActionTwo")
        {

            BestCardCombinationBoard2.gameObject.SetActive(true);
            test = 4;
        }
   
        if (JoinTable.GlobalCardAction == "CardActionThree")
        {

            BestCardCombinationBoard3.gameObject.SetActive(true);
            test = 5;
        }
    
        if (JoinTable.GlobalCardAction == "CardActionFour")
        {

            BestCardCombinationBoard4.gameObject.SetActive(true);
            test = 6;
        }
       
        if (JoinTable.GlobalCardAction == "CardActionFive")
        {

            BestCardCombinationBoard5.gameObject.SetActive(true);
            test = 7;
        }
       
            







        if (JoinTable.GlobalCardAction2 == "MyCardActionOne2Clone")
        {

            BestCardCombinationPokcetClone.gameObject.SetActive(true);
            test2 = 1;
        }
       
       if (JoinTable.GlobalCardAction2 == "MyCardActionOne2")
        {

            BestCardCombinationPokcet.gameObject.SetActive(true);
            test2 = 2;
        }
        
        if (JoinTable.GlobalCardAction2 == "CardActionOne2")
        {

            BestCardCombinationBoard1.gameObject.SetActive(true);
            test2 = 3;
        }
     
         if (JoinTable.GlobalCardAction2 == "CardActionTwo2")
        {

            BestCardCombinationBoard2.gameObject.SetActive(true);
            test2 = 4;
        }
      
         if (JoinTable.GlobalCardAction2 == "CardActionThree2")
        {

            BestCardCombinationBoard3.gameObject.SetActive(true);
            test2 = 5;
        }
    
         if (JoinTable.GlobalCardAction2 == "CardActionFour2")
        {

            BestCardCombinationBoard4.gameObject.SetActive(true);
            test2 = 6;
        }
     
         if (JoinTable.GlobalCardAction2 == "CardActionFive2")
        {

            BestCardCombinationBoard5.gameObject.SetActive(true);
            test2 = 7;
        }








        if (JoinTable.GlobalCardAction3 == "MyCardActionOneClone3")
        {

            BestCardCombinationPokcetClone.gameObject.SetActive(true);
            test2 = 1;
        }

        if (JoinTable.GlobalCardAction3 == "MyCardActionOne3")
        {

            BestCardCombinationPokcet.gameObject.SetActive(true);
            test2 = 2;
        }

        if (JoinTable.GlobalCardAction3 == "CardActionOne3")
        {

            BestCardCombinationBoard1.gameObject.SetActive(true);
            test2 = 3;
        }

        if (JoinTable.GlobalCardAction3 == "CardActionTwo3")
        {

            BestCardCombinationBoard2.gameObject.SetActive(true);
            test2 = 4;
        }

        if (JoinTable.GlobalCardAction3 == "CardActionThree3")
        {

            BestCardCombinationBoard3.gameObject.SetActive(true);
            test2 = 5;
        }

        if (JoinTable.GlobalCardAction3 == "CardActionFour3")
        {

            BestCardCombinationBoard4.gameObject.SetActive(true);
            test2 = 6;
        }

        if (JoinTable.GlobalCardAction3 == "CardActionFive3")
        {

            BestCardCombinationBoard5.gameObject.SetActive(true);
            test2 = 7;
        }







        if (JoinTable.GlobalCardAction4 == "MyCardActionOneClone4")
        {

            BestCardCombinationPokcetClone.gameObject.SetActive(true);
            test2 = 1;
        }

        if (JoinTable.GlobalCardAction4 == "MyCardActionOne4")
        {

            BestCardCombinationPokcet.gameObject.SetActive(true);
            test2 = 2;
        }

        if (JoinTable.GlobalCardAction4 == "CardActionOne4")
        {

            BestCardCombinationBoard1.gameObject.SetActive(true);
            test2 = 3;
        }

        if (JoinTable.GlobalCardAction4 == "CardActionTwo4")
        {

            BestCardCombinationBoard2.gameObject.SetActive(true);
            test2 = 4;
        }

        if (JoinTable.GlobalCardAction4 == "CardActionThree4")
        {

            BestCardCombinationBoard3.gameObject.SetActive(true);
            test2 = 5;
        }

        if (JoinTable.GlobalCardAction4 == "CardActionFour4")
        {

            BestCardCombinationBoard4.gameObject.SetActive(true);
            test2 = 6;
        }

        if (JoinTable.GlobalCardAction4 == "CardActionFive4")
        {

            BestCardCombinationBoard5.gameObject.SetActive(true);
            test2 = 7;
        }


    }
}
