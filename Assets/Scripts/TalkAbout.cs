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

    public void TalkAbout4()
    {
       inputField.text = "The psychology of happiness: Investigating the science " +
                         "behind happiness, well-being, and positive psychology interventions.";
    }
    
    public void TalkAbout5()
    {
        inputField.text = "Space exploration and colonization: Discussing recent advancements in" +
                          " space travel, plans for establishing human colonies on other planets," +
                          " and the potential future of interstellar travel";
    }
    
    public void TalkAbout6()
    {
        inputField.text = "Genetic engineering and gene editing: Delving into the " +
                          "possibilities and ethical implications of gene-editing " +
                          "technologies like CRISPR-Cas9.";
    }
    
    public void SoWhat()
    {
        inputField.text = "So what? Why does that matter?";
    }
    public void Elaborate()
    {
        inputField.text = "In one sentence, please elaborate and continue on what you are talking about";
    }
    
    public void Explain()
    {
        inputField.text = "In one sentence, please explain and continue in simple terms what you are talking about";
    }
    
    public void GoBack()
    {
        inputField.text = "In one sentence, please go back to and continue what you just previous said before you just said this";
    }


}
