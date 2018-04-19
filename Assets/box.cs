using System.Collections;
3. using System.Collections.Generic;
4. using UnityEngine;

5.
6. public class box : MonoBehaviour
{
7.
8. // Use this for initialization
9. void Start()
    {
        10.
11. }
12.
13. // Update is called once per frame
14. void Update()
    {
        15.transform.Rotate(new Vector3(15, 30, 45) * Time.deltaTime);
        16. }
17. }
