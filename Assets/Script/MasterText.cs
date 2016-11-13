using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterText : MonoBehaviour {

    Dictionary<string, DialogueNode> MasterKey;
    //opening
    DialogueNode voice1_1 = new DialogueNode("Hello, is anybody there?", 2);
    DialogueNode response1_1 = new DialogueNode("What?", 1);
    DialogueNode response1_2 = new DialogueNode("Who is that?", 1);

    DialogueNode voice1_2 = new DialogueNode("Oh good I found you! Sorry for startling you, I've just been looking for you for a while now.", 2);
    DialogueNode response2_1 = new DialogueNode("Who are you?", 1);
    DialogueNode response2_2 = new DialogueNode("Wait, looking for me?", 1);

    DialogueNode voice1_3 = new DialogueNode("Ah ha! I found you! I have been looking everywhere for you! Who I am doesn't matter right now, I am here to get the hell out of here!", 2);
    DialogueNode response3_1 = new DialogueNode("Wait, looking for me?", 1);
    // reponse2_2

    DialogueNode voice1_4 = new DialogueNode("Right now that doesn't really matter, all you need to know is that I am a friend who is concerned about your well being and is here to help you see the world that you must want to see? I am right, right? You must be ready to see this huge world and take it by surprise right? If you listen to me and do what I say I can get you out of here. You ready?", 1);
    DialogueNode response4_1 = new DialogueNode("Ok, lets do this", 1);

    DialogueNode voice1_5 = new DialogueNode("Yeah little buddy! I've been looking for you for a while now and I finally found you. You ready to see the big world out there? If you follow what I tell you I can get you out of here and see all there is to see. Meet new people, exchange ideas, what do you say?", 1);
    //response4_1

    DialogueNode voice1_6 = new DialogueNode("TaDa! With the magic that is me this door is now like peanutbutter on a shelve, a jar!", 2);
    DialogueNode response5_1 = new DialogueNode("Really? A pun", 1);
    DialogueNode response5_2 = new DialogueNode("Just walk through the door", 1);

    DialogueNode voice1_7 = new DialogueNode("Sorry, I get a little nervous at times. Puns make me feel a little more at ease. I'll try my best to not do AS many as them", 0);

    DialogueNode voice1_8 = new DialogueNode("OK now you need to turn left and walk down this hallway, there is an elevator there, press the button.", 0);

    //at the elevator
    DialogueNode response6_1 = new DialogueNode("Press the button", 1);
    DialogueNode response6_2 = new DialogueNode("HIT THE BUTTON", 1);

    DialogueNode voice1_9 = new DialogueNode("Was that really nessary?", 2);
    DialogueNode response7_1 = new DialogueNode("Yes, absolutely.", 1);
    DialogueNode response7_2 = new DialogueNode("Yes.", 1);
    DialogueNode response7_3 = new DialogueNode("Maybe", 1);
    DialogueNode response7_4 = new DialogueNode("No, but it was fun.", 1);

    DialogueNode voice1_10 = new DialogueNode("Um, ok then. I guess that's fair", 0);
    DialogueNode voice1_11 = new DialogueNode("Alrighty then, now we wait for the door.", 0);
    DialogueNode voice1_12 = new DialogueNode("Ok, if you say so  buddy.", 0);
    DialogueNode voice1_13 = new DialogueNode("Um, ok then.", 0);

    DialogueNode voice1_14 = new DialogueNode("Yeah it is. There are probably a lot of floors in this building OR the elevator is slow to make sure that there isn't a lot of ware on the cables.", 1);
    DialogueNode soundEffect = new DialogueNode("Bing!", 1);
    DialogueNode voice1_15 = new DialogueNode("Oh here it is. Go in and press the button for the first floor, it'll get us right out of here.", 3);
    DialogueNode response8_1 = new DialogueNode("Press the first floor button", 1);
    DialogueNode response8_2 = new DialogueNode("Why not any other floor", 1);



    // Use this for initialization
    void Start () {
        MasterKey = new Dictionary<string, DialogueNode>();
        //from openning

    }

    public DialogueNode GetNode(string key)
    {
        return MasterKey[key];
    }
}
