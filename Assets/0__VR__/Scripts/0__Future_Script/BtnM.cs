using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnM : MonoBehaviour
{
    public List<GameObject> checkSymbol = new List<GameObject>();
    public GlassSizeUp glass;
    public GameObject smWind;

    private int count = 0;

    public bool check0 = false;
    public bool check1 = false;
    public bool check2 = false;
    public bool check3 = false;
    public bool check4 = false;
    public bool check5 = false;
    public bool check6 = false;
    public bool check7 = false;
    public bool check8 = false;
    public bool check9 = false;

    public void Check0()
    {
        checkSymbol[0].SetActive(true);
    }

    public void Check1()
    {
        checkSymbol[1].SetActive(true);
    }
    public void Check2()
    {
        checkSymbol[2].SetActive(true);
    }
    public void Check3()
    {
        checkSymbol[3].SetActive(true);
    }
    public void Check4()
    {
        checkSymbol[4].SetActive(true);
    }
    public void Check5()
    {
        checkSymbol[5].SetActive(true);
    }
    public void Check6()
    {
        checkSymbol[6].SetActive(true);
    }
    public void Check7()
    {
        checkSymbol[7].SetActive(true);
    }
    public void Check8()
    {
        checkSymbol[8].SetActive(true);
    }
    public void Check9()
    {
        checkSymbol[9].SetActive(true);
    }

    public void WindGo()
    {
        glass.isUp = true;
        smWind.SetActive(true);

    }

    public void WindStop()
    {
        glass.isUp = false;
        smWind.SetActive(false);

    }

}
