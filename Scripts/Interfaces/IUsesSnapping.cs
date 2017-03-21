﻿using System;
using UnityEngine;

namespace UnityEditor.Experimental.EditorVR
{
	public interface IUsesSnapping
	{
		Func<object, Vector3, Vector3, Vector3> translateWithSnapping { set; }
	}
}