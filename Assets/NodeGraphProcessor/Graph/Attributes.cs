﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace GraphProcessor
{
	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class InputAttribute : Attribute
	{
		public string		name;
		public string		customPullerName;
		
		public InputAttribute(string name = null, string customInputPuller = null)
		{
			this.name = name;
			this.customPullerName = customInputPuller;
		}
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class OutputAttribute : Attribute
	{
		public string		name;
		public string		customPusherName;

		public OutputAttribute(string name = null, string customOutputPusher = null)
		{
			this.name = name;
			this.customPusherName = customOutputPusher;
		}
	}
	
	[AttributeUsage(AttributeTargets.Class)]
	public class NodeMenuItemAttribute : Attribute
	{
		public string	menuTitle;

		public NodeMenuItemAttribute(string menuTitle = null)
		{
			this.menuTitle = menuTitle;
		}
	}

	[AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
	public class FieldDrawerAttribute : Attribute
	{
		public Type		fieldType;

		public FieldDrawerAttribute(Type fieldType)
		{
			this.fieldType = fieldType;
		}
	}
}