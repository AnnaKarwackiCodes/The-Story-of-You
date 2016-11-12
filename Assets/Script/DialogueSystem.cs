using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class DialogueSystem : MonoBehaviour {

    GameObject canvas;
    GameObject optionPrefab;
    GameObject options;
    GameObject textBoxPrefab;
    GameObject textBox;
    DialogueNode currentNode; //current story node
    RectTransform canSize;
    
    bool showText = false;
    bool showOptions = false;

	// Use this for initialization
	void Awake () {
        canvas = GameObject.Find("Dialogue HUD");
        optionPrefab = Resources.Load<GameObject>("Dialogue Stuff/Response Answers");
        textBoxPrefab = Resources.Load<GameObject>("Dialogue Stuff/TextBox");
        canSize = canvas.GetComponent<RectTransform>();

        options = Instantiate(optionPrefab);
        options.transform.SetParent(canvas.transform);
        options.transform.localPosition = new Vector3(0, 0, 0);
        options.SetActive(false);

        textBox = Instantiate(textBoxPrefab);
        textBox.transform.SetParent(canvas.transform);
        textBox.transform.localPosition = new Vector3(0.0f, -canSize.rect.height/2 + (textBox.GetComponent<RectTransform>().rect.height * .15f), 0.0f);
        textBox.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	}

    void getOptionsReady()
    {
        if(currentNode.OptNum > 0)
        {
            DialogueNode[] temp = currentNode.Options;
            options.SetActive(true);
            for(int i = 0; i < 4; i++)
            {
                if(i < currentNode.OptNum)
                {
                    options.transform.GetChild(i).GetChild(0).GetComponent<Text>().text = temp[i].GetPrompt;
                }
            }
        }
    }
    IEnumerator OptionsAppear() //to use this need to calle the method with StartCoroutine
    {
        yield return new WaitForSeconds(4);
    }
    public bool ShowText
    {
        get { return showText; }
        set { textBox.SetActive(value); }
    }
    public bool ShowOptions
    {
        get { return showOptions; }
        set
        {
            textBox.SetActive(value);
        }
    }

    public string SetTextBox
    {
        set
        {
            textBox.transform.GetChild(0).GetComponent<Text>().text = value;
        }
    }
}
