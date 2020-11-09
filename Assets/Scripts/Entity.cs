﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StretchySurgeon {
	public abstract class Entity : MonoBehaviour
	{
		public TileGrid grid;

		public abstract bool IsOccupyingTile(Vector2Int tile);
	}
}
