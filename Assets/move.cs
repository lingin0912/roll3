using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
public class move1 : MonoBehaviour
{
    Rigidbody rb;
    public float speed;
    public Text countText;
    public Text winText;
    public Text myTime;
    int count;
    DateTime curr;
    // Use this for initialization
    void Start()
    {
        count = 0;
        countText.text = &quot; 分數：&quot; ;
        winText.text = &quot; &quot; ;
        curr = DateTime.Now;
        myTime.text = &quot; 10 & quot; ;
        rb = GetComponent & lt; Rigidbody & gt; ();


    }
    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis(&quot; Horizontal & quot;);
        float z = Input.GetAxis(&quot; Vertical & quot;);
        rb.AddForce(new Vector3(x, 0, z) * speed);
        TimeSpan ts = DateTime.Now - curr;
        if (ts.Seconds & lt; 10)
{
            myTime.text = (10 - ts.Seconds).ToString() + &quot;:&quot; +(1000 -
            ts.Milliseconds).ToString();
        }
else
{
            myTime.text = &quot; 0 & quot; ;
            winText.text = &quot; You lose!&quot; ;
        }

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(&quot; pick & quot;))
{
            other.gameObject.SetActive(false);
            count++;
            countText.text = &quot; 分數：&quot; +count.ToString();
            if (count & gt;= 3) {
                winText.text = &quot; You Win!!!!&quot; ;
            }
        }
    }
}