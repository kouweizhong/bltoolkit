using System;

namespace BLToolkit.TypeBuilder
{
	[AttributeUsage(AttributeTargets.Property)]
	public sealed class DefaultInstanceTypeAttribute : Builders.AbstractTypeBuilderAttribute
	{
		public DefaultInstanceTypeAttribute ()
		{
		}

		public override Builders.IAbstractTypeBuilder  TypeBuilder
		{
			get { return new Builders.DefaultTypeBuilder(); }
		}
	}
}
