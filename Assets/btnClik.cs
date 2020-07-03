using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class btnClik : MonoBehaviour
{
    public Button btn;
    public Image box0;
    public Image box1;
    public Image box2;
    public Image box3;
    public Image box4;
    public Image box5;
    public Image box6;
    public Image box7;
    public Image box8;

    public Image Image0;
    public Sprite sp0;
    public Image Image1;
    public Sprite sp1;
    public Image Image2;
    public Sprite sp2;
    public Image Image3;
    public Sprite sp3;
    public Image Image4;
    public Sprite sp4;
    public Image Image5;
    public Sprite sp5;
    public Image Image6;
    public Sprite sp6;
    public Image Image7;
    public Sprite sp7;
    public Image Image8;
    public Sprite sp8;



    public int x,sayac=0;
    System.Random rnd = new System.Random();
    public List<int> unlockBox = new List<int>();
    public List<Image> boxlar = new List<Image>();

    // Start is called before the first frame update
    void Start()
    {
        boxlar.Add(box0);
        boxlar.Add(box1);
        boxlar.Add(box2);
        boxlar.Add(box3);
        boxlar.Add(box4);
        boxlar.Add(box5);
        boxlar.Add(box6);
        boxlar.Add(box7);
        boxlar.Add(box8);
    }

    // Update is called once per frame
    void Update()
    {
        

    }

 
    public void open() {
        sayac++;
        for (int i = 0; i < 3; i++)
        {               
            KapaliKutuBul();
            
            if (i == 2)
            {
                boxlar[x].color = Color.green;
                resimDegistir(x);
                unlockBox.Add(x);
                x = -1;
                
            }

        }

        if (sayac == 9) {
            btn.enabled = false;
        }




    }

    public void KapaliKutuBul() {
        x = rnd.Next(0, 9);
            foreach (int y in unlockBox) {
                if (x == y)
                {
                    KapaliKutuBul();
                }               
            }
        
            
    }

    public void resimDegistir(int x) {

        if (x == 0) {
            Image0.sprite = sp0;
        }
        if (x == 1)
        {
            Image1.sprite = sp1;
        }
        if (x == 2)
        {
            Image2.sprite = sp2;
        }
        if (x == 3)
        {
            Image3.sprite = sp3;
        }
        if (x == 4)
        {
            Image4.sprite = sp4;
        }
        if (x == 5)
        {
            Image5.sprite = sp5;
        }
        if (x == 6)
        {
            Image6.sprite = sp7;
        }
        if (x == 7)
        {
            Image7.sprite = sp7;
        }
        if (x == 8)
        {
            Image8.sprite = sp8;
        }

    }

    


}


