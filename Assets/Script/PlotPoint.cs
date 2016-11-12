using UnityEngine;
using System.Collections;

public class PlotPoint : MonoBehaviour {
    DialogueNode startingNode;
    GameObject player;
    float maxDistance = 1.0f;
    GameObject WO;

    public string Point;

	// Use this for initialization
	void Start () {
        player = GameObject.Find("FPSController");
        WO = GameObject.Find("WorldObject");
        WO.GetComponent<DialogueSystem>().ShowText = false;
        WO.GetComponent<DialogueSystem>().ShowOptions = false;
        WO.GetComponent<DialogueSystem>().CurrentNode = WO.GetComponent<MasterText>().GetNode(Point);
        WO.GetComponent<DialogueSystem>().SetTextBox = WO.GetComponent<DialogueSystem>().CurrentNode.GetPrompt;
    }
	
	// Update is called once per frame
	void Update () {
        float distance = getDistance();
        inProx(distance);
	}

    float getDistance()
    {
        //sqrt((x2-x1)^2+(y2-y1)^2)
        float distance = Mathf.Sqrt(Mathf.Pow((player.transform.position.x - this.transform.position.x), 2) + Mathf.Pow((player.transform.position.z - this.transform.position.z), 2));
        return distance;
    }

    void inProx(float distance)
    {
        if (distance <= maxDistance)
        {
            WO.GetComponent<DialogueSystem>().ShowText = true;
        }
    }
}
