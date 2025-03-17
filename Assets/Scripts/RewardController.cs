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
        colors.Add(1, new Color(252, 127, 3));
        colors.Add(2, new Color(252, 223, 3));
        colors.Add(3, new Color(255, 255, 255));
        colors.Add(4, new Color(0, 175, 181));
        colors.Add(5, new Color(21, 61, 207));

        setNewColor();
        maxColor = colors.Count();

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
