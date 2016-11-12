using UnityEngine;
using System.Collections;

public class DialogueSystem : MonoBehaviour {

    GameObject canvas;
    GameObject optionPrefab;
    GameObject options;
    GameObject textBoxPrefab;
    GameObject textBox;
    DialogueNode currentNode; //current story node
	// Use this for initialization
	void Start () {
        canvas = GameObject.Find("Dialogue HUD");
        optionPrefab = Resources.Load<GameObject>("Dialogue Stuff/Response Answers");
        textBoxPrefab = Resources.Load<GameObject>("Dialogue Stuff/TextBox");

        options = Instantiate(optionPrefab);
        options.transform.SetParent(canvas.transform);
        options.transform.localPosition = new Vector3(0, 0, 0);
        textBox = Instantiate(textBoxPrefab);
        textBox.transform.SetParent(canvas.transform);
        textBox.transform.localPosition = new Vector3(9, -150, 0);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
