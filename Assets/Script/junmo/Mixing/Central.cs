using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Central : MonoBehaviour
{
    public Transform invisibleCard;

    List<Arranger> arrangers;

    void Start()
    {
        arrangers = new List<Arranger>();

        var arrs = transform.GetComponentsInChildren<Arranger>();

        for (int i = 0; i < arrs.Length; i++)
        {
            arrangers.Add(arrs[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void SwapCards(Transform sour,Transform dest)
    {
        Transform sourParent = sour.parent;
        Transform destParent = dest.parent;

        int sourIndex = sour.GetSiblingIndex();
        int destIndex = dest.GetSiblingIndex();

        sour.SetParent(destParent);
        sour.SetSiblingIndex(destIndex);

        dest.SetParent(sourParent);
        dest.SetSiblingIndex(sourIndex);
    }

    void SwapCardsinHierarchy(Transform sour, Transform dest)
    {
        SwapCards(sour, dest);
        arrangers.ForEach(t => t.UpdateChildren());
    }

    bool ContainPos(RectTransform rt, Vector2 pos)
    {
        return RectTransformUtility.RectangleContainsScreenPoint(rt, pos);
    }

    void BeginDrag(Transform card)
    {
        //Debug.Log("BeginDrag : " + card.name);

        SwapCardsinHierarchy(invisibleCard, card);
    }

    void Drag(Transform card)
    {
        //Debug.Log("Drag : " + card.name);

        var whichArrangerCard = arrangers.Find(t => ContainPos(t.transform as RectTransform, card.position));

        if(whichArrangerCard == null)
        {
            
        }
        else
        {
            //Debug.Log(whichArrangerCard.GetIndexByPosition(card, invisibleCard.GetSiblingIndex()));
            int invisibleCardIndex = invisibleCard.GetSiblingIndex();
            int targetIndex = whichArrangerCard.GetIndexByPosition(card, invisibleCardIndex);

            if (invisibleCardIndex != targetIndex)
            {
                whichArrangerCard.SwapCard(invisibleCardIndex, targetIndex);
            }
        }

    }
    void EndDrag(Transform card)
    {
        //Debug.Log("EndDrag : " + card.name);
        //1

        SwapCardsinHierarchy(invisibleCard, card);
    }

    public void NextDay()
    {
        SceneManager.LoadScene("Total");
    }
}
