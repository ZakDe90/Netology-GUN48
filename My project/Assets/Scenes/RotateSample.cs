using System.Collections;
using UnityEngine;

public class RotateSample : MonoBehaviour
{
	[SerializeField]
	private Vector3 _angle = new Vector3(0f, 5f, 0f);

	private IEnumerator Start()
	{
		while(true)
		{
			transform.Rotate(_angle * Time.deltaTime);
			yield return null;
		}
	}
}