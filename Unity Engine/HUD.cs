using UnityEngine;

class HUD : MonoBehaviour
{
    public Texture2D heart;
    public Texture2D lifeBar;
    private int maxHP = 300;
    public int hp;
    public int numberOfKeys = 0;

    public void Start()
    {
        hp = maxHP;
    }

    public void OnGUI()
    {
        for (int i = 0; i < numberOfKeys; i++)
        {
            GUI.DrawTexture(new Rect(10 + i * (heart.width + 10), 10, heart.width, heart.height), heart);
        }

        if (hp > 0)
        {
            GUI.BeginGroup(new Rect(10, Screen.height * 0.8F, hp, 50));
            GUI.DrawTexture(new Rect(0, 0, maxHP, 50), lifeBar);
            GUI.EndGroup();
        }
    }



}
