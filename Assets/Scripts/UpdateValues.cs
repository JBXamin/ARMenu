using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UpdateValues : MonoBehaviour
{
    int calories = 0;
    int protien = 0;
    int fat = 0;
    int carbs = 0;
    int fiber = 0;
    int sodium = 0;
    public TMP_Text c;
    public TMP_Text p;
    public TMP_Text f;
    public TMP_Text ca;
    public TMP_Text fi;
    public TMP_Text s;
    void Start()
    {
        c.text = calories.ToString();
        p.text = protien.ToString();
        f.text = fat.ToString();
        ca.text = carbs.ToString();
        fi.text = fiber.ToString();
        s.text = sodium.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        c.text = calories.ToString();
        p.text = protien.ToString();
        f.text = fat.ToString();
        ca.text = carbs.ToString();
        fi.text = fiber.ToString();
        s.text = sodium.ToString();
    }
    public void updateBurgerValues()
    {
        calories = 550;
        protien = 28;
        fat = 32;
        carbs = 42;
        fiber = 4;
        sodium = 1000;
    }
    public void updateCAValues()
    {
        calories = 850;
        protien = 20;
        fat = 45;
        carbs = 78;
        fiber = 3;
        sodium = 850;
    }
    public void updateKRValues()
    {
        calories = 480;
        protien = 12;
        fat = 16;
        carbs = 68;
        fiber = 4;
        sodium = 1800;
    }
    public void updateMPValues()
    {
        calories = 290;
        protien = 12;
        fat = 10;
        carbs = 36;
        fiber = 2;
        sodium = 500;
    }
    public void updateOPValues()
    {
        calories = 320;
        protien = 14;
        fat = 14;
        carbs = 34;
        fiber = 3;
        sodium = 550;
    }
    public void updateSPValues()
    {
        calories = 670;
        protien = 26;
        fat = 18;
        carbs = 82;
        fiber = 6;
        sodium = 1100;
    }
    public void ResetValues()
    {
        calories = 0;
        protien = 0;
        fat = 0;
        carbs = 0;
        fiber = 0;
        sodium = 0;
    }
}
