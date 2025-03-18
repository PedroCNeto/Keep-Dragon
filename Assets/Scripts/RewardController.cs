using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RewardController : MonoBehaviour
{
    Dictionary<int, Color> colors = new Dictionary<int, Color>();

    public Image rockImage;

    public Image[] fireImages;

    int maxColor;

    int activeColor = 1;

    void Start()
    {
        colors.Add(1, new Color(252f / 255f, 127f / 255f, 3f / 255f));   // Laranja
        colors.Add(2, new Color(252f / 255f, 223f / 255f, 3f / 255f));   // Amarelo
        colors.Add(3, new Color(255f / 255f, 255f / 255f, 255f / 255f)); // Branco
        colors.Add(4, new Color(0f / 255f, 175f / 255f, 181f / 255f));   // Azul turquesa
        colors.Add(5, new Color(21f / 255f, 61f / 255f, 207f / 255f));   // Azul escuro

        setNewColor();
        maxColor = colors.Count;
    }


    void Update()
    {

    }

    public void progressColor()
    {
        if(activeColor < maxColor)
        {
            activeColor += 1;
        }
        setNewColor();
    }

    public void decreaseColor()
    {
        if(activeColor > 1)
        {
            activeColor -= 1;
        }
        setNewColor();
    }

    void setNewColor()
    {
        rockImage.color = colors[activeColor];
    
        foreach(Image i in fireImages)
        {
            i.color = colors[activeColor];
        }
    }

}
