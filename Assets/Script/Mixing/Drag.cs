using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public int Rank;
    public static int MaxRank;
    private AudioSource audioSource;
    public AudioClip Sound;
    Transform root;

    void Start()
    {
        root = transform.root;
        this.audioSource = this.gameObject.AddComponent<AudioSource>();
        this.audioSource.clip = this.Sound;
        this.audioSource.loop = false;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        root.BroadcastMessage("BeginDrag", transform, SendMessageOptions.DontRequireReceiver);
    }

    public void OnDrag(PointerEventData eventData)
    {
        transform.position = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
        root.BroadcastMessage("Drag", transform, SendMessageOptions.DontRequireReceiver);
    }
    public void OnEndDrag(PointerEventData eventData)
    {
        root.BroadcastMessage("EndDrag", transform, SendMessageOptions.DontRequireReceiver);
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Mix")
        {
            if (Input.GetMouseButton(0) == false)
            {
                MaxRank += Rank;
                Debug.Log("Rank: " + MaxRank);
                this.audioSource.Play();
            }
        }
    }
}
