using System;
using System.Collections;
using UnityEngine;

namespace Unitility
{
	public static class Coroutine
	{

		public static void RunAfterSeconds(this MonoBehaviour context, float seconds, Action action)
			=> context.StartCoroutine(_RunAfterSeconds(seconds, action));

		private static IEnumerator _RunAfterSeconds(float seconds, Action action)
		{
			yield return new WaitForSeconds(seconds);
			action?.Invoke();
		}

	}
}
