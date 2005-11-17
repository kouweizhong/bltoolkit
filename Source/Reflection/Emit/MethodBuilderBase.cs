using System;
using System.Reflection;

namespace BLToolkit.Reflection.Emit
{
	/// <summary>
	/// Base class for wrappers around methods and constructors.
	/// </summary>
	public abstract class MethodBuilderBase
	{
		/// <summary>
		/// Initializes a new instance of the <see cref="MethodBuilderHelper"/> class
		/// with the specified parameters.
		/// </summary>
		/// <param name="typeBuilder">Associated <see cref="TypeBuilderHelper"/>.</param>
		/// <param name="methodBuilder">A <see cref="MethodBuilder"/></param>
		protected MethodBuilderBase(TypeBuilderHelper typeBuilder)
		{
			if (typeBuilder == null) throw new ArgumentNullException("typeBuilder");

			_type = typeBuilder;
		}

		private TypeBuilderHelper _type;
		/// <summary>
		/// Gets associated TypeBuilderHelper.
		/// </summary>
		public  TypeBuilderHelper  Type
		{
			get { return _type; }
		}

		/// <summary>
		/// Gets EmitHelper.
		/// </summary>
		public abstract EmitHelper Emitter { get; }
	}
}
