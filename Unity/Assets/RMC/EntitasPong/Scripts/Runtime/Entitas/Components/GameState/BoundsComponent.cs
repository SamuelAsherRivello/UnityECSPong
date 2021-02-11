﻿using Entitas;
using RMC.Common.UnityEngineReplacement;

namespace RMC.EntitasPong.Entitas.Components.GameState
{
	/// <summary>
	/// Stores the screen bounds
	/// </summary>
	public class BoundsComponent : IComponent
	{
		// ------------------ Serialized fields and properties
		public Bounds bounds;		
	}
}