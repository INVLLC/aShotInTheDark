using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Animations;    

public class CheckDistance : MonoBehaviour
{

    [SerializeField] private Transform Location;
    private Animator anim;
    [SerializeField]private GameObject ChatBubble;
    //serialized private missionText
    [SerializeField]private Text missionText;


    //start func
    void Start()
    {
        //get the aniamtor fromt he chat bubble
        anim = ChatBubble.GetComponent<Animator>();

        
    }

    //caluclate the distance between the player and the location
    private void Update()
    {
        float distance = Vector3.Distance(transform.position, Location.position);
        //if the distance is less than 5
        if (distance < 5)
        {
            ChatBubbleShow();
        } else if (distance > 5)
        {
            ChatBubbleHide();
        }
    }

    //make a function that check if the player is less than 5 units away from the location and if so set the bool of "ChatBubbleShow" to true if not set it to false animation only 1 time
    private void ChatBubbleShow ()
    {
        anim.SetBool("ChatBubbleShow", true);
        MissionText();
    }

    private void ChatBubbleHide ()
    {
        anim.SetBool("ChatBubbleShow", false);
    }

    //new func called missionText
    private void MissionText ()
    {
        //set the mission text to "Hello this is a mission text"
     

    }
}
