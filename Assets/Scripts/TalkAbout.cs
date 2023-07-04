using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TalkAbout : MonoBehaviour
{
    [SerializeField] private InputField inputField;

    public void TalkAbout1()
    {
        inputField.text= "The future of artificial intelligence: " +
                         "Exploring the potential impacts, challenges, and ethical considerations of advancing AI technologies";
    }

    public void TalkAbout2()
    {
        inputField.text = "Climate change and sustainable solutions: " +
                          "Examining the urgent need for action, renewable energy sources, and global efforts to combat climate change";
    }

    public void TalkAbout3()
    {
        inputField.text = "The rise of extended reality: " +
                          "Analyzing the applications, benefits, and potential risks of XR technology in various fields, " +
                          "such as gaming, education, and healthcare.";
    }
    
    public void Elaborate()
    {
        inputField.text = "Please elaborate on what you are talking about";
    }
    
    public void Explain()
    {
        inputField.text = "Please explain in simple terms what you are talking about";
    }
    
    public void GoBack()
    {
        inputField.text = "Please go back to what you just previous said before you just said this";
    }


}
