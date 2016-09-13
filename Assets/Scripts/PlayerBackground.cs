﻿using UnityEngine;
using UnityEngine.UI;
using Rewired;
using System.Collections;

public class PlayerBackground : MonoBehaviour {
    enum SelectableCharacters { Leslie, Jona, Ashita, Catarine, Ramsey, Drogas, Sylvia, Bjin, Xavier, None};
    SelectableCharacters curChar;
    public GameObject Leslie, Jona, Ashita, Catarine, Ramsey, Drogas, Sylvia, Bjin, Xavier;
    public Sprite[] SelectedImages;
    public Sprite[] HoverImages;
    GameObject CD, ND, NED, ED, SED, SD, SWD, WD, NWD;
    bool characterChosen;
    GameObject TextObject;
    
    void Start()
    {
        TextObject = this.gameObject;
        curChar = SelectableCharacters.None;
        CD = GameObject.Find("CenterDiamond");
        ND = GameObject.Find("NorthDiamond");
        NED = GameObject.Find("NorthEastDiamond");
        ED = GameObject.Find("EastDiamond");
        SED = GameObject.Find("SouthEastDiamond");
        SD = GameObject.Find("SouthDiamond");
        SWD = GameObject.Find("SouthWestDiamond");
        WD = GameObject.Find("WestDiamond");
        NWD = GameObject.Find("NorthWestDiamond");
    }

	void Update () {
	    
	}

    public void switchChar(Collider2D collin)
    {
        switch (collin.name)
        {
            case "CenterDiamond":
                //if (!CD.GetComponent<Collider2D>().isTrigger)
                //{
                //    CD.GetComponent<Collider2D>().isTrigger = true;
                //}
                makeAllDissapear();
                Leslie.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Leslie";
                curChar = SelectableCharacters.Leslie;
                break;
            case "NorthDiamond":
                makeAllDissapear();
                Jona.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Jona";
                curChar = SelectableCharacters.Jona;
                break;
            case "NorthEastDiamond":
                makeAllDissapear();
                Ashita.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Ashita";
                curChar = SelectableCharacters.Ashita;
                break;
            case "EastDiamond":
                makeAllDissapear();
                Catarine.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Catarine";
                curChar = SelectableCharacters.Catarine;
                break;
            case "SouthEastDiamond":
                makeAllDissapear();
                Ramsey.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Ramsey";
                curChar = SelectableCharacters.Ramsey;
                break;
            case "SouthDiamond":
                makeAllDissapear();
                Drogas.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Drogas";
                curChar = SelectableCharacters.Drogas;
                break;
            case "SouthWestDiamond":
                makeAllDissapear();
                Sylvia.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Sylvia";
                curChar = SelectableCharacters.Sylvia;
                break;
            case "WestDiamond":
                makeAllDissapear();
                Bjin.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Bjin";
                curChar = SelectableCharacters.Bjin;
                break;
            case "NorthWestDiamond":
                makeAllDissapear();
                Xavier.SetActive(true);
                TextObject.GetComponentInChildren<Text>().text = "Xavier";
                curChar = SelectableCharacters.Xavier;
                break;
            default:
                break;
        }
    }

    public void selectChar()
    {
        switch (curChar)
        {
            case SelectableCharacters.Leslie:
                TextObject.GetComponentInChildren<Text>().text = "Leslie Selected";
                Leslie.GetComponent<Image>().sprite = SelectedImages[0];
                CD.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Jona:
                TextObject.GetComponentInChildren<Text>().text = "Jona Selected";
                Jona.GetComponent<Image>().sprite = SelectedImages[1];
                ND.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Ashita:
                TextObject.GetComponentInChildren<Text>().text = "Ashita Selected";
                Ashita.GetComponent<Image>().sprite = SelectedImages[2];
                NED.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Catarine:
                TextObject.GetComponentInChildren<Text>().text = "Catarine Selected";
                Catarine.GetComponent<Image>().sprite = SelectedImages[3];
                ED.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Ramsey:
                TextObject.GetComponentInChildren<Text>().text = "Ramsey Selected";
                Ramsey.GetComponent<Image>().sprite = SelectedImages[4];
                SED.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Drogas:
                TextObject.GetComponentInChildren<Text>().text = "Drogas Selected";
                Drogas.GetComponent<Image>().sprite = SelectedImages[5];
                SD.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Sylvia:
                TextObject.GetComponentInChildren<Text>().text = "Sylvia Selected";
                Sylvia.GetComponent<Image>().sprite = SelectedImages[6];
                SWD.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Bjin:
                TextObject.GetComponentInChildren<Text>().text = "Bjin Selected";
                Bjin.GetComponent<Image>().sprite = SelectedImages[7];
                WD.GetComponent<Collider2D>().isTrigger = false;
                break;
            case SelectableCharacters.Xavier:
                TextObject.GetComponentInChildren<Text>().text = "Xavier Selected";
                Xavier.GetComponent<Image>().sprite = SelectedImages[8];
                NWD.GetComponent<Collider2D>().isTrigger = false;
                break;
            default:
                break;
        }
    }

    public void makeAllDissapear()
    {
        Leslie.SetActive(false);
        Jona.SetActive(false);
        Ashita.SetActive(false);
        Catarine.SetActive(false);
        Ramsey.SetActive(false);
        Drogas.SetActive(false);
        Sylvia.SetActive(false);
        Bjin.SetActive(false);
        Xavier.SetActive(false);
    }

    public void CancelSelection()
    {
        switch (curChar)
        {
            case SelectableCharacters.Leslie:
                CD.GetComponent<Collider2D>().isTrigger = true;
                Leslie.GetComponent<Image>().sprite = HoverImages[0];
                break;
            case SelectableCharacters.Jona:
                ND.GetComponent<Collider2D>().isTrigger = true;
                Jona.GetComponent<Image>().sprite = HoverImages[1];
                break;
            case SelectableCharacters.Ashita:
                NED.GetComponent<Collider2D>().isTrigger = true;
                Ashita.GetComponent<Image>().sprite = HoverImages[2];
                break;
            case SelectableCharacters.Catarine:
                ED.GetComponent<Collider2D>().isTrigger = true;
                Catarine.GetComponent<Image>().sprite = HoverImages[3];
                break;
            case SelectableCharacters.Ramsey:
                SED.GetComponent<Collider2D>().isTrigger = true;
                Ramsey.GetComponent<Image>().sprite = HoverImages[4];
                break;
            case SelectableCharacters.Drogas:
                SD.GetComponent<Collider2D>().isTrigger = true;
                Drogas.GetComponent<Image>().sprite = HoverImages[5];
                break;
            case SelectableCharacters.Sylvia:
                SWD.GetComponent<Collider2D>().isTrigger = true;
                Sylvia.GetComponent<Image>().sprite = HoverImages[6];
                break;
            case SelectableCharacters.Bjin:
                WD.GetComponent<Collider2D>().isTrigger = true;
                Bjin.GetComponent<Image>().sprite = HoverImages[7];
                break;
            case SelectableCharacters.Xavier:
                NWD.GetComponent<Collider2D>().isTrigger = true;
                Xavier.GetComponent<Image>().sprite = HoverImages[8];
                break;
            case SelectableCharacters.None:
                break;
            default:
                break;
        }
    }

}
