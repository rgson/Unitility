using UnityEngine;

namespace Unitility
{
	public static class Vector
	{

		public static Vector2 With(this Vector2 v, float? x = null, float? y = null)
			=> new Vector2(x ?? v.x, y ?? v.y);

		public static Vector2Int With(this Vector2Int v, int? x = null, int? y = null)
			=> new Vector2Int(x ?? v.x, y ?? v.y);

		public static Vector3 With(this Vector3 v, float? x = null, float? y = null, float? z = null)
			=> new Vector3(x ?? v.x, y ?? v.y, z ?? v.z);

		public static Vector3Int With(this Vector3Int v, int? x = null, int? y = null, int? z = null)
			=> new Vector3Int(x ?? v.x, y ?? v.y, z ?? v.z);

	}
}
