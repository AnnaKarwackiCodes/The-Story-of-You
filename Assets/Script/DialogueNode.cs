using UnityEngine;
using System.Collections;

public class DialogueNode {
    string Prompt; // voice response to what you say or you respond to what they say
    DialogueNode[] options; // things that you can say
    int optNum;

    public DialogueNode(string p, int num)
    {
        Prompt = p;
        optNum = num;
        if(num > 0)
        {
            options = new DialogueNode[num];
        }
    }

    public string GetPrompt
    {
        get { return Prompt; }
    }

    public DialogueNode[] Options
    {
        get { return options; }
    }
    public void setOptions(DialogueNode o1)
    {
        options[0] = o1;
    }
    public void setOptions(DialogueNode o1, DialogueNode o2)
    {
        options[0] = o1;
        options[1] = o2;
    }
    public void setOptions(DialogueNode o1, DialogueNode o2, DialogueNode o3)
    {
        options[0] = o1;
        options[1] = o2;
        options[2] = o3;
    }
    public void setOptions(DialogueNode o1, DialogueNode o2, DialogueNode o3, DialogueNode o4)
    {
        options[0] = o1;
        options[1] = o2;
        options[2] = o3;
        options[3] = o4;
    }
}
