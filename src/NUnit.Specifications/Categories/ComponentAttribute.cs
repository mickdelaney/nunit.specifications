using System;
using NUnit.Framework;

namespace NUnit.Specifications
{
	[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true,
		Inherited = true)]
	public sealed class ComponentAttribute : CategoryAttribute
	{
		public ComponentAttribute() : base("component")
		{
		}
	}
}