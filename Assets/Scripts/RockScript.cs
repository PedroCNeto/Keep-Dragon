using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class RockScript : MonoBehaviour
{
    Dictionary<int, Color> colors = new Dictionary<int, Color>();

    public Image rockImage;

    int maxColor;

    int activeColor = 1;

    void Start()
    {
        colors.Add(1, Color.white);
        colors.Add(2, Color.blue);
        colors.Add(3, Color.green);
        colors.Add(4, Color.red);

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
    }

}
