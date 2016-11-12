using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MasterText : MonoBehaviour {
    public DialogueNode opening;   // 0
    public DialogueNode what;      // 1
    public DialogueNode whoIsThat; // 2

    //from what
    public DialogueNode whoAreYou;
    public DialogueNode WaitMe;

    Dictionary<string, DialogueNode> MasterKey;

    //from both whoAreYou and WaitMe
    // Use this for initialization
    void Start () {
        MasterKey = new Dictionary<string, DialogueNode>();
        //from openning
        opening = new DialogueNode("Hello, is anybody there?", 2);
        what = new DialogueNode("Oh good I found you! Sorry for startling you, I've just been looking for you for a while now.", 2);
        whoIsThat = new DialogueNode("Ah ha! I found you! I have been looking everywhere for you! Who I am doesn't matter right now, I am here to get the hell out of here!", 2);
        opening.setOptions(what, whoIsThat);
        MasterKey.Add("opening", opening);

        //from what
        whoAreYou = new DialogueNode("Right now that doesn't really matter, all you need to know is that I am a friend who is concerned about your well being and is here to help you see the world that you must want to see? I am right, right? You must be ready to see this huge world and take it by surprise right? If you listen to me and do what I say I can get you out of here. You ready?", 1);
        WaitMe = new DialogueNode("Yeah little buddy! I've been looking for you for a while now and I finally found you. You ready to see the big world out there? If you follow what I tell you I can get you out of here and see all there is to see. Meet new people, exchange ideas, what do you say?", 1);
        what.setOptions(whoAreYou, WaitMe);
        MasterKey.Add("whoAreYou", whoAreYou);
    }

    public DialogueNode GetNode(string key)
    {
        return MasterKey[key];
    }
}
