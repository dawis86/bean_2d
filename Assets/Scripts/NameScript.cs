using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class NameScript : MonoBehaviour
{
    private string text;
    private string[] sampleText = {"Hello", "Have a nice day", "Nice to see you", 
    "Look what's here", "Goodbye"};
    int randomIx;
    public TMP_InputField inputField;
    public TMP_Text outputField;
    public Toggle reverseTextToggle;

    public void GetText() {
        randomIx = Random.Range(0, sampleText.Length);
        text = inputField.text;
        outputField.text = sampleText[randomIx] + " " + text.ToUpper() + "!";
        
        reverseTextToggle.interactable = true;

        if(reverseTextToggle.isOn) {
            ReverseText();
        }
    }

    public void ReverseText() {
        char[] charArray = outputField.text.ToCharArray();
        System.Array.Reverse(charArray);
        outputField.text = new string(charArray);
    }

}
